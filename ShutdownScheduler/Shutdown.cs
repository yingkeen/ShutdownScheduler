using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ShutdownScheduler.Models;

namespace ShutdownScheduler
{
    public partial class Shutdown : Form
    {
        private Dictionary<RadioButton, string> rbValues =
            new Dictionary<RadioButton, string>();

        public Shutdown()
        {
            InitializeComponent();
            rbValues[rbShutdown] = "/s";
            rbValues[rbRestart] = "/r";
            rbValues[rbLogOff] = "/l";

            //Initialize checkbox list value with different shutdown parameter
            clOptions.Items.Add(new Options { Text = "Force", Value = "/f" }, true);
            clOptions.DisplayMember = "text";
            clOptions.ValueMember = "value";
        }
        #region Event hanlders

        private void Shutdown_Load(object sender, EventArgs e)
        {
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal min = numMinutes.Value * 60;
            string options = string.Empty;
            string shutdownType = GetSelectedValue(pnlShutdownType);

            for (int i = 0; i < clOptions.Items.Count; i++)
            {
                if (clOptions.GetItemChecked(i))
                {
                    string optionsParam = (clOptions.CheckedItems[i] as Options).Value;
                    options += string.IsNullOrEmpty(options) ? optionsParam : " " + optionsParam;
                }
            }

            Process.Start("shutdown", shutdownType + " " + options + " /t " + min);
            //MessageBox.Show(shutdownType + " " + options + " /t " + min);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
            //MessageBox.Show("/a");
        }

        #endregion

        // Gets the selected radio button from the specified group.
        private RadioButton GetSelectedRadioButton(Panel panel)
        {
            RadioButton radioButton =
                panel
                .Controls
                .OfType<RadioButton>()
                .Where(rb => rb.Checked)
                .FirstOrDefault();
            return radioButton;
        }
        // Gets selected value from the specified group.
        private string GetSelectedValue(Panel panel)
        {
            RadioButton radioButton = GetSelectedRadioButton(panel);
            if (radioButton == null)
            {
                // Nothing selected yet.
                return string.Empty;
            }
            else
            {
                // Get the value from the dictinary.
                return rbValues[radioButton];
            }
        }
    }
}
