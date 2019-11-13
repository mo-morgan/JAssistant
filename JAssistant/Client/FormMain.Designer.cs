namespace JAssistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTabHolder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonRandomFun = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.hiddenTabsControl1 = new JAssistant.HiddenTabsControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelHome = new System.Windows.Forms.Panel();
            this.makisePicture = new System.Windows.Forms.PictureBox();
            this.panelMessageHolder = new System.Windows.Forms.Panel();
            this.chatbox1 = new JAssistant.chatbox();
            this.panelMessageTitleHolder = new System.Windows.Forms.Panel();
            this.buttonSoundOnOff = new System.Windows.Forms.Button();
            this.buttonLanguageSwitch = new System.Windows.Forms.Button();
            this.panelMakiseRoundPicture = new System.Windows.Forms.Panel();
            this.labelMakiseName = new System.Windows.Forms.Label();
            this.panelTasksHolder = new System.Windows.Forms.Panel();
            this.chatbox2 = new JAssistant.chatbox();
            this.panelTabHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.hiddenTabsControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makisePicture)).BeginInit();
            this.panelMessageHolder.SuspendLayout();
            this.panelMessageTitleHolder.SuspendLayout();
            this.panelTasksHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabHolder
            // 
            this.panelTabHolder.Controls.Add(this.label1);
            this.panelTabHolder.Controls.Add(this.pictureBox1);
            this.panelTabHolder.Controls.Add(this.pnlStats);
            this.panelTabHolder.Controls.Add(this.buttonHome);
            this.panelTabHolder.Controls.Add(this.buttonCalendar);
            this.panelTabHolder.Controls.Add(this.buttonLearn);
            this.panelTabHolder.Controls.Add(this.buttonRandomFun);
            this.panelTabHolder.Controls.Add(this.buttonSettings);
            this.panelTabHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabHolder.Location = new System.Drawing.Point(0, 0);
            this.panelTabHolder.Name = "panelTabHolder";
            this.panelTabHolder.Size = new System.Drawing.Size(200, 724);
            this.panelTabHolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "JAssistant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pnlStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pnlStats.Location = new System.Drawing.Point(0, 185);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(5, 36);
            this.pnlStats.TabIndex = 1;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(7, 185);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(193, 36);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "  Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalendar.Image")));
            this.buttonCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalendar.Location = new System.Drawing.Point(7, 236);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(193, 36);
            this.buttonCalendar.TabIndex = 4;
            this.buttonCalendar.Text = "  Calendar";
            this.buttonCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonLearn
            // 
            this.buttonLearn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLearn.FlatAppearance.BorderSize = 0;
            this.buttonLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLearn.ForeColor = System.Drawing.Color.White;
            this.buttonLearn.Image = ((System.Drawing.Image)(resources.GetObject("buttonLearn.Image")));
            this.buttonLearn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLearn.Location = new System.Drawing.Point(7, 285);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(193, 36);
            this.buttonLearn.TabIndex = 3;
            this.buttonLearn.Text = "  Learn";
            this.buttonLearn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonRandomFun
            // 
            this.buttonRandomFun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRandomFun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandomFun.FlatAppearance.BorderSize = 0;
            this.buttonRandomFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandomFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomFun.ForeColor = System.Drawing.Color.White;
            this.buttonRandomFun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRandomFun.Image")));
            this.buttonRandomFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRandomFun.Location = new System.Drawing.Point(7, 336);
            this.buttonRandomFun.Name = "buttonRandomFun";
            this.buttonRandomFun.Size = new System.Drawing.Size(193, 36);
            this.buttonRandomFun.TabIndex = 2;
            this.buttonRandomFun.Text = "  Random Fun";
            this.buttonRandomFun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRandomFun.UseVisualStyleBackColor = true;
            this.buttonRandomFun.Click += new System.EventHandler(this.buttonRandomFun_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(7, 385);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(193, 36);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // hiddenTabsControl1
            // 
            this.hiddenTabsControl1.Controls.Add(this.tabPage1);
            this.hiddenTabsControl1.Controls.Add(this.tabPage2);
            this.hiddenTabsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hiddenTabsControl1.Location = new System.Drawing.Point(200, 0);
            this.hiddenTabsControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hiddenTabsControl1.Name = "hiddenTabsControl1";
            this.hiddenTabsControl1.SelectedIndex = 0;
            this.hiddenTabsControl1.Size = new System.Drawing.Size(1031, 724);
            this.hiddenTabsControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panelHome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.makisePicture);
            this.panelHome.Controls.Add(this.panelMessageHolder);
            this.panelHome.Controls.Add(this.panelTasksHolder);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1017, 692);
            this.panelHome.TabIndex = 8;
            // 
            // makisePicture
            // 
            this.makisePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makisePicture.BackgroundImage")));
            this.makisePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makisePicture.Location = new System.Drawing.Point(0, 0);
            this.makisePicture.Name = "makisePicture";
            this.makisePicture.Size = new System.Drawing.Size(740, 489);
            this.makisePicture.TabIndex = 9;
            this.makisePicture.TabStop = false;
            // 
            // panelMessageHolder
            // 
            this.panelMessageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessageHolder.Controls.Add(this.chatbox1);
            this.panelMessageHolder.Controls.Add(this.panelMessageTitleHolder);
            this.panelMessageHolder.Location = new System.Drawing.Point(740, 0);
            this.panelMessageHolder.Name = "panelMessageHolder";
            this.panelMessageHolder.Size = new System.Drawing.Size(277, 692);
            this.panelMessageHolder.TabIndex = 10;
            // 
            // chatbox1
            // 
            this.chatbox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatbox1.Location = new System.Drawing.Point(0, 63);
            this.chatbox1.Margin = new System.Windows.Forms.Padding(8);
            this.chatbox1.Name = "chatbox1";
            this.chatbox1.Size = new System.Drawing.Size(277, 629);
            this.chatbox1.TabIndex = 1;
            // 
            // panelMessageTitleHolder
            // 
            this.panelMessageTitleHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panelMessageTitleHolder.Controls.Add(this.buttonSoundOnOff);
            this.panelMessageTitleHolder.Controls.Add(this.buttonLanguageSwitch);
            this.panelMessageTitleHolder.Controls.Add(this.panelMakiseRoundPicture);
            this.panelMessageTitleHolder.Controls.Add(this.labelMakiseName);
            this.panelMessageTitleHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessageTitleHolder.Location = new System.Drawing.Point(0, 0);
            this.panelMessageTitleHolder.Name = "panelMessageTitleHolder";
            this.panelMessageTitleHolder.Size = new System.Drawing.Size(277, 63);
            this.panelMessageTitleHolder.TabIndex = 0;
            // 
            // buttonSoundOnOff
            // 
            this.buttonSoundOnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSoundOnOff.BackgroundImage")));
            this.buttonSoundOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoundOnOff.FlatAppearance.BorderSize = 0;
            this.buttonSoundOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoundOnOff.Location = new System.Drawing.Point(223, 19);
            this.buttonSoundOnOff.Name = "buttonSoundOnOff";
            this.buttonSoundOnOff.Size = new System.Drawing.Size(25, 25);
            this.buttonSoundOnOff.TabIndex = 3;
            this.buttonSoundOnOff.UseVisualStyleBackColor = true;
            // 
            // buttonLanguageSwitch
            // 
            this.buttonLanguageSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.buttonLanguageSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLanguageSwitch.BackgroundImage")));
            this.buttonLanguageSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLanguageSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLanguageSwitch.FlatAppearance.BorderSize = 0;
            this.buttonLanguageSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguageSwitch.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLanguageSwitch.Location = new System.Drawing.Point(254, 19);
            this.buttonLanguageSwitch.Name = "buttonLanguageSwitch";
            this.buttonLanguageSwitch.Size = new System.Drawing.Size(25, 25);
            this.buttonLanguageSwitch.TabIndex = 2;
            this.buttonLanguageSwitch.Text = "\r\n";
            this.buttonLanguageSwitch.UseVisualStyleBackColor = false;
            // 
            // panelMakiseRoundPicture
            // 
            this.panelMakiseRoundPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMakiseRoundPicture.BackgroundImage")));
            this.panelMakiseRoundPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMakiseRoundPicture.Location = new System.Drawing.Point(19, 7);
            this.panelMakiseRoundPicture.Name = "panelMakiseRoundPicture";
            this.panelMakiseRoundPicture.Size = new System.Drawing.Size(48, 45);
            this.panelMakiseRoundPicture.TabIndex = 1;
            // 
            // labelMakiseName
            // 
            this.labelMakiseName.AutoSize = true;
            this.labelMakiseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMakiseName.ForeColor = System.Drawing.Color.Silver;
            this.labelMakiseName.Image = ((System.Drawing.Image)(resources.GetObject("labelMakiseName.Image")));
            this.labelMakiseName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMakiseName.Location = new System.Drawing.Point(73, 23);
            this.labelMakiseName.Name = "labelMakiseName";
            this.labelMakiseName.Size = new System.Drawing.Size(115, 18);
            this.labelMakiseName.TabIndex = 0;
            this.labelMakiseName.Text = "Makise Kurisu";
            // 
            // panelTasksHolder
            // 
            this.panelTasksHolder.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelTasksHolder.Controls.Add(this.chatbox2);
            this.panelTasksHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasksHolder.Location = new System.Drawing.Point(0, 0);
            this.panelTasksHolder.Name = "panelTasksHolder";
            this.panelTasksHolder.Size = new System.Drawing.Size(1017, 692);
            this.panelTasksHolder.TabIndex = 8;
            // 
            // chatbox2
            // 
            this.chatbox2.BackColor = System.Drawing.Color.White;
            this.chatbox2.Location = new System.Drawing.Point(1205, 36);
            this.chatbox2.Margin = new System.Windows.Forms.Padding(8);
            this.chatbox2.Name = "chatbox2";
            this.chatbox2.Size = new System.Drawing.Size(413, 785);
            this.chatbox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1231, 724);
            this.Controls.Add(this.hiddenTabsControl1);
            this.Controls.Add(this.panelTabHolder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTabHolder.ResumeLayout(false);
            this.panelTabHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.hiddenTabsControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.makisePicture)).EndInit();
            this.panelMessageHolder.ResumeLayout(false);
            this.panelMessageTitleHolder.ResumeLayout(false);
            this.panelMessageTitleHolder.PerformLayout();
            this.panelTasksHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabHolder;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonRandomFun;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private HiddenTabsControl hiddenTabsControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox makisePicture;
        private System.Windows.Forms.Panel panelMessageHolder;
        private chatbox chatbox1;
        private System.Windows.Forms.Panel panelMessageTitleHolder;
        private System.Windows.Forms.Button buttonSoundOnOff;
        private System.Windows.Forms.Button buttonLanguageSwitch;
        private System.Windows.Forms.Panel panelMakiseRoundPicture;
        private System.Windows.Forms.Label labelMakiseName;
        private System.Windows.Forms.Panel panelTasksHolder;
        private chatbox chatbox2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

