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
    public partial class Chatbox : UserControl
    {
        // constants
        private const int OFFSET = 12;

        // the previous bubble to keep track of its position
        private BubbleMessage bblPrev;

        public Chatbox()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }

            bblPrev = new BubbleMessage();
        }

        public void addInMessage(string message, string time)
        {
            BubbleMessage bbl = new JAssistant.BubbleMessage(message, time, MsgType.In);
            bbl.Location = bubbleMessage1.Location;
            bbl.Size = bubbleMessage1.Size;
            bbl.Anchor = bubbleMessage1.Anchor;
            bbl.Top = bblPrev.Bottom + OFFSET;

            panelChatHolder.Controls.Add(bbl);
            panelChatHolder.VerticalScroll.Value = panelChatHolder.VerticalScroll.Maximum;

            bblPrev = bbl;
        }

        public void addOutMessage(string message, string time)
        {
            BubbleMessage bbl = new JAssistant.BubbleMessage(message, time, MsgType.Out);
            bbl.Location = bubbleMessage2.Location;
            bbl.Size = bubbleMessage2.Size;
            bbl.Anchor = bubbleMessage2.Anchor;
            bbl.Top = bblPrev.Bottom + OFFSET;

            panelChatHolder.Controls.Add(bbl);
            panelChatHolder.VerticalScroll.Value = panelChatHolder.VerticalScroll.Maximum;

            bblPrev = bbl;
        }

        private void bunifuButtonSendText_Click(object sender, EventArgs e)
        {
            // TODO: Send message from bunifuTextBox and then sends request to server for contacting DialogFlow and Deepfake
            addInMessage("Hello stub text", "00:00");
            addOutMessage("Hello stub text to you too", "00:00");

            panelChatHolder.VerticalScroll.Value = panelChatHolder.VerticalScroll.Maximum;
        }
    }
}
