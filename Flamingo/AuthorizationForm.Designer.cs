namespace Flamingo
{
    partial class AuthorizationForm
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CollapseButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.AuthorizationButton = new System.Windows.Forms.PictureBox();
            this.ShowPasswordButton = new System.Windows.Forms.PictureBox();
            this.ErrorTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordButton)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationButton.AutoSize = true;
            this.RegistrationButton.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.Location = new System.Drawing.Point(606, 388);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(152, 60);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Registrtion";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButtonClickHandler);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(298, 218);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(40, 51);
            this.ErrorLabel.TabIndex = 18;
            this.ErrorLabel.Text = "*";
            this.ErrorLabel.Visible = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTextBox.Location = new System.Drawing.Point(107, 218);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(185, 28);
            this.LoginTextBox.TabIndex = 19;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(107, 270);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(155, 28);
            this.PasswordTextBox.TabIndex = 20;
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CollapseButton.Location = new System.Drawing.Point(693, 3);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(35, 35);
            this.CollapseButton.TabIndex = 21;
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
            this.CloseButton.TabIndex = 17;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.AuthorizationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AuthorizationButton.Location = new System.Drawing.Point(118, 322);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(160, 37);
            this.AuthorizationButton.TabIndex = 16;
            this.AuthorizationButton.TabStop = false;
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordButton.Location = new System.Drawing.Point(266, 270);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(31, 28);
            this.ShowPasswordButton.TabIndex = 22;
            this.ShowPasswordButton.TabStop = false;
            this.ShowPasswordButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton_MouseDown);
            this.ShowPasswordButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton_MouseUp);
            // 
            // ErrorTextLabel
            // 
            this.ErrorTextLabel.AutoSize = true;
            this.ErrorTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorTextLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorTextLabel.Location = new System.Drawing.Point(104, 302);
            this.ErrorTextLabel.Name = "ErrorTextLabel";
            this.ErrorTextLabel.Size = new System.Drawing.Size(195, 17);
            this.ErrorTextLabel.TabIndex = 23;
            this.ErrorTextLabel.Text = "Неверный логин или пароль";
            this.ErrorTextLabel.Visible = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 460);
            this.Controls.Add(this.ErrorTextLabel);
            this.Controls.Add(this.ShowPasswordButton);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.RegistrationButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.PictureBox AuthorizationButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox CollapseButton;
        private System.Windows.Forms.PictureBox ShowPasswordButton;
        private System.Windows.Forms.Label ErrorTextLabel;
    }
}

