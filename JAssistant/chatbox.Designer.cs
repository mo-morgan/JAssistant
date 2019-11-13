namespace JAssistant
{
    partial class chatbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatbox));
            this.panelSendTextHolder = new System.Windows.Forms.Panel();
            this.bunifuButtonSendText = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelChatHolder = new System.Windows.Forms.Panel();
            this.panelSendTextHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuButtonSendText)).BeginInit();
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
            this.panelSendTextHolder.Size = new System.Drawing.Size(248, 56);
            this.panelSendTextHolder.TabIndex = 0;
            // 
            // bunifuButtonSendText
            // 
            this.bunifuButtonSendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButtonSendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.bunifuButtonSendText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonSendText.Image = ((System.Drawing.Image)(resources.GetObject("bunifuButtonSendText.Image")));
            this.bunifuButtonSendText.ImageActive = null;
            this.bunifuButtonSendText.Location = new System.Drawing.Point(215, 16);
            this.bunifuButtonSendText.Name = "bunifuButtonSendText";
            this.bunifuButtonSendText.Size = new System.Drawing.Size(30, 30);
            this.bunifuButtonSendText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuButtonSendText.TabIndex = 1;
            this.bunifuButtonSendText.TabStop = false;
            this.bunifuButtonSendText.Zoom = 10;
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
            this.bunifuTextBox.Size = new System.Drawing.Size(195, 30);
            this.bunifuTextBox.TabIndex = 0;
            this.bunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelChatHolder
            // 
            this.panelChatHolder.AutoScroll = true;
            this.panelChatHolder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelChatHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatHolder.Location = new System.Drawing.Point(0, 0);
            this.panelChatHolder.Name = "panelChatHolder";
            this.panelChatHolder.Size = new System.Drawing.Size(248, 430);
            this.panelChatHolder.TabIndex = 1;
            // 
            // chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelChatHolder);
            this.Controls.Add(this.panelSendTextHolder);
            this.Name = "chatbox";
            this.Size = new System.Drawing.Size(248, 486);
            this.panelSendTextHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuButtonSendText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSendTextHolder;
        private System.Windows.Forms.Panel panelChatHolder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTextBox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuButtonSendText;
    }
}
