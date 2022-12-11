using DotFuzzy;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Water_Heater.Helpers;

namespace Water_Heater
{
    public partial class mainForm : Form
    {
        FuzzyEngine fuzzyEngine;
        FuzzyRuleCollection fuzzyRuleCollection;
        MembershipFunctionCollection levelSense, temperatureSense, heatKnob;
        LinguisticVariable levelLV, temperatureLV, heatKnobLV;

        double water;
        double temperature = 0.0f;
        double heat = 0.0f;

        bool canExit = false;

        public mainForm()
        {
            InitializeComponent();
            InitializeFuzzyLogicMembers();
            InitializeFuzzyLogicRules();
            InitializeFuzzyLogicEngine();
            InitializeCharts();
        }

        public void InitializeFuzzyLogicMembers()
        {
            // Sets level sense
            levelSense = new MembershipFunctionCollection();
            levelSense.Add(new MembershipFunction("X_SMALL", -1.0, 1.0, 1.0, 2.0));
            levelSense.Add(new MembershipFunction("SMALL", 1.5, 2.5, 2.5, 4.0));
            levelSense.Add(new MembershipFunction("MEDIUM", 3.0, 5.0, 5.0, 7.0));
            levelSense.Add(new MembershipFunction("LARGE", 6.0, 7.5, 7.5, 8.5));
            levelSense.Add(new MembershipFunction("X_LARGE", 7.5, 9.0, 9.0, 11.0));
            levelLV = new LinguisticVariable("WATER_LEVEL", levelSense);

            // Sets temperature sense
            temperatureSense = new MembershipFunctionCollection();
            temperatureSense.Add(new MembershipFunction("X_SMALL", -1.0, 10.0, 10.0, 20.0));
            temperatureSense.Add(new MembershipFunction("SMALL", 10.0, 25.0, 25.0, 35.0));
            temperatureSense.Add(new MembershipFunction("MEDIUM", 30.0, 50.0, 50.0, 75.0));
            temperatureSense.Add(new MembershipFunction("LARGE", 60.0, 80.0, 80.0, 95.0));
            temperatureSense.Add(new MembershipFunction("X_LARGE", 85.0, 105.0, 105.0, 126.0));
            temperatureLV = new LinguisticVariable("TEMPERATURE_LEVEL", temperatureSense);

            // Sets heat knob
            heatKnob = new MembershipFunctionCollection();
            heatKnob.Add(new MembershipFunction("VERY_LITTLE", -1.0, 1.0, 1.0, 2.0));
            heatKnob.Add(new MembershipFunction("A_LITTLE", 1.5, 2.5, 2.5, 4.0));
            heatKnob.Add(new MembershipFunction("A_GOOD_AMOUNT", 3.0, 5.0, 5.0, 7.0));
            heatKnob.Add(new MembershipFunction("A_LOT", 6.0, 7.5, 7.5, 8.5));
            heatKnob.Add(new MembershipFunction("A_WHOLE_LOT", 7.5, 9.0, 9.0, 11.0));
            heatKnobLV = new LinguisticVariable("HEAT_KNOB", heatKnob);
        }

        public void InitializeFuzzyLogicRules()
        {
            fuzzyRuleCollection = new FuzzyRuleCollection();

            // Rule for x small
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_SMALL) AND (TEMPERATURE_LEVEL IS X_SMALL) THEN HEAT_KNOB IS A_GOOD_AMOUNT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_SMALL) AND (TEMPERATURE_LEVEL IS SMALL) THEN HEAT_KNOB IS A_LITTLE"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_SMALL) AND (TEMPERATURE_LEVEL IS MEDIUM) THEN HEAT_KNOB IS VERY_LITTLE"));

            // Rule for small
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS SMALL) AND (TEMPERATURE_LEVEL IS X_SMALL) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS SMALL) AND (TEMPERATURE_LEVEL IS SMALL) THEN HEAT_KNOB IS A_GOOD_AMOUNT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS SMALL) AND (TEMPERATURE_LEVEL IS MEDIUM) THEN HEAT_KNOB IS VERY_LITTLE"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS SMALL) AND (TEMPERATURE_LEVEL IS LARGE) THEN HEAT_KNOB IS VERY_LITTLE"));

            // Rule for medium
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS MEDIUM) AND (TEMPERATURE_LEVEL IS X_SMALL) THEN HEAT_KNOB IS A_WHOLE_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS MEDIUM) AND (TEMPERATURE_LEVEL IS SMALL) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS MEDIUM) AND (TEMPERATURE_LEVEL IS MEDIUM) THEN HEAT_KNOB IS A_GOOD_AMOUNT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS MEDIUM) AND (TEMPERATURE_LEVEL IS LARGE) THEN HEAT_KNOB IS VERY_LITTLE"));

            // Rule for large
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS LARGE) AND (TEMPERATURE_LEVEL IS X_SMALL) THEN HEAT_KNOB IS A_WHOLE_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS LARGE) AND (TEMPERATURE_LEVEL IS SMALL) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS LARGE) AND (TEMPERATURE_LEVEL IS MEDIUM) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS LARGE) AND (TEMPERATURE_LEVEL IS LARGE) THEN HEAT_KNOB IS A_LITTLE"));

            // Rule for x large
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_LARGE) AND (TEMPERATURE_LEVEL IS X_SMALL) THEN HEAT_KNOB IS A_WHOLE_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_LARGE) AND (TEMPERATURE_LEVEL IS SMALL) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_LARGE) AND (TEMPERATURE_LEVEL IS MEDIUM) THEN HEAT_KNOB IS A_LOT"));
            fuzzyRuleCollection.Add(new FuzzyRule("IF (WATER_LEVEL IS X_LARGE) AND (TEMPERATURE_LEVEL IS LARGE) THEN HEAT_KNOB IS A_GOOD_AMOUNT"));
        }

        private void InitializeFuzzyLogicEngine()
        {
            // Sets properties for fuzzy engine
            fuzzyEngine = new FuzzyEngine();
            fuzzyEngine.LinguisticVariableCollection.Add(levelLV);
            fuzzyEngine.LinguisticVariableCollection.Add(temperatureLV);
            fuzzyEngine.LinguisticVariableCollection.Add(heatKnobLV);
            fuzzyEngine.FuzzyRuleCollection = fuzzyRuleCollection;
        }

        public void InitializeCharts()
        {
            // Sets properties for temperature chart
            temperatureChart.Series[0].Name = "Temperature";
            temperatureChart.Series[0].Color = Color.Orange;
            temperatureChart.Series[0].ChartType = SeriesChartType.Line;
            temperatureChart.Series[0].Points.AddY(temperature);
            temperatureChart.ChartAreas[0].AxisY.Minimum = 0;
            temperatureChart.ChartAreas[0].AxisY.Maximum = 125;

            // Sets properties for heat chart
            heatChart.Series[0].Name = "Heat";
            heatChart.Series[0].Color = Color.Red;
            heatChart.Series[0].ChartType = SeriesChartType.Line;
            heatChart.Series[0].Points.AddY(heat);
            heatChart.ChartAreas[0].AxisY.Minimum = 0;
            heatChart.ChartAreas[0].AxisY.Maximum = 10;
        }

        private void waterLevelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Checks if user presses backspace
            if (e.KeyCode == Keys.Back)
            {
                // Checks if text box is empty, then disable on button
                if(waterLevelTextBox.Text.Count() == 0)
                    onButton.Enabled = false;

                return;
            }

            // Checks if user presses enter
            if (e.KeyCode == Keys.Enter)
                return;

            // Checks if user presses outside 1-9 and .
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyCode != Keys.OemPeriod)
            {
                MessageBox.Show("Input must be a numeric value!");
                waterLevelTextBox.Text = "";
                onButton.Enabled = false;
                return;
            }

            onButton.Enabled = true;
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            waterLevelTextBox.Enabled = false;
            onButton.Enabled = false;
            offButton.Enabled = true;

            try
            {
                new Thread(() =>
                {
                    while (!canExit)
                    {
                        // If turned on, then fuzzify
                        if (!onButton.Enabled) fuzzifyValues();

                        defuzzifyWater();
                        defuzzifyTemperature();
                        defuzzifyHeatKnob();

                        // Draws and updates chart
                        updateChart();

                        // Pauses for 1/2 second
                        Thread.Sleep(500);
                    }
                }).Start();
            }
            finally
            {
                canExit = false;
            }
        }

        public void fuzzifyValues()
        {
            // Fuzzify level
            water = double.Parse(waterLevelTextBox.Text);
            levelLV.InputValue = water;
            levelLV.Fuzzify("X_SMALL");

            // Fuzzify temperatue
            temperatureLV.InputValue = temperature;
            temperatureLV.Fuzzify("X_SMALL");

            // Fuzzify heat knob
            heatKnobLV.InputValue = heat;
            heatKnobLV.Fuzzify("VERY_LITTLE");
        }

        public void defuzzifyWater()
        {
            // Updates Data
            levelDataLabel.Invoke((MethodInvoker)(() =>
            {
                levelDataLabel.Text = "Level : \n" + water.ToString("f2");
            }));

            // Updates Rule
            levelRuleLabel.Invoke((MethodInvoker)(() =>
            {
                levelRuleLabel.Text = "Level : \n" + LevelHelper.GetRule(water);
            }));
        }

        public void defuzzifyTemperature()
        {
            // If turned on, then use heat
            if(!onButton.Enabled)
            {
                if (temperature < 80) temperature += heat;
                else temperature -= heat;
            }

            // If turned off, then gradually decrease temperature
            if(!offButton.Enabled)
            {
                temperature --;
                if (temperature < 0) temperature = 0;
            }

            // Updates Data
            temperatureDataLabel.Invoke((MethodInvoker)(() =>
            {
                temperatureDataLabel.Text = "Temperature : \n" + temperature.ToString("f2") + " °C";
            }));

            // Updates Rule
            temperatureRuleLabel.Invoke((MethodInvoker)(() =>
            {
                temperatureRuleLabel.Text = "Temperature : \n" + TemperatureHelper.GetRule(temperature);
            }));
        }

        public void defuzzifyHeatKnob()
        {
            // If turned on, then use fuzzy engine
            if(!onButton.Enabled)
            {
                fuzzyEngine.Consequent = "HEAT_KNOB";
                heat = fuzzyEngine.Defuzzify();
            }

            // If turned off, then gradually decrease temperature
            if(!offButton.Enabled)
            {
                heat--;
                if(heat < 0) heat = 0;
            }

            // Updates Data
            heatKnobDataLabel.Invoke((MethodInvoker)(() =>
            {
                heatKnobDataLabel.Text = "Heat Knob : \n" + heat.ToString("f2") + " kW";
            }));

            // Updates Rule
            heatKnobRuleLabel.Invoke((MethodInvoker)(() =>
            {
                heatKnobRuleLabel.Text = "Heat Knob : \n" + HeatKnobHelper.GetRule(heat);
            }));
        }

        public void updateChart()
        {
            // Updates chart for temperature
            temperatureChart.Invoke((MethodInvoker)(() =>
            {
                if (temperatureChart.Series[0].Points.Count > 25) temperatureChart.Series[0].Points.RemoveAt(0);

                temperatureChart.Series[0].Points.AddY(temperature);
                temperatureChart.ChartAreas[0].AxisX.Minimum = temperatureChart.Series[0].Points[0].XValue;
                temperatureChart.ChartAreas[0].AxisX.Maximum = 25;
            }));

            // Updates chart for heat
            heatChart.Invoke((MethodInvoker)(() =>
            {
                if (heatChart.Series[0].Points.Count > 25) heatChart.Series[0].Points.RemoveAt(0);

                heatChart.Series[0].Points.AddY(heat);
                heatChart.ChartAreas[0].AxisX.Minimum = temperatureChart.Series[0].Points[0].XValue;
                heatChart.ChartAreas[0].AxisX.Maximum = 25;
            }));
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            onButton.Enabled = true;
            offButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            canExit = true;

            onButton.Enabled = true;
            offButton.Enabled = false;
            waterLevelTextBox.Enabled = true;
            waterLevelTextBox.Text = "";

            // Resets value to zero
            temperature = 0;
            heat = 0;
            temperatureChart.Series[0].Points.Clear();
            heatChart.Series[0].Points.Clear();
            InitializeCharts();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            canExit = true;
            waterLevelTextBox.Text = "";
        }
    }
}
