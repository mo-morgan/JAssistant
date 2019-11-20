using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAssistant.Client
{
    public partial class bubbleMyMessage : UserControl
    {
        public enum msgtype
        {
            In,
            Out
        }

        public bubbleMyMessage()
        {
            InitializeComponent();
        }
        
        public bubbleMyMessage(string message, string time, msgtype messageType)
        {
            InitializeComponent();
            this.labelMessage.Text = message;

            if (messageType.ToString() == "In")
            {
                // incoming message
                this.BackColor = Color.FromArgb(255, 255, 255);
                this.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                // outgoing message
            }

            SetBubbleHeight();
        }


        void SetBubbleHeight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(labelMessage.Text, labelMessage.Font, labelMessage.Width);

            labelMessage.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());

            // adding a constant for extra padding
            labelTime.Top = labelMessage.Bottom + 10;
            
            this.Height = labelTime.Bottom + labelMessage.Top + 4;
        }

        private void bubbleMyMessage_Resize(object sender, EventArgs e)
        {
            SetBubbleHeight();
        }
    }
}
