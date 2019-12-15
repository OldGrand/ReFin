using Flamingo.API;
using Flamingo.Classes;
using Flamingo.JSON_Adjustment;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;
using System.Linq;
using System.Net.Mail;
using System.Media;

namespace Flamingo
{
    public partial class SearchForm : Form
    {
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        private const string pswrd = "43896y352refhselgue";
        private string userMail;
        private bool isSearchActive;
        private const int cGrip = 16;     
        private const int cCaption = 32;
        private Thread inthernetChecker;
        private Preloader preloader;
        private RootObject rootObject;
        private EventsRootObject eventsRootObject;
        private PictureBox internetErrorPictureBox = new PictureBox();
        private static Random random = new Random();

        public SearchForm(string userMail)
        {
            this.userMail = userMail;
            InitializeComponent();
            Opacity = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) == 1) timer.Stop();
            });
            timer.Interval = 10;
            timer.Start();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MouseDown += SearchForm_MouseDown;

            rootObject = new RootObject();
            eventsRootObject = new EventsRootObject();

            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
            CollapseButton.MouseEnter += CollapseButton_MouseEnter;
            CollapseButton.MouseLeave += CollapseButton_MouseLeave;

            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
            CloseButton.MouseEnter +=  CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;

            ExpandButton.BackgroundImage = ProjectResources.UnfocussedButton;
            ExpandButton.MouseEnter += ExpandButton_MouseEnter;
            ExpandButton.MouseLeave += ExpandButton_MouseLeave;
            toolStrip1.MouseDown += ToolStrip1_MouseDown;

            SearchTextBox.KeyDown += SearchTextBox_KeyDown;

            CityTextBox.KeyDown += CityTextBox_KeyDown;

            Wrap.Left = 0;
            Wrap.Top = toolStrip1.Top + toolStrip1.Height;
            Wrap.AutoScroll = false;
            Wrap.HorizontalScroll.Enabled = false;
            Wrap.HorizontalScroll.Visible = false;
            Wrap.HorizontalScroll.Maximum = 0;
            Wrap.AutoScroll = true;

            SideBar.Parent = this;
            SideBar.BringToFront();
            SideBar.Top = toolStrip1.Height + 15;

            SearchResultsList.MouseWheel += SearchResultsList_MouseWheel;
            SearchResultsList.KeyPress += SearchResultsList_KeyPress;
            SearchResultsList.GotFocus += SearchResultsList_GotFocus;
            SearchResultsList.Font = new Font("Sylfaen", 10, FontStyle.Regular);
            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            SearchResultsList.BorderStyle = BorderStyle.None;
            SearchResultsList.Top = 0;

            inthernetChecker = new Thread(InthernetChecker);    
            inthernetChecker.Start();

            preloader = new Preloader(ClientSize, this);

            internetErrorPictureBox.Parent = this;
            internetErrorPictureBox.Left = Wrap.Left;
            internetErrorPictureBox.Top = Wrap.Top;
            internetErrorPictureBox.Width = Wrap.Width;
            internetErrorPictureBox.Height = Wrap.Height;
            internetErrorPictureBox.BackgroundImageLayout = ImageLayout.Center;
            internetErrorPictureBox.BackgroundImage = ProjectResources.InternetErrorImage;
            internetErrorPictureBox.Visible = false;

            StartDate.MinDate = DateTime.Now;
            EndDate.MinDate = DateTime.Now.AddDays(1);

            StartDate.ValueChanged += DateValueChanged;
            EndDate.ValueChanged += DateValueChanged;
            Noggin.Left = 0 - Noggin.Width;
            Noggin.Top = ClientSize.Height - Noggin.Height;
        }

        private void SearchResultsList_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }

        public void HideCaret()
        {
            HideCaret(SearchResultsList.Handle);
        }

        private void SearchResultsList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }

        private void SearchResultsList_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0) Wrap.VerticalScroll.Value-=50;
                if (e.Delta < 0) Wrap.VerticalScroll.Value+=50;
            } catch { }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2; 
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; 
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void InthernetChecker()
        {
            while (true)
            {
                if (!CheckForInternetConnection())
                {
                    Action action = () =>
                    {
                        if (!isSearchActive)
                        {
                            internetErrorPictureBox.Visible = true;
                            preloader.Visible = false;
                            Wrap.Visible = false;
                            SearchResultsList.Visible = false;
                            SideBar.Visible = false;
                            SearchTextBox.ReadOnly = true;
                            CityTextBox.ReadOnly = true;
                        }
                    };
                    Invoke(action);
                }
                else
                {
                    Action action = () =>
                    {
                        if (!isSearchActive)
                        {
                            internetErrorPictureBox.Visible = false;
                            preloader.Visible = true;
                            Wrap.Visible = true;
                            SearchResultsList.Visible = true;
                            SideBar.Visible = true;
                            SearchTextBox.ReadOnly = false;
                            CityTextBox.ReadOnly = false;
                        }
                    };
                    Invoke(action);
                }
                Thread.Sleep(1500);
            }
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void ToolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void SearchForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void ExpandButton_MouseLeave(object sender, EventArgs e)
        {
            ExpandButton.BackgroundImage = ProjectResources.UnfocussedButton;
        }

        private void ExpandButton_MouseEnter(object sender, EventArgs e)
        {
            ExpandButton.BackgroundImage = ProjectResources.FocussedExpand;
        }

        private void CollapseButton_MouseLeave(object sender, EventArgs e)
        {
            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
        }

        private void CollapseButton_MouseEnter(object sender, EventArgs e)
        {
            CollapseButton.BackgroundImage = ProjectResources.FocussedCollapseButton;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = ProjectResources.FocussedCloseButton;
        }

        private async void StartSearch()
        {
            SearchResultsList.Text = "";
            SearchResultsList.Height = 0;
            isSearchActive = true;
            internetErrorPictureBox.Visible = false;
            Wrap.Visible = false;
            SearchResultsList.Visible = false;
            SideBar.Visible = false;

            if (EventsRadioButton.Checked)
            {
                await Task.Run(() =>
                {
                    eventsRootObject = StartPredictHQSearchAsync().Result;
                });
                await Task.Run(() =>
                {
                    SearchResultsList.Text = GetStringEventResultAsync().Result;
                    using (Graphics graphics = Graphics.FromHwnd(this.Handle))
                    {
                        SearchResultsList.Height = (int)Math.Round(graphics.MeasureString(SearchResultsList.Text, SearchResultsList.Font).Height)+400;
                    }
                });
            }
            else if (OrganizationsRadioButton.Checked)
            {
                await Task.Run(() =>
                {
                    rootObject = StartYandexSearchAsync().Result;
                });
                await Task.Run(() =>
                {
                    SearchResultsList.Text = GetStringResultAsync().Result;
                    using (Graphics graphics = Graphics.FromHwnd(this.Handle))
                    {
                        SearchResultsList.Height = (int)Math.Round(graphics.MeasureString(SearchResultsList.Text, SearchResultsList.Font).Height)+200;
                    }
                });
            }

            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            SearchResultsList.SelectionStart = 0;
            isSearchActive = false;
            internetErrorPictureBox.Visible = true;
            Wrap.Visible = true;
            SearchResultsList.Visible = true;
            SideBar.Visible = true;
            MoveNogginLeftTimer.Enabled = true;
        }

        private async Task<string> GetStringResultAsync()
        {
            return await Task.Run(() =>
            {
                string result = "";
                try
                {
                    foreach (var item in rootObject.features)
                        if (!string.IsNullOrWhiteSpace(item.ToString()))
                            result += $"{item}{Environment.NewLine}{Environment.NewLine}";
                }
                catch { }
                return result;
            });
        }
       
        private async Task<string> GetStringEventResultAsync()
        {
            return await Task.Run(() =>
            {
                string result = ""; 
                try
                {
                    foreach (var item in eventsRootObject.results)
                        if (!string.IsNullOrWhiteSpace(item.ToString()))
                            result += $"{item}{Environment.NewLine}{Environment.NewLine}";
                }
                catch { }
                return result;
            });
        }

        private async Task<RootObject> StartYandexSearchAsync()
        {
            return await Task.Run(() =>
            {
                YandexAPI yandex = new YandexAPI(SearchTextBox.Text, CityTextBox.Text, "SearchResult");
                yandex.StartSearch();
                SearchResultDeserializer searchDeserializer = new SearchResultDeserializer("SearchResult");
                return searchDeserializer.StartDeserializing();
            });
        }

        private async Task<EventsRootObject> StartPredictHQSearchAsync()
        {
            return await Task.Run(() =>
            {
                PredictAPI predictAPI = new PredictAPI(SearchTextBox.Text, CityTextBox.Text, String.Join("-", StartDate.Value.ToShortDateString().Split('.').Reverse()), String.Join("-", EndDate.Value.ToShortDateString().Split('.').Reverse()), "EventsSearchResult");
                predictAPI.StartSearch();
                EventsResultDeserializer eventsDeserializer = new EventsResultDeserializer("EventsSearchResult");
                return eventsDeserializer.StartDeserializing();
            });
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void SearchForm_Resize(object sender, EventArgs e)
        {
            Wrap.Width = ClientSize.Width;
            Wrap.Height = ClientSize.Height - toolStrip1.Height - cGrip;
            internetErrorPictureBox.Width = Wrap.Width;
            internetErrorPictureBox.Height = Wrap.Height;
            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            Wrap.VerticalScroll.Value = Wrap.VerticalScroll.Minimum;
            Noggin.Top = ClientSize.Height - Noggin.Height;
            Noggin.Left = 0 - Noggin.Width;
            if (preloader != null)
            {
                preloader.Width = Wrap.Width;
                preloader.Height = Wrap.Height;
                preloader.rectangle = new Rectangle(Width / 2 - (int)Math.Round(Height * 0.25 / 2), Height / 2 - (int)Math.Round(Height * 0.25 / 2), (int)(Height * 0.25), (int)(Height * 0.25));
                preloader.bitmap = new Bitmap(preloader.bitmap, new Size(Width, Height));
                preloader.Image = preloader.bitmap;
                preloader.graphics = Graphics.FromImage(preloader.bitmap);
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {       
                StartSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inthernetChecker.Abort();
        }

        private void DateValueChanged(object sender, EventArgs e)
        {
            if (EndDate.Value.Subtract(StartDate.Value).TotalSeconds < 0)
            {
                MessageBox.Show("Момент завершения не может произайти раньше начала");
                StartDate.Value = StartDate.MinDate;
            }
        }

        private void SendToEmailButton_MouseEnter(object sender, EventArgs e)
        {
            SendToEmailButton.BackgroundImage = ProjectResources.SendToMailFocused;
        }

        private void SendToEmailButton_MouseLeave(object sender, EventArgs e)
        {
            SendToEmailButton.BackgroundImage = ProjectResources.SendToEmailButton;
        }

        private async void SendToEmailButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("refininc@gmail.com", pswrd)
                };
                using (var message = new MailMessage("refininc@gmail.com", userMail){ Subject = "ReFin"} )
                {
                    try
                    {
                        string msg = "";
                        if (EventsRadioButton.Checked && eventsRootObject.results.Count != 0)
                        {
                            foreach (var item in eventsRootObject.results)
                                msg += $"{item.title}\nRating {item.rank}\n\n";
                        }
                        else if (OrganizationsRadioButton.Checked && rootObject.features.Count != 0)
                        {
                            foreach (var item in rootObject.features)
                                msg += $"{item.properties.CompanyMetaData.Categories[0].name} {item.properties.name}\nRating {random.Next(56, 101)}\n\n";
                        }
                        message.Body = msg;

                        smtp.Send(message);
                        MessageBox.Show("Сообщение успешно отправлено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Не выполнен поисковой запрос", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            Noggin.Left = Noggin.Left + 7;
            if (Noggin.Left >= Noggin.Width)
            {
                var soundPlayer = new SoundPlayer(@"sound3.wav");
                soundPlayer.Play();
                Noggin.Image = Image.FromFile("Noggin.png");
                (sender as System.Windows.Forms.Timer).Enabled = false;
                timer2.Enabled = true;
            }       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Noggin.Left = Noggin.Left - 7;
            if (Noggin.Left <= 0 - Noggin.Width)
            {
                Noggin.Image = Image.FromFile("Noggin1.png");
                (sender as System.Windows.Forms.Timer).Enabled = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
