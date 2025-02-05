﻿namespace Flamingo
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.Wrap = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.SendToEmailButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.OrganizationsRadioButton = new System.Windows.Forms.RadioButton();
            this.EventsRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchResultsList = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MoveNogginLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Noggin = new System.Windows.Forms.PictureBox();
            this.CityPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.ExpandButton = new System.Windows.Forms.PictureBox();
            this.CollapseButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CityTextBox = new Flamingo.Classes.PHTextBox();
            this.SearchTextBox = new Flamingo.Classes.PHTextBox();
            this.NogginSwitcherCheckBox = new System.Windows.Forms.CheckBox();
            this.Wrap.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendToEmailButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noggin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Wrap
            // 
            this.Wrap.BackColor = System.Drawing.Color.White;
            this.Wrap.Controls.Add(this.SideBar);
            this.Wrap.Controls.Add(this.SearchResultsList);
            this.Wrap.Location = new System.Drawing.Point(225, 240);
            this.Wrap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Wrap.Name = "Wrap";
            this.Wrap.Size = new System.Drawing.Size(833, 444);
            this.Wrap.TabIndex = 25;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Transparent;
            this.SideBar.BackgroundImage = global::Flamingo.ProjectResources.SideBarBG;
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.NogginSwitcherCheckBox);
            this.SideBar.Controls.Add(this.SendToEmailButton);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.Controls.Add(this.EndDate);
            this.SideBar.Controls.Add(this.StartDate);
            this.SideBar.Controls.Add(this.OrganizationsRadioButton);
            this.SideBar.Controls.Add(this.EventsRadioButton);
            this.SideBar.Location = new System.Drawing.Point(21, 20);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(178, 278);
            this.SideBar.TabIndex = 4;
            // 
            // SendToEmailButton
            // 
            this.SendToEmailButton.BackgroundImage = global::Flamingo.ProjectResources.SendToEmailButton;
            this.SendToEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendToEmailButton.Location = new System.Drawing.Point(14, 221);
            this.SendToEmailButton.Name = "SendToEmailButton";
            this.SendToEmailButton.Size = new System.Drawing.Size(144, 42);
            this.SendToEmailButton.TabIndex = 8;
            this.SendToEmailButton.TabStop = false;
            this.SendToEmailButton.Click += new System.EventHandler(this.SendToEmailButton_Click);
            this.SendToEmailButton.MouseEnter += new System.EventHandler(this.SendToEmailButton_MouseEnter);
            this.SendToEmailButton.MouseLeave += new System.EventHandler(this.SendToEmailButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата завершения";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(15, 145);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(143, 22);
            this.EndDate.TabIndex = 4;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(15, 90);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(143, 22);
            this.StartDate.TabIndex = 3;
            // 
            // OrganizationsRadioButton
            // 
            this.OrganizationsRadioButton.AutoSize = true;
            this.OrganizationsRadioButton.Checked = true;
            this.OrganizationsRadioButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationsRadioButton.Location = new System.Drawing.Point(14, 12);
            this.OrganizationsRadioButton.Name = "OrganizationsRadioButton";
            this.OrganizationsRadioButton.Size = new System.Drawing.Size(143, 30);
            this.OrganizationsRadioButton.TabIndex = 1;
            this.OrganizationsRadioButton.TabStop = true;
            this.OrganizationsRadioButton.Text = "Заведения";
            this.OrganizationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // EventsRadioButton
            // 
            this.EventsRadioButton.AutoSize = true;
            this.EventsRadioButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventsRadioButton.Location = new System.Drawing.Point(14, 39);
            this.EventsRadioButton.Name = "EventsRadioButton";
            this.EventsRadioButton.Size = new System.Drawing.Size(122, 30);
            this.EventsRadioButton.TabIndex = 0;
            this.EventsRadioButton.Text = "События";
            this.EventsRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchResultsList
            // 
            this.SearchResultsList.BackColor = System.Drawing.SystemColors.Window;
            this.SearchResultsList.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultsList.Location = new System.Drawing.Point(315, 119);
            this.SearchResultsList.MinimumSize = new System.Drawing.Size(400, 100);
            this.SearchResultsList.Multiline = true;
            this.SearchResultsList.Name = "SearchResultsList";
            this.SearchResultsList.Size = new System.Drawing.Size(400, 106);
            this.SearchResultsList.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(100, 25, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1100, 64);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MoveNogginLeftTimer
            // 
            this.MoveNogginLeftTimer.Interval = 1;
            this.MoveNogginLeftTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Noggin
            // 
            this.Noggin.BackColor = System.Drawing.Color.Transparent;
            this.Noggin.Image = global::Flamingo.Properties.Resources.Noggin1;
            this.Noggin.Location = new System.Drawing.Point(0, 289);
            this.Noggin.Name = "Noggin";
            this.Noggin.Size = new System.Drawing.Size(158, 221);
            this.Noggin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Noggin.TabIndex = 30;
            this.Noggin.TabStop = false;
            // 
            // CityPictureBox
            // 
            this.CityPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.CityPictureBox.BackgroundImage = global::Flamingo.Properties.Resources.CityInfoField;
            this.CityPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CityPictureBox.Location = new System.Drawing.Point(0, 5);
            this.CityPictureBox.Name = "CityPictureBox";
            this.CityPictureBox.Size = new System.Drawing.Size(206, 50);
            this.CityPictureBox.TabIndex = 27;
            this.CityPictureBox.TabStop = false;
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.SearchPictureBox.BackgroundImage = global::Flamingo.Properties.Resources.SR2;
            this.SearchPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPictureBox.Location = new System.Drawing.Point(212, 5);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(767, 50);
            this.SearchPictureBox.TabIndex = 26;
            this.SearchPictureBox.TabStop = false;
            // 
            // ExpandButton
            // 
            this.ExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.ExpandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExpandButton.Location = new System.Drawing.Point(1021, 12);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(35, 35);
            this.ExpandButton.TabIndex = 24;
            this.ExpandButton.TabStop = false;
            this.ExpandButton.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CollapseButton.Location = new System.Drawing.Point(980, 12);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(35, 35);
            this.CollapseButton.TabIndex = 23;
            this.CollapseButton.TabStop = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(1062, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityTextBox.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CityTextBox.Location = new System.Drawing.Point(16, 14);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.PlaceHolderText = "Город...";
            this.CityTextBox.Size = new System.Drawing.Size(170, 33);
            this.CityTextBox.TabIndex = 29;
            this.CityTextBox.Text = "Город...";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextBox.Location = new System.Drawing.Point(225, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceHolderText = "Введите то что вы ищете...";
            this.SearchTextBox.Size = new System.Drawing.Size(711, 33);
            this.SearchTextBox.TabIndex = 28;
            this.SearchTextBox.Text = "Введите то что вы ищете...";
            // 
            // NogginSwitcherCheckBox
            // 
            this.NogginSwitcherCheckBox.AutoSize = true;
            this.NogginSwitcherCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NogginSwitcherCheckBox.Location = new System.Drawing.Point(7, 184);
            this.NogginSwitcherCheckBox.Name = "NogginSwitcherCheckBox";
            this.NogginSwitcherCheckBox.Size = new System.Drawing.Size(160, 21);
            this.NogginSwitcherCheckBox.TabIndex = 32;
            this.NogginSwitcherCheckBox.Text = "Отключить гнома";
            this.NogginSwitcherCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Noggin);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CityPictureBox);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.Wrap);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "SearchForm";
            this.Text = "AdditionalInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Resize += new System.EventHandler(this.SearchForm_Resize);
            this.Wrap.ResumeLayout(false);
            this.Wrap.PerformLayout();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendToEmailButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noggin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox CollapseButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox ExpandButton;
        private System.Windows.Forms.Panel Wrap;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.PictureBox CityPictureBox;
        private System.Windows.Forms.TextBox SearchResultsList;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.RadioButton OrganizationsRadioButton;
        private System.Windows.Forms.RadioButton EventsRadioButton;
        private Classes.PHTextBox SearchTextBox;
        private Classes.PHTextBox CityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SendToEmailButton;
        private System.Windows.Forms.PictureBox Noggin;
        private System.Windows.Forms.Timer MoveNogginLeftTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox NogginSwitcherCheckBox;
    }
}