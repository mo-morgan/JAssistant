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
    public partial class chatbox : UserControl
    {
        public chatbox()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        private void bunifuTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
