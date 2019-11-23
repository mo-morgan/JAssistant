using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAssistant
{
    public partial class BubbleMessage : UserControl
    {
        // C
        private const int OFFSET = 10;

        public BubbleMessage()
        {
            InitializeComponent();
        }
        
        public BubbleMessage(string message, string time, MsgType messageType)
        {
            InitializeComponent();
            this.labelMessage.Text = message;
            this.labelTime.Text = time;

            if (messageType.ToString() == "In")
            {
                // incoming message
                this.BackColor = Color.FromKnownColor(KnownColor.White);
                this.labelMessage.ForeColor = Color.FromKnownColor(KnownColor.Black);
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
            labelTime.Top = labelMessage.Bottom + OFFSET;
            
            this.Height = labelTime.Bottom + OFFSET;
        }

        private void bubbleMyMessage_Resize(object sender, EventArgs e)
        {
            SetBubbleHeight();
        }
    }

    public enum MsgType
    {
        In,
        Out
    }
}
