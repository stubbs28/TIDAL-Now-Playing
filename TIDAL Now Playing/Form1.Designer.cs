namespace TIDAL_Now_Playing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tbOutputFormat = new System.Windows.Forms.TextBox();
            this.tbLiveOutput = new System.Windows.Forms.TextBox();
            this.btnResetOutputFormat = new System.Windows.Forms.Button();
            this.btnCopyOutputPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.tbUnderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmCharacterLimit = new System.Windows.Forms.NumericUpDown();
            this.btnCopyUnderPath = new System.Windows.Forms.Button();
            this.btnCopyOverPath = new System.Windows.Forms.Button();
            this.cbCharacterLimitEnable = new System.Windows.Forms.CheckBox();
            this.tbOverPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.nmCharacterLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Live Output:";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(117, 187);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(232, 23);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tbOutputFormat
            // 
            this.tbOutputFormat.Location = new System.Drawing.Point(117, 13);
            this.tbOutputFormat.Name = "tbOutputFormat";
            this.tbOutputFormat.Size = new System.Drawing.Size(168, 23);
            this.tbOutputFormat.TabIndex = 3;
            this.tbOutputFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLiveOutput
            // 
            this.tbLiveOutput.Location = new System.Drawing.Point(117, 42);
            this.tbLiveOutput.Name = "tbLiveOutput";
            this.tbLiveOutput.ReadOnly = true;
            this.tbLiveOutput.Size = new System.Drawing.Size(232, 23);
            this.tbLiveOutput.TabIndex = 4;
            this.tbLiveOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetOutputFormat
            // 
            this.btnResetOutputFormat.Location = new System.Drawing.Point(288, 11);
            this.btnResetOutputFormat.Name = "btnResetOutputFormat";
            this.btnResetOutputFormat.Size = new System.Drawing.Size(61, 23);
            this.btnResetOutputFormat.TabIndex = 5;
            this.btnResetOutputFormat.Text = "Reset";
            this.btnResetOutputFormat.UseVisualStyleBackColor = true;
            this.btnResetOutputFormat.Click += new System.EventHandler(this.btnResetOutputFormat_Click);
            // 
            // btnCopyOutputPath
            // 
            this.btnCopyOutputPath.Location = new System.Drawing.Point(288, 71);
            this.btnCopyOutputPath.Name = "btnCopyOutputPath";
            this.btnCopyOutputPath.Size = new System.Drawing.Size(61, 23);
            this.btnCopyOutputPath.TabIndex = 6;
            this.btnCopyOutputPath.Text = "Copy";
            this.btnCopyOutputPath.UseVisualStyleBackColor = true;
            this.btnCopyOutputPath.Click += new System.EventHandler(this.btnCopyOutputPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output Path:";
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(117, 71);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.Size = new System.Drawing.Size(165, 23);
            this.tbOutputPath.TabIndex = 8;
            this.tbOutputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // tbUnderPath
            // 
            this.tbUnderPath.Location = new System.Drawing.Point(117, 129);
            this.tbUnderPath.Name = "tbUnderPath";
            this.tbUnderPath.ReadOnly = true;
            this.tbUnderPath.Size = new System.Drawing.Size(165, 23);
            this.tbUnderPath.TabIndex = 9;
            this.tbUnderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Character Limit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Under Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Over Path:";
            // 
            // nmCharacterLimit
            // 
            this.nmCharacterLimit.Location = new System.Drawing.Point(117, 100);
            this.nmCharacterLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmCharacterLimit.Name = "nmCharacterLimit";
            this.nmCharacterLimit.Size = new System.Drawing.Size(165, 23);
            this.nmCharacterLimit.TabIndex = 14;
            this.nmCharacterLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCharacterLimit.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // btnCopyUnderPath
            // 
            this.btnCopyUnderPath.Enabled = false;
            this.btnCopyUnderPath.Location = new System.Drawing.Point(288, 129);
            this.btnCopyUnderPath.Name = "btnCopyUnderPath";
            this.btnCopyUnderPath.Size = new System.Drawing.Size(61, 23);
            this.btnCopyUnderPath.TabIndex = 15;
            this.btnCopyUnderPath.Text = "Copy";
            this.btnCopyUnderPath.UseVisualStyleBackColor = true;
            this.btnCopyUnderPath.Click += new System.EventHandler(this.btnCopyUnderPath_Click);
            // 
            // btnCopyOverPath
            // 
            this.btnCopyOverPath.Enabled = false;
            this.btnCopyOverPath.Location = new System.Drawing.Point(288, 158);
            this.btnCopyOverPath.Name = "btnCopyOverPath";
            this.btnCopyOverPath.Size = new System.Drawing.Size(61, 23);
            this.btnCopyOverPath.TabIndex = 16;
            this.btnCopyOverPath.Text = "Copy";
            this.btnCopyOverPath.UseVisualStyleBackColor = true;
            this.btnCopyOverPath.Click += new System.EventHandler(this.btnCopyOverPath_Click);
            // 
            // cbCharacterLimitEnable
            // 
            this.cbCharacterLimitEnable.AutoSize = true;
            this.cbCharacterLimitEnable.Location = new System.Drawing.Point(288, 104);
            this.cbCharacterLimitEnable.Name = "cbCharacterLimitEnable";
            this.cbCharacterLimitEnable.Size = new System.Drawing.Size(61, 19);
            this.cbCharacterLimitEnable.TabIndex = 10;
            this.cbCharacterLimitEnable.Text = "Enable";
            this.cbCharacterLimitEnable.UseVisualStyleBackColor = true;
            this.cbCharacterLimitEnable.CheckedChanged += new System.EventHandler(this.cbCharacterLimitEnable_CheckedChanged);
            // 
            // tbOverPath
            // 
            this.tbOverPath.Location = new System.Drawing.Point(117, 158);
            this.tbOverPath.Name = "tbOverPath";
            this.tbOverPath.ReadOnly = true;
            this.tbOverPath.Size = new System.Drawing.Size(165, 23);
            this.tbOverPath.TabIndex = 17;
            this.tbOverPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 225);
            this.Controls.Add(this.tbOverPath);
            this.Controls.Add(this.btnCopyOverPath);
            this.Controls.Add(this.btnCopyUnderPath);
            this.Controls.Add(this.nmCharacterLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCharacterLimitEnable);
            this.Controls.Add(this.tbUnderPath);
            this.Controls.Add(this.tbOutputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopyOutputPath);
            this.Controls.Add(this.btnResetOutputFormat);
            this.Controls.Add(this.tbLiveOutput);
            this.Controls.Add(this.tbOutputFormat);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tidal Now Playing";
            ((System.ComponentModel.ISupportInitialize)(this.nmCharacterLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnStartStop;
        private TextBox tbOutputFormat;
        private TextBox tbLiveOutput;
        private Button btnResetOutputFormat;
        private Button btnCopyOutputPath;
        private Label label3;
        private TextBox tbOutputPath;
        private System.Windows.Forms.Timer updater;
        private TextBox tbUnderPath;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nmCharacterLimit;
        private Button btnCopyUnderPath;
        private Button btnCopyOverPath;
        private CheckBox cbCharacterLimitEnable;
        private TextBox tbOverPath;
        private MenuStrip menuStrip1;
    }
}