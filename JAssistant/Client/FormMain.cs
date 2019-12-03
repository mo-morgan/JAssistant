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

        // UI
        private bool isJapanese = true;
        private bool isSoundOn = true;

        public Form1()
        {
            InitializeComponent();          

            // Initialize logger
            logger = new Logger();

            // Setting the minimum size of the window
            this.MinimumSize = new System.Drawing.Size(1250, 560);

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
                if (isJapanese)
                {
                    buttonLanguageSwitch.BackgroundImage = Properties.Resources.english_50px;
                    isJapanese = false;
                }
                else
                {
                    buttonLanguageSwitch.BackgroundImage = Properties.Resources.japanese_50px;
                    isJapanese = true;
                }
            }
        }

        // connect to English dub voice for Kurisu
        //  returns false if 
        private bool SwitchLanguage()
        {
            try
            {

            }
            catch
            {

            }
            return true;
        }

        private void buttonSoundOnOff_Click(object sender, EventArgs e)
        {
            if (!SwitchSoundOnOff())
            {
                logger.ErrorMessage("Cannot switch Sound On Off");
            }
            else
            {
                if (isSoundOn)
                {
                    buttonSoundOnOff.BackgroundImage = Properties.Resources.sound_off_50px;
                    isSoundOn = false;
                }
                else
                {
                    buttonSoundOnOff.BackgroundImage = Properties.Resources.sound_on_50px;
                    isSoundOn = true;
                }
            }
        }

        private bool SwitchSoundOnOff()
        {
            try
            {

            }
            catch
            {

            }
            return true;
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
                    {
                        hiddenTabsControl.SelectedIndex = TAB_HOME;
                        break;
                    }        
                case TAB_CALENDAR:
                    {
                        hiddenTabsControl.SelectedIndex = TAB_CALENDAR;
                        break;
                    }
                case TAB_LEARN:
                    {
                        hiddenTabsControl.SelectedIndex = TAB_LEARN;
                        break;
                    }
                case TAB_RANDOM_FUN:
                    {
                        hiddenTabsControl.SelectedIndex = TAB_RANDOM_FUN;
                        break;
                    }
                case TAB_SETTINGS:
                    {
                        hiddenTabsControl.SelectedIndex = TAB_SETTINGS;
                        break;
                    }
                default:
                    {
                        logger.ErrorMessage("No such tab number: " + currentTab);
                        break;
                    }
            }
        }

        private void UpdateTabHighlight(int currentTab)
        {
            switch (currentTab)
            {
                case TAB_HOME:
                    {
                        pnlStats.Height = buttonHome.Height;
                        pnlStats.Top = buttonHome.Top;
                        break;
                    }
                case TAB_CALENDAR:
                    {
                        pnlStats.Height = buttonCalendar.Height;
                        pnlStats.Top = buttonCalendar.Top;
                        break;
                    }
                case TAB_LEARN:
                    {
                        pnlStats.Height = buttonLearn.Height;
                        pnlStats.Top = buttonLearn.Top;
                        break;
                    }
                case TAB_RANDOM_FUN:
                    {
                        pnlStats.Height = buttonRandomFun.Height;
                        pnlStats.Top = buttonRandomFun.Top;
                        break;
                    }
                case TAB_SETTINGS:
                    {
                        pnlStats.Height = buttonSettings.Height;
                        pnlStats.Top = buttonSettings.Top;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            pnlStats.BringToFront();
        }
    }
}
