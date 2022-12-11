namespace Water_Heater
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.waterLevelTextBox = new System.Windows.Forms.TextBox();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.heatKnobRuleLabel = new System.Windows.Forms.Label();
            this.heatKnobDataLabel = new System.Windows.Forms.Label();
            this.temperatureRuleLabel = new System.Windows.Forms.Label();
            this.levelRuleLabel = new System.Windows.Forms.Label();
            this.temperatureDataLabel = new System.Windows.Forms.Label();
            this.levelDataLabel = new System.Windows.Forms.Label();
            this.fuzzyRuleLabel = new System.Windows.Forms.Label();
            this.fuzzyLogicLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.graphPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphToolStripMenuItem});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenu.Text = "File";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveGraphToolStripMenuItem.Text = "Save Graph";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // graphPanel
            // 
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPanel.Controls.Add(this.cartesianChart1);
            this.graphPanel.Location = new System.Drawing.Point(12, 34);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(600, 515);
            this.graphPanel.TabIndex = 1;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(4, 4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(591, 506);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // waterLevelTextBox
            // 
            this.waterLevelTextBox.Location = new System.Drawing.Point(8, 23);
            this.waterLevelTextBox.Name = "waterLevelTextBox";
            this.waterLevelTextBox.Size = new System.Drawing.Size(99, 20);
            this.waterLevelTextBox.TabIndex = 2;
            this.waterLevelTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.waterLevelTextBox_KeyUp);
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(5, 7);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(99, 13);
            this.waterLevelLabel.TabIndex = 3;
            this.waterLevelLabel.Text = "Enter Water Level :";
            // 
            // onButton
            // 
            this.onButton.Enabled = false;
            this.onButton.Location = new System.Drawing.Point(8, 49);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(75, 23);
            this.onButton.TabIndex = 4;
            this.onButton.Text = "Turn On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Enabled = false;
            this.offButton.Location = new System.Drawing.Point(8, 78);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(75, 23);
            this.offButton.TabIndex = 5;
            this.offButton.Text = "Turn Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.waterLevelTextBox);
            this.inputPanel.Controls.Add(this.resetButton);
            this.inputPanel.Controls.Add(this.offButton);
            this.inputPanel.Controls.Add(this.waterLevelLabel);
            this.inputPanel.Controls.Add(this.onButton);
            this.inputPanel.Location = new System.Drawing.Point(622, 34);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(150, 158);
            this.inputPanel.TabIndex = 6;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(8, 107);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPanel.Controls.Add(this.heatKnobRuleLabel);
            this.dataPanel.Controls.Add(this.heatKnobDataLabel);
            this.dataPanel.Controls.Add(this.temperatureRuleLabel);
            this.dataPanel.Controls.Add(this.levelRuleLabel);
            this.dataPanel.Controls.Add(this.temperatureDataLabel);
            this.dataPanel.Controls.Add(this.levelDataLabel);
            this.dataPanel.Controls.Add(this.fuzzyRuleLabel);
            this.dataPanel.Controls.Add(this.fuzzyLogicLabel);
            this.dataPanel.Location = new System.Drawing.Point(622, 198);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(150, 351);
            this.dataPanel.TabIndex = 7;
            // 
            // heatKnobRuleLabel
            // 
            this.heatKnobRuleLabel.AutoSize = true;
            this.heatKnobRuleLabel.Location = new System.Drawing.Point(5, 178);
            this.heatKnobRuleLabel.Name = "heatKnobRuleLabel";
            this.heatKnobRuleLabel.Size = new System.Drawing.Size(64, 13);
            this.heatKnobRuleLabel.TabIndex = 0;
            this.heatKnobRuleLabel.Text = "Heat Knob :";
            // 
            // heatKnobDataLabel
            // 
            this.heatKnobDataLabel.AutoSize = true;
            this.heatKnobDataLabel.Location = new System.Drawing.Point(5, 66);
            this.heatKnobDataLabel.Name = "heatKnobDataLabel";
            this.heatKnobDataLabel.Size = new System.Drawing.Size(64, 13);
            this.heatKnobDataLabel.TabIndex = 0;
            this.heatKnobDataLabel.Text = "Heat Knob :";
            // 
            // temperatureRuleLabel
            // 
            this.temperatureRuleLabel.AutoSize = true;
            this.temperatureRuleLabel.Location = new System.Drawing.Point(5, 145);
            this.temperatureRuleLabel.Name = "temperatureRuleLabel";
            this.temperatureRuleLabel.Size = new System.Drawing.Size(73, 13);
            this.temperatureRuleLabel.TabIndex = 0;
            this.temperatureRuleLabel.Text = "Temperature :";
            // 
            // levelRuleLabel
            // 
            this.levelRuleLabel.AutoSize = true;
            this.levelRuleLabel.Location = new System.Drawing.Point(5, 112);
            this.levelRuleLabel.Name = "levelRuleLabel";
            this.levelRuleLabel.Size = new System.Drawing.Size(42, 13);
            this.levelRuleLabel.TabIndex = 0;
            this.levelRuleLabel.Text = "Level  :";
            // 
            // temperatureDataLabel
            // 
            this.temperatureDataLabel.AutoSize = true;
            this.temperatureDataLabel.Location = new System.Drawing.Point(5, 48);
            this.temperatureDataLabel.Name = "temperatureDataLabel";
            this.temperatureDataLabel.Size = new System.Drawing.Size(73, 13);
            this.temperatureDataLabel.TabIndex = 0;
            this.temperatureDataLabel.Text = "Temperature :";
            // 
            // levelDataLabel
            // 
            this.levelDataLabel.AutoSize = true;
            this.levelDataLabel.Location = new System.Drawing.Point(5, 30);
            this.levelDataLabel.Name = "levelDataLabel";
            this.levelDataLabel.Size = new System.Drawing.Size(42, 13);
            this.levelDataLabel.TabIndex = 0;
            this.levelDataLabel.Text = "Level  :";
            // 
            // fuzzyRuleLabel
            // 
            this.fuzzyRuleLabel.AutoSize = true;
            this.fuzzyRuleLabel.Location = new System.Drawing.Point(5, 94);
            this.fuzzyRuleLabel.Name = "fuzzyRuleLabel";
            this.fuzzyRuleLabel.Size = new System.Drawing.Size(86, 13);
            this.fuzzyRuleLabel.TabIndex = 0;
            this.fuzzyRuleLabel.Text = "Fuzzy Rule Base";
            // 
            // fuzzyLogicLabel
            // 
            this.fuzzyLogicLabel.AutoSize = true;
            this.fuzzyLogicLabel.Location = new System.Drawing.Point(5, 12);
            this.fuzzyLogicLabel.Name = "fuzzyLogicLabel";
            this.fuzzyLogicLabel.Size = new System.Drawing.Size(89, 13);
            this.fuzzyLogicLabel.TabIndex = 0;
            this.fuzzyLogicLabel.Text = "Fuzzy Logic Data";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Heater - Fuzzy Logic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Panel graphPanel;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox waterLevelTextBox;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label heatKnobRuleLabel;
        private System.Windows.Forms.Label heatKnobDataLabel;
        private System.Windows.Forms.Label temperatureRuleLabel;
        private System.Windows.Forms.Label levelRuleLabel;
        private System.Windows.Forms.Label temperatureDataLabel;
        private System.Windows.Forms.Label levelDataLabel;
        private System.Windows.Forms.Label fuzzyRuleLabel;
        private System.Windows.Forms.Label fuzzyLogicLabel;
    }
}

