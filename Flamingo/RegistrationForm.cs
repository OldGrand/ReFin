using Flamingo.Extension_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flamingo
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = ProjectResources.RegistrationBackground;
            CollapseButton.BackgroundImage = ProjectResources.UnfocussedCollapseButton;
            CloseButton.BackgroundImage = ProjectResources.UnfocussedCloseButton;
            RegistrationButton.BackgroundImage = ProjectResources.NonActiveRegistration;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            CollapseButton.MouseEnter += CollapseButton_MouseEnter;
            CollapseButton.MouseLeave += CollapseButton_MouseLeave;
            LoginTextBox.TextChanged += EmailValidator;
            RegistrationButton.Click += PassRegistration;
            PasswordTextBox.TextChanged += TextBoxValidator;
            ConfirmPasswordTextBox.TextChanged += TextBoxValidator;
            LoginTextBox.TextChanged += TextBoxValidator;
            RegistrationButton.MouseEnter += RegistrationButton_MouseEnter;
            RegistrationButton.MouseLeave += RegistrationButton_MouseLeave;

            this.KeyDown += EnterKeyDown;
            LoginTextBox.KeyDown += EnterKeyDown;
            PasswordTextBox.KeyDown += EnterKeyDown;
            ConfirmPasswordTextBox.KeyDown += EnterKeyDown;
        }
        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(IsPasswordConfirmed() && !ErrorLabel.Visible)
                    PassRegistration(sender, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void RegistrationButton_MouseLeave(object sender, EventArgs e)
        {
            if (RegistrationButton.Enabled == true)
                RegistrationButton.BackgroundImage = ProjectResources.RegistrationActive;
        }

        private void RegistrationButton_MouseEnter(object sender, EventArgs e)
        {
            if (RegistrationButton.Enabled == true)
                RegistrationButton.BackgroundImage = ProjectResources.RegistrationFocused;
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private bool IsPasswordConfirmed()
        {
            if (PasswordTextBox.Text.Equals(ConfirmPasswordTextBox.Text))
            {
                ConfirmPasswordError.Visible = false;
                return true;
            }
            else
            {
                ConfirmPasswordError.Visible = true;
                return false;
            }
        }

        private void TextBoxValidator(object sender, EventArgs e)
        {
            if (IsPasswordConfirmed() && !ErrorLabel.Visible && LoginTextBox.Text != "" && PasswordTextBox.Text != "" && ConfirmPasswordTextBox.Text != "")
            {
                RegistrationButton.Enabled = true;
                RegistrationButton.BackgroundImage = ProjectResources.RegistrationActive;
            }
            else
            {
                RegistrationButton.Enabled = false;
                RegistrationButton.BackgroundImage = ProjectResources.NonActiveRegistration;
                if (ErrorTextLabel.Visible)
                    ErrorTextLabel.Visible = false;
            }
        }

        public void PassRegistration(object sender, EventArgs e)
        {
            DataBaseAccessor accessor = new DataBaseAccessor("DataBase", "Users");
            if (accessor.RegisterUser(LoginTextBox.Text, PasswordTextBox.Text))
                Close();
            else
                ErrorTextLabel.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
