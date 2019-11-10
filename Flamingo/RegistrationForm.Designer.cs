namespace Flamingo
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordError = new System.Windows.Forms.Label();
            this.ErrorTextLabel = new System.Windows.Forms.Label();
            this.CollapseButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(105, 269);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(190, 28);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.Tag = "Centering";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.Location = new System.Drawing.Point(105, 218);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(190, 28);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.Tag = "Centering";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(105, 321);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(190, 28);
            this.ConfirmPasswordTextBox.TabIndex = 9;
            this.ConfirmPasswordTextBox.Tag = "Centering";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(304, 218);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(40, 51);
            this.ErrorLabel.TabIndex = 24;
            this.ErrorLabel.Text = "*";
            this.ErrorLabel.Visible = false;
            // 
            // ConfirmPasswordError
            // 
            this.ConfirmPasswordError.AutoSize = true;
            this.ConfirmPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.ConfirmPasswordError.Location = new System.Drawing.Point(304, 319);
            this.ConfirmPasswordError.Name = "ConfirmPasswordError";
            this.ConfirmPasswordError.Size = new System.Drawing.Size(40, 51);
            this.ConfirmPasswordError.TabIndex = 25;
            this.ConfirmPasswordError.Text = "*";
            this.ConfirmPasswordError.Visible = false;
            // 
            // ErrorTextLabel
            // 
            this.ErrorTextLabel.AutoSize = true;
            this.ErrorTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorTextLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorTextLabel.Location = new System.Drawing.Point(43, 347);
            this.ErrorTextLabel.Name = "ErrorTextLabel";
            this.ErrorTextLabel.Size = new System.Drawing.Size(301, 17);
            this.ErrorTextLabel.TabIndex = 26;
            this.ErrorTextLabel.Text = "Данный пользователь уже зарегистрирован";
            this.ErrorTextLabel.Visible = false;
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CollapseButton.Location = new System.Drawing.Point(693, 3);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(35, 35);
            this.CollapseButton.TabIndex = 23;
            this.CollapseButton.TabStop = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(735, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegistrationButton.Enabled = false;
            this.RegistrationButton.Location = new System.Drawing.Point(124, 367);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(152, 39);
            this.RegistrationButton.TabIndex = 10;
            this.RegistrationButton.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 460);
            this.Controls.Add(this.ErrorTextLabel);
            this.Controls.Add(this.ConfirmPasswordError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.PictureBox RegistrationButton;
        private System.Windows.Forms.PictureBox CollapseButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ConfirmPasswordError;
        private System.Windows.Forms.Label ErrorTextLabel;
    }
}

