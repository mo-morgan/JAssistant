using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace JAssistant
{
    public partial class Form1 : Form
    {
        // CONSTANTS
        private const int TAB_HOME = 0;
        private const int TAB_CALENDAR = 1;
        private const int TAB_LEARN = 2;
        private const int TAB_RANDOM_FUN = 3;
        private const int TAB_SETTINGS = 4;

        // Logging
        private Logger logger;

        public Form1()
        {
            InitializeComponent();

            // Initialize logger
            logger = new Logger();

            // Setting the minimum size of the window
            this.MinimumSize = new System.Drawing.Size(1247, 560);

            SwitchPanel(TAB_HOME);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchPanel(TAB_HOME);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            SwitchPanel(TAB_HOME);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            SwitchPanel(TAB_CALENDAR);
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            SwitchPanel(TAB_LEARN);
        }

        private void buttonRandomFun_Click(object sender, EventArgs e)
        {
            SwitchPanel(TAB_RANDOM_FUN);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            SwitchPanel(TAB_SETTINGS);
        }

        private void buttonLanguageSwitch_Click(object sender, EventArgs e)
        {
            if (!SwitchLanguage())
            {
                logger.ErrorMessage("Cannot switch language");
            }
            else
            {

            }
        }

        private bool SwitchLanguage()
        {
            return false;
        }

        //----------------- HELPER FUNCTIONS ------------------
        private void SwitchPanel(int currentTab)
        {
            UpdatePanelContent(currentTab);
            UpdateTabHighlight(currentTab);
        }

        private void UpdatePanelContent(int currentTab)
        {
            switch (currentTab)
            {
                case TAB_HOME:
                    panelHome.Visible = true;
                    //panelCalendar.Visible = false;
                    break;
                case TAB_CALENDAR:
                    break;
                case TAB_LEARN:
                    break;
                case TAB_RANDOM_FUN:
                    break;
                case TAB_SETTINGS:
                    break;
                default:
                    logger.ErrorMessage("No such tab number: " + currentTab);
                    break;
            }
        }

        private void UpdateTabHighlight(int currentTab)
        {
            switch (currentTab)
            {
                case TAB_HOME:
                    pnlStats.Height = buttonHome.Height;
                    pnlStats.Top = buttonHome.Top;
                    break;
                case TAB_CALENDAR:
                    pnlStats.Height = buttonCalendar.Height;
                    pnlStats.Top = buttonCalendar.Top;
                    break;
                case TAB_LEARN:
                    pnlStats.Height = buttonLearn.Height;
                    pnlStats.Top = buttonLearn.Top;
                    break;
                case TAB_RANDOM_FUN:
                    pnlStats.Height = buttonRandomFun.Height;
                    pnlStats.Top = buttonRandomFun.Top;
                    break;
                case TAB_SETTINGS:
                    pnlStats.Height = buttonSettings.Height;
                    pnlStats.Top = buttonSettings.Top;
                    break;
                default:
                    logger.ErrorMessage("No such tab number: " + currentTab);
                    break;
            }

            pnlStats.BringToFront();
        }
    }
}
