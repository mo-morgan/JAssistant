using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabHighlight.Height = buttonHome.Height;
            tabHighlight.Top = buttonHome.Top;

            // Setting the minimum size of the window
            this.MinimumSize = new System.Drawing.Size(900, 560);

            // Initial panel
            panelHome.Visible = true;
            panelCalendar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabHighlight.BringToFront();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            tabHighlight.Height = buttonSettings.Height;
            tabHighlight.Top = buttonSettings.Top;

            tabHighlight.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            tabHighlight.Height = buttonHome.Height;
            tabHighlight.Top = buttonHome.Top;

            panelHome.Visible = true;
            panelCalendar.Visible = false;

            tabHighlight.BringToFront();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            tabHighlight.Height = buttonCalendar.Height;
            tabHighlight.Top = buttonCalendar.Top;

            panelHome.Visible = false;
            panelCalendar.Visible = true;

            tabHighlight.BringToFront();
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            tabHighlight.Height = buttonLearn.Height;
            tabHighlight.Top = buttonLearn.Top;

            tabHighlight.BringToFront();
        }

        private void buttonRandomFun_Click(object sender, EventArgs e)
        {
            tabHighlight.Height = buttonRandomFun.Height;
            tabHighlight.Top = buttonRandomFun.Top;

            tabHighlight.BringToFront();
        }
    }
}
