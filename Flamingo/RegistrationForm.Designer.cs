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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordError = new System.Windows.Forms.Label();
            this.ErrorTextLabel = new System.Windows.Forms.Label();
            this.CollapseButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new Flamingo.Classes.PHTextBox();
            this.PasswordTextBox = new Flamingo.Classes.PHTextBox();
            this.LoginTextBox = new Flamingo.Classes.PHTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationButton)).BeginInit();
            this.SuspendLayout();
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
            this.CollapseButton.Location = new System.Drawing.Point(693, 2);
            this.CollapseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(35, 34);
            this.CollapseButton.TabIndex = 23;
            this.CollapseButton.TabStop = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(735, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 34);
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
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(160, 37);
            this.RegistrationButton.TabIndex = 10;
            this.RegistrationButton.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(105, 319);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PlaceHolderText = "confirm password";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(189, 20);
            this.ConfirmPasswordTextBox.TabIndex = 29;
            this.ConfirmPasswordTextBox.Text = "confirm password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(105, 268);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceHolderText = "password";
            this.PasswordTextBox.Size = new System.Drawing.Size(189, 20);
            this.PasswordTextBox.TabIndex = 28;
            this.PasswordTextBox.Text = "password";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.Location = new System.Drawing.Point(105, 218);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceHolderText = "e-mail";
            this.LoginTextBox.Size = new System.Drawing.Size(189, 20);
            this.LoginTextBox.TabIndex = 27;
            this.LoginTextBox.Text = "e-mail";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ErrorTextLabel);
            this.Controls.Add(this.ConfirmPasswordError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegistrationButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationForm";
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RegistrationButton;
        private System.Windows.Forms.PictureBox CollapseButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ConfirmPasswordError;
        private System.Windows.Forms.Label ErrorTextLabel;
        private Classes.PHTextBox LoginTextBox;
        private Classes.PHTextBox PasswordTextBox;
        private Classes.PHTextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button button1;
    }
}

