using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Heater
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void waterLevelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if(waterLevelTextBox.Text.Count() == 0)
                    onButton.Enabled = false;

                return;
            }
            if (e.KeyCode == Keys.Enter) 
                return;

            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.OemPeriod)
            {
                MessageBox.Show("Input must be a numeric value!");
                waterLevelTextBox.Text = "";
                onButton.Enabled = false;
                return;
            }

            onButton.Enabled = true;
        }
    }
}
