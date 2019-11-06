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
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSettings.Height;
            panelLeft.Top = buttonSettings.Top;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalendar.Height;
            panelLeft.Top = buttonCalendar.Top;
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonLearn.Height;
            panelLeft.Top = buttonLearn.Top;
        }

        private void buttonRandomFun_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonRandomFun.Height;
            panelLeft.Top = buttonRandomFun.Top;
        }
    }
}
