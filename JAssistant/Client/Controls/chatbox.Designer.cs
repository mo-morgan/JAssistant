namespace JAssistant
{
    partial class Chatbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatbox));
            this.panelSendTextHolder = new System.Windows.Forms.Panel();
            this.bunifuButtonSendText = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelChatHolder = new System.Windows.Forms.Panel();
            this.labelSayHi = new System.Windows.Forms.Label();
            this.panelMakiseStartingPicture = new System.Windows.Forms.Panel();
            this.bubbleMessage2 = new JAssistant.BubbleMessage();
            this.bubbleMessage1 = new JAssistant.BubbleMessage();
            this.panelSendTextHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuButtonSendText)).BeginInit();
            this.panelChatHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSendTextHolder
            // 
            this.panelSendTextHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panelSendTextHolder.Controls.Add(this.bunifuButtonSendText);
            this.panelSendTextHolder.Controls.Add(this.bunifuTextBox);
            this.panelSendTextHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSendTextHolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSendTextHolder.Location = new System.Drawing.Point(0, 430);
            this.panelSendTextHolder.Name = "panelSendTextHolder";
            this.panelSendTextHolder.Size = new System.Drawing.Size(606, 56);
            this.panelSendTextHolder.TabIndex = 0;
            // 
            // bunifuButtonSendText
            // 
            this.bunifuButtonSendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButtonSendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.bunifuButtonSendText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonSendText.Image = ((System.Drawing.Image)(resources.GetObject("bunifuButtonSendText.Image")));
            this.bunifuButtonSendText.ImageActive = null;
            this.bunifuButtonSendText.Location = new System.Drawing.Point(573, 16);
            this.bunifuButtonSendText.Name = "bunifuButtonSendText";
            this.bunifuButtonSendText.Size = new System.Drawing.Size(30, 30);
            this.bunifuButtonSendText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuButtonSendText.TabIndex = 1;
            this.bunifuButtonSendText.TabStop = false;
            this.bunifuButtonSendText.Zoom = 10;
            this.bunifuButtonSendText.Click += new System.EventHandler(this.bunifuButtonSendText_Click);
            // 
            // bunifuTextBox
            // 
            this.bunifuTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.bunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox.HintForeColor = System.Drawing.Color.White;
            this.bunifuTextBox.HintText = "Start typing here ...";
            this.bunifuTextBox.isPassword = false;
            this.bunifuTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuTextBox.LineIdleColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuTextBox.LineThickness = 5;
            this.bunifuTextBox.Location = new System.Drawing.Point(13, 16);
            this.bunifuTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTextBox.Name = "bunifuTextBox";
            this.bunifuTextBox.Size = new System.Drawing.Size(553, 30);
            this.bunifuTextBox.TabIndex = 0;
            this.bunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelChatHolder
            // 
            this.panelChatHolder.AutoScroll = true;
            this.panelChatHolder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelChatHolder.Controls.Add(this.labelSayHi);
            this.panelChatHolder.Controls.Add(this.panelMakiseStartingPicture);
            this.panelChatHolder.Controls.Add(this.bubbleMessage2);
            this.panelChatHolder.Controls.Add(this.bubbleMessage1);
            this.panelChatHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatHolder.Location = new System.Drawing.Point(0, 0);
            this.panelChatHolder.Name = "panelChatHolder";
            this.panelChatHolder.Size = new System.Drawing.Size(606, 430);
            this.panelChatHolder.TabIndex = 1;
            // 
            // labelSayHi
            // 
            this.labelSayHi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSayHi.AutoSize = true;
            this.labelSayHi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSayHi.Location = new System.Drawing.Point(162, 88);
            this.labelSayHi.Name = "labelSayHi";
            this.labelSayHi.Size = new System.Drawing.Size(283, 20);
            this.labelSayHi.TabIndex = 3;
            this.labelSayHi.Text = "Say hi to your new virtual assistant, Kurisu!";
            // 
            // panelMakiseStartingPicture
            // 
            this.panelMakiseStartingPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMakiseStartingPicture.BackgroundImage")));
            this.panelMakiseStartingPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMakiseStartingPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMakiseStartingPicture.Location = new System.Drawing.Point(0, 0);
            this.panelMakiseStartingPicture.Name = "panelMakiseStartingPicture";
            this.panelMakiseStartingPicture.Size = new System.Drawing.Size(606, 85);
            this.panelMakiseStartingPicture.TabIndex = 2;
            // 
            // bubbleMessage2
            // 
            this.bubbleMessage2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubbleMessage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.bubbleMessage2.Location = new System.Drawing.Point(88, 253);
            this.bubbleMessage2.Name = "bubbleMessage2";
            this.bubbleMessage2.Size = new System.Drawing.Size(505, 83);
            this.bubbleMessage2.TabIndex = 1;
            this.bubbleMessage2.Visible = false;
            // 
            // bubbleMessage1
            // 
            this.bubbleMessage1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubbleMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.bubbleMessage1.Location = new System.Drawing.Point(13, 164);
            this.bubbleMessage1.Name = "bubbleMessage1";
            this.bubbleMessage1.Size = new System.Drawing.Size(495, 83);
            this.bubbleMessage1.TabIndex = 0;
            this.bubbleMessage1.Visible = false;
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelChatHolder);
            this.Controls.Add(this.panelSendTextHolder);
            this.Name = "Chatbox";
            this.Size = new System.Drawing.Size(606, 486);
            this.panelSendTextHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuButtonSendText)).EndInit();
            this.panelChatHolder.ResumeLayout(false);
            this.panelChatHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSendTextHolder;
        private System.Windows.Forms.Panel panelChatHolder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTextBox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuButtonSendText;
        private BubbleMessage bubbleMessage2;
        private BubbleMessage bubbleMessage1;
        private System.Windows.Forms.Label labelSayHi;
        private System.Windows.Forms.Panel panelMakiseStartingPicture;
    }
}
