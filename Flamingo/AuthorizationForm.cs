using Flamingo.Extension_Classes;
using System;
using System.Media;
using System.Windows.Forms;

namespace Flamingo
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) == 1) timer.Stop();
            });
            timer.Interval = 10;
            timer.Start();

            this.Activate();
            StartPosition = FormStartPosition.CenterScreen;
            BackgroundImage = ProjectResources.AuthorizationBackground;
            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
            AuthorizationButton.BackgroundImage = ProjectResources.UnfocussedAuthorizationButton;
            ShowPasswordButton.BackgroundImage = ProjectResources.PasswordEye;
            LoginTextBox.TextChanged += EmailValidator;
            AuthorizationButton.Click += PassAuthorization;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            AuthorizationButton.MouseEnter += AuthorizationButton_MouseEnter;
            AuthorizationButton.MouseLeave += AuthorizationButton_MouseLeave;
            CollapseButton.MouseEnter += CollapseButton_MouseEnter;
            CollapseButton.MouseLeave += CollapseButton_MouseLeave;
            this.KeyDown += AuthorizationForm_KeyDown;
            LoginTextBox.KeyDown += AuthorizationForm_KeyDown;
            PasswordTextBox.KeyDown += AuthorizationForm_KeyDown;
            PasswordTextBox.LostFocus += SetPassCharInTextBox;
            PasswordTextBox.GotFocus += SetPassCharInTextBox;
            ShowPasswordButton.MouseUp += SetPassCharInTextBox;
            ShowPasswordButton.MouseDown += ShowPasswordButtonMouseDown;
        }

        private void SetPassCharInTextBox(object sender, EventArgs e)
        {
            if (!PasswordTextBox.PlaceHolderText.Equals(PasswordTextBox.Text))
                PasswordTextBox.PasswordChar = '•';
            else
                PasswordTextBox.PasswordChar = '\0';
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PassAuthorization(sender, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CollapseButton_MouseEnter(object sender, EventArgs e)
        {
            CollapseButton.BackgroundImage = ProjectResources.FocussedCollapseButton;
        }

        private void CollapseButton_MouseLeave(object sender, EventArgs e)
        {
            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
        }

        private void AuthorizationButton_MouseLeave(object sender, EventArgs e)
        {
            if (AuthorizationButton.Enabled == true)
                AuthorizationButton.BackgroundImage = ProjectResources.UnfocussedAuthorizationButton;
        }

        private void AuthorizationButton_MouseEnter(object sender, EventArgs e)
        {
            if (AuthorizationButton.Enabled == true)
                AuthorizationButton.BackgroundImage = ProjectResources.FoccusedAuthorizationButton;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = ProjectResources.FocussedCloseButton;
        }

        public void EmailValidator(object sender, EventArgs e)
        {
            if (ExtensionClasses.EmailValidation((sender as TextBox).Text))
            {
                ErrorLabel.Visible = false;
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        public void PassAuthorization(object sender, EventArgs e)
        {
            DataBaseAccessor accessor = new DataBaseAccessor("DataBase", "Users");
            if (accessor.VerifyUserData(LoginTextBox.Text, PasswordTextBox.Text))
            {
                this.Hide();
                SearchForm mainForm = new SearchForm(LoginTextBox.Text);
                mainForm.Closed += (send, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                ErrorTextLabel.Visible = true;
                PasswordTextBox.Text = "";
            }
        }

        private void RegistrationButtonClickHandler(object sender, EventArgs e)
        {
            var soundPlayer = new SoundPlayer(@"sound3.wav");
            soundPlayer.Play();
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Show();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordButtonMouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.PasswordChar = '\0';
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var soundPlayer = new SoundPlayer(@"sound3.wav");
            soundPlayer.Play();
        }
    }
}
