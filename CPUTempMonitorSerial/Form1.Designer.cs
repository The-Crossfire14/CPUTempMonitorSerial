namespace CPUTempMonitorSerial
{
    partial class HardwareMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareMonitor));
            this.outputBox = new System.Windows.Forms.TextBox();
            this.cpuTempButton = new System.Windows.Forms.RadioButton();
            this.cpuLoadButton = new System.Windows.Forms.RadioButton();
            this.gpuTempButton = new System.Windows.Forms.RadioButton();
            this.gpuLoadButton = new System.Windows.Forms.RadioButton();
            this.cpuTempTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.gpuTempTimer = new System.Windows.Forms.Timer(this.components);
            this.gpuLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.ramLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.ramLoadButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(32, 29);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(228, 20);
            this.outputBox.TabIndex = 0;
            // 
            // cpuTempButton
            // 
            this.cpuTempButton.AutoSize = true;
            this.cpuTempButton.Location = new System.Drawing.Point(32, 56);
            this.cpuTempButton.Name = "cpuTempButton";
            this.cpuTempButton.Size = new System.Drawing.Size(114, 18);
            this.cpuTempButton.TabIndex = 1;
            this.cpuTempButton.TabStop = true;
            this.cpuTempButton.Text = "CPU Temperature";
            this.cpuTempButton.UseCompatibleTextRendering = true;
            this.cpuTempButton.UseVisualStyleBackColor = true;
            this.cpuTempButton.CheckedChanged += new System.EventHandler(this.cpuTempButton_CheckedChanged);
            // 
            // cpuLoadButton
            // 
            this.cpuLoadButton.AutoSize = true;
            this.cpuLoadButton.Location = new System.Drawing.Point(32, 80);
            this.cpuLoadButton.Name = "cpuLoadButton";
            this.cpuLoadButton.Size = new System.Drawing.Size(74, 17);
            this.cpuLoadButton.TabIndex = 2;
            this.cpuLoadButton.TabStop = true;
            this.cpuLoadButton.Text = "CPU Load";
            this.cpuLoadButton.UseVisualStyleBackColor = true;
            this.cpuLoadButton.CheckedChanged += new System.EventHandler(this.cpuLoadButton_CheckedChanged);
            // 
            // gpuTempButton
            // 
            this.gpuTempButton.AutoSize = true;
            this.gpuTempButton.Location = new System.Drawing.Point(32, 104);
            this.gpuTempButton.Name = "gpuTempButton";
            this.gpuTempButton.Size = new System.Drawing.Size(111, 17);
            this.gpuTempButton.TabIndex = 3;
            this.gpuTempButton.TabStop = true;
            this.gpuTempButton.Text = "GPU Temperature";
            this.gpuTempButton.UseVisualStyleBackColor = true;
            this.gpuTempButton.CheckedChanged += new System.EventHandler(this.gpuTempButton_CheckedChanged);
            // 
            // gpuLoadButton
            // 
            this.gpuLoadButton.AutoSize = true;
            this.gpuLoadButton.Location = new System.Drawing.Point(32, 128);
            this.gpuLoadButton.Name = "gpuLoadButton";
            this.gpuLoadButton.Size = new System.Drawing.Size(75, 17);
            this.gpuLoadButton.TabIndex = 4;
            this.gpuLoadButton.TabStop = true;
            this.gpuLoadButton.Text = "GPU Load";
            this.gpuLoadButton.UseVisualStyleBackColor = true;
            this.gpuLoadButton.CheckedChanged += new System.EventHandler(this.gpuLoadButton_CheckedChanged);
            // 
            // cpuTempTimer
            // 
            this.cpuTempTimer.Interval = 750;
            this.cpuTempTimer.Tick += new System.EventHandler(this.cpuTempTimer_Tick);
            // 
            // cpuLoadTimer
            // 
            this.cpuLoadTimer.Interval = 750;
            this.cpuLoadTimer.Tick += new System.EventHandler(this.cpuLoadTimer_Tick);
            // 
            // gpuTempTimer
            // 
            this.gpuTempTimer.Interval = 750;
            this.gpuTempTimer.Tick += new System.EventHandler(this.gpuTempTimer_Tick);
            // 
            // gpuLoadTimer
            // 
            this.gpuLoadTimer.Interval = 750;
            this.gpuLoadTimer.Tick += new System.EventHandler(this.gpuLoadTimer_Tick);
            // 
            // ramLoadTimer
            // 
            this.ramLoadTimer.Interval = 750;
            this.ramLoadTimer.Tick += new System.EventHandler(this.ramLoadTimer_Tick);
            // 
            // ramLoadButton
            // 
            this.ramLoadButton.AutoSize = true;
            this.ramLoadButton.Location = new System.Drawing.Point(32, 152);
            this.ramLoadButton.Name = "ramLoadButton";
            this.ramLoadButton.Size = new System.Drawing.Size(76, 17);
            this.ramLoadButton.TabIndex = 5;
            this.ramLoadButton.TabStop = true;
            this.ramLoadButton.Text = "RAM Load";
            this.ramLoadButton.UseVisualStyleBackColor = true;
            this.ramLoadButton.CheckedChanged += new System.EventHandler(this.ramLoadButton_CheckedChanged);
            // 
            // HardwareMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ramLoadButton);
            this.Controls.Add(this.gpuLoadButton);
            this.Controls.Add(this.gpuTempButton);
            this.Controls.Add(this.cpuLoadButton);
            this.Controls.Add(this.cpuTempButton);
            this.Controls.Add(this.outputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HardwareMonitor";
            this.Text = "Hardware Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.RadioButton cpuTempButton;
        private System.Windows.Forms.RadioButton cpuLoadButton;
        private System.Windows.Forms.RadioButton gpuTempButton;
        private System.Windows.Forms.RadioButton gpuLoadButton;
        private System.Windows.Forms.Timer cpuTempTimer;
        private System.Windows.Forms.Timer cpuLoadTimer;
        private System.Windows.Forms.Timer gpuTempTimer;
        private System.Windows.Forms.Timer gpuLoadTimer;
        private System.Windows.Forms.Timer ramLoadTimer;
        private System.Windows.Forms.RadioButton ramLoadButton;
    }
}

