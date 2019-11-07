﻿using System;
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

            UpdateTabHighlight(TAB_HOME);

            // Setting the minimum size of the window
            this.MinimumSize = new System.Drawing.Size(900, 560);

            // Initial panel
            panelHome.Visible = true;
            panelCalendar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTabHighlight(TAB_HOME);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelCalendar.Visible = false;

            UpdateTabHighlight(TAB_HOME);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            UpdateTabHighlight(TAB_SETTINGS);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelCalendar.Visible = true;

            UpdateTabHighlight(TAB_CALENDAR);
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            UpdateTabHighlight(TAB_LEARN);
        }

        private void buttonRandomFun_Click(object sender, EventArgs e)
        {
            UpdateTabHighlight(TAB_RANDOM_FUN);
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
        private void UpdateTabHighlight(int currentTab)
        {
            switch (currentTab)
            {
                case TAB_HOME:
                    tabHighlight.Height = buttonHome.Height;
                    tabHighlight.Top = buttonHome.Top;
                    break;
                case TAB_CALENDAR:
                    tabHighlight.Height = buttonCalendar.Height;
                    tabHighlight.Top = buttonCalendar.Top;
                    break;
                case TAB_LEARN:
                    tabHighlight.Height = buttonLearn.Height;
                    tabHighlight.Top = buttonLearn.Top;
                    break;
                case TAB_RANDOM_FUN:
                    tabHighlight.Height = buttonRandomFun.Height;
                    tabHighlight.Top = buttonRandomFun.Top;
                    break;
                case TAB_SETTINGS:
                    tabHighlight.Height = buttonSettings.Height;
                    tabHighlight.Top = buttonSettings.Top;
                    break;
                default:
                    logger.ErrorMessage("No such tab number: " + currentTab);
                    break;
            }

            tabHighlight.BringToFront();
        }
    }
}
