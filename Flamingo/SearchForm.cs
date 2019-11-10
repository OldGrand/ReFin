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

namespace Flamingo
{
    public partial class SearchForm : Form
    {
        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);
        private const int cGrip = 16;     
        private const int cCaption = 32;
        private Thread inthernetChecker;
        private Preloader preloader;
        private RootObject rootObject;
        private EventsRootObject eventsRootObject;
        private int CurrentScrollValue;

        public SearchForm()
        {
            InitializeComponent();
            Opacity = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) == 1) timer.Stop();
            });
            timer.Interval = 10;
            timer.Start();
            Focus();
            this.StartPosition = FormStartPosition.CenterScreen;

            rootObject = new RootObject();
            eventsRootObject = new EventsRootObject();

            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
            ExpandButton.BackgroundImage = ProjectResources.UnfocussedButton;
            CloseButton.MouseEnter +=  CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            CollapseButton.MouseEnter += CollapseButton_MouseEnter;
            CollapseButton.MouseLeave += CollapseButton_MouseLeave;
            ExpandButton.MouseEnter += ExpandButton_MouseEnter;
            ExpandButton.MouseLeave += ExpandButton_MouseLeave;
            this.MouseDown += SearchForm_MouseDown;
            toolStrip1.MouseDown += ToolStrip1_MouseDown;
            SearchResultsList.MouseWheel += SearchResultsList_MouseWheel;
            SearchResultsList.KeyPress += SearchResultsList_KeyPress;
            SearchResultsList.GotFocus += SearchResultsList_GotFocus;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            Wrap.Left = 0;
            Wrap.Top = toolStrip1.Top + toolStrip1.Height;
            Wrap.AutoScroll = false;
            Wrap.HorizontalScroll.Enabled = false;
            Wrap.HorizontalScroll.Visible = false;
            Wrap.HorizontalScroll.Maximum = 0;
            Wrap.AutoScroll = true;
            Wrap.Scroll += Wrap_Scroll;

            SideBar.Parent = this;
            SideBar.BringToFront();
            SideBar.Top = toolStrip1.Height + 15;

            SearchResultsList.Font = new Font("Sylfaen", 10, FontStyle.Regular);
            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            SearchResultsList.BorderStyle = BorderStyle.None;
            SearchResultsList.Top = 0;

            inthernetChecker = new Thread(InthernetChecker);    
            inthernetChecker.Start();

            preloader = new Preloader(ClientSize, this);
        }

        private void Wrap_Scroll(object sender, ScrollEventArgs e)
        {
            CurrentScrollValue = e.NewValue;
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
                    SearchTextBox.Text = "Отсутствует подключение к интернету";
                    SearchTextBox.ForeColor = Color.Red;
                    SearchTextBox.ReadOnly = true;
                    CityTextBox.ReadOnly = true;
                }
                else
                {
                    if (SearchTextBox.ForeColor.Equals(Color.Red)) 
                        SearchTextBox.Text = "";
                    SearchTextBox.ForeColor = Color.Black;
                    SearchTextBox.ReadOnly = false;
                    CityTextBox.ReadOnly = false;
                }
                Thread.Sleep(500);
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

        private void EnterFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Equals("Введите название города") || (sender as TextBox).Text.Equals("Введите поисковой запрос"))
                (sender as TextBox).Text = "";
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void LeaveFocus(object sender, EventArgs e)
        {
            if((sender as TextBox).Text.Equals("") && (sender as TextBox).Name.Equals("tbCityIpnut"))
                (sender as TextBox).Text = "Введите название города";
            else if ((sender as TextBox).Text.Equals("") && (sender as TextBox).Name.Equals("tbSearchInput"))
                (sender as TextBox).Text = "Введите поисковой запрос";
            (sender as TextBox).ForeColor = Color.Gray;
        }

        private async void StartSearch()
        {
            SearchResultsList.Text = "";
            Wrap.Visible = false;
            SearchResultsList.Visible = false;
            SideBar.Visible = false;

            if (EventsRadioButton.Checked)
            {
                MessageBox.Show("Test");
                //await Task.Run(() =>
                //{
                //    eventsRootObject = StartPredictHQSearchAsync().Result;
                //});
            }
            else if (OrganizationsRadioButton.Checked)
            {
                await Task.Run(() =>
                {
                    rootObject = StartYandexSearchAsync().Result;
                });
            }

            await Task.Run(() =>
            {
                SearchResultsList.Text = GetStringResultAsync().Result; 

                using (Graphics graphics = SearchResultsList.CreateGraphics())
                {
                    SearchResultsList.Height = (int)Math.Round(graphics.MeasureString(SearchResultsList.Text, SearchResultsList.Font).Height) + 530;
                    SearchResultsList.Width = (int)Math.Round(graphics.MeasureString(SearchResultsList.Text, SearchResultsList.Font).Width-300);
                }
            });

            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            SearchResultsList.SelectionStart = 0;
            Wrap.Visible = true;
            SearchResultsList.Visible = true;
            SideBar.Visible = true;
        }

        private async Task<string> GetStringResultAsync()
        {
            return await Task.Run(() =>
            {
                string result = "";
                foreach (var item in rootObject.features)
                    if (!string.IsNullOrWhiteSpace(item.ToString()))
                        result += $"{item}{Environment.NewLine}{Environment.NewLine}";
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
                PredictAPI predictAPI = new PredictAPI(SearchTextBox.Text, CityTextBox.Text, "SearchResult");
                predictAPI.StartSearch();
                EventsResultDeserializer eventsDeserializer = new EventsResultDeserializer("EventsSearchResult");
                return eventsDeserializer.StartDeserializing();
            });
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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
            SearchResultsList.Left = Wrap.Width / 2 - SearchResultsList.Width / 2;
            Wrap.VerticalScroll.Value = Wrap.VerticalScroll.Minimum;
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
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inthernetChecker.Abort();
        }
    }
}
