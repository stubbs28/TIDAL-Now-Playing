namespace TIDAL_Now_Playing
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.btnResetFormat = new System.Windows.Forms.Button();
            this.btnCopyNowPlaying = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNowPlaying = new System.Windows.Forms.TextBox();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.tbShortTrack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmTrackWidth = new System.Windows.Forms.NumericUpDown();
            this.btnCopyShortTrack = new System.Windows.Forms.Button();
            this.btnCopyLongTrack = new System.Windows.Forms.Button();
            this.tbLongTrack = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmTrackWidth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Format:";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(95, 143);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(232, 23);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(95, 27);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(203, 23);
            this.tbFormat.TabIndex = 3;
            this.tbFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbFormat, "How the current track should be presented");
            this.tbFormat.TextChanged += new System.EventHandler(this.tbFormat_TextChanged);
            // 
            // btnResetFormat
            // 
            this.btnResetFormat.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_undo_19;
            this.btnResetFormat.Location = new System.Drawing.Point(304, 27);
            this.btnResetFormat.Name = "btnResetFormat";
            this.btnResetFormat.Size = new System.Drawing.Size(23, 23);
            this.btnResetFormat.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnResetFormat, "Reset - Output format to default value ($track)");
            this.btnResetFormat.UseVisualStyleBackColor = true;
            this.btnResetFormat.Click += new System.EventHandler(this.btnResetFormat_Click);
            // 
            // btnCopyNowPlaying
            // 
            this.btnCopyNowPlaying.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_copy_to_clipboard_19;
            this.btnCopyNowPlaying.Location = new System.Drawing.Point(304, 56);
            this.btnCopyNowPlaying.Name = "btnCopyNowPlaying";
            this.btnCopyNowPlaying.Size = new System.Drawing.Size(23, 23);
            this.btnCopyNowPlaying.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnCopyNowPlaying, "Copy NowPlaying.txt path to clipboard");
            this.btnCopyNowPlaying.UseVisualStyleBackColor = true;
            this.btnCopyNowPlaying.Click += new System.EventHandler(this.btnCopyNowPlaying_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Now Playing:";
            // 
            // tbNowPlaying
            // 
            this.tbNowPlaying.Location = new System.Drawing.Point(95, 56);
            this.tbNowPlaying.Name = "tbNowPlaying";
            this.tbNowPlaying.ReadOnly = true;
            this.tbNowPlaying.Size = new System.Drawing.Size(203, 23);
            this.tbNowPlaying.TabIndex = 8;
            this.tbNowPlaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbNowPlaying, "Live contents of NowPlaying.txt");
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // tbShortTrack
            // 
            this.tbShortTrack.Location = new System.Drawing.Point(137, 85);
            this.tbShortTrack.Name = "tbShortTrack";
            this.tbShortTrack.ReadOnly = true;
            this.tbShortTrack.Size = new System.Drawing.Size(161, 23);
            this.tbShortTrack.TabIndex = 9;
            this.tbShortTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbShortTrack, "Live contents of ShortTrack.txt");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Short Track:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Long Track:";
            // 
            // nmTrackWidth
            // 
            this.nmTrackWidth.Location = new System.Drawing.Point(95, 85);
            this.nmTrackWidth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nmTrackWidth.Name = "nmTrackWidth";
            this.nmTrackWidth.Size = new System.Drawing.Size(36, 23);
            this.nmTrackWidth.TabIndex = 14;
            this.nmTrackWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.nmTrackWidth, "Max character width for short tracks");
            this.nmTrackWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmTrackWidth.ValueChanged += new System.EventHandler(this.nmTrackWidth_ValueChanged);
            // 
            // btnCopyShortTrack
            // 
            this.btnCopyShortTrack.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_copy_to_clipboard_19;
            this.btnCopyShortTrack.Location = new System.Drawing.Point(304, 85);
            this.btnCopyShortTrack.Name = "btnCopyShortTrack";
            this.btnCopyShortTrack.Size = new System.Drawing.Size(23, 23);
            this.btnCopyShortTrack.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnCopyShortTrack, "Copy ShortTrack.txt path to clipboard");
            this.btnCopyShortTrack.UseVisualStyleBackColor = true;
            this.btnCopyShortTrack.Click += new System.EventHandler(this.btnCopyShortTrack_Click);
            // 
            // btnCopyLongTrack
            // 
            this.btnCopyLongTrack.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_copy_to_clipboard_19;
            this.btnCopyLongTrack.Location = new System.Drawing.Point(304, 114);
            this.btnCopyLongTrack.Name = "btnCopyLongTrack";
            this.btnCopyLongTrack.Size = new System.Drawing.Size(23, 23);
            this.btnCopyLongTrack.TabIndex = 16;
            this.toolTip.SetToolTip(this.btnCopyLongTrack, "Copy LongTrack.txt path to clipboard");
            this.btnCopyLongTrack.UseVisualStyleBackColor = true;
            this.btnCopyLongTrack.Click += new System.EventHandler(this.btnCopyLongTrack_Click);
            // 
            // tbLongTrack
            // 
            this.tbLongTrack.Location = new System.Drawing.Point(95, 114);
            this.tbLongTrack.Name = "tbLongTrack";
            this.tbLongTrack.ReadOnly = true;
            this.tbLongTrack.Size = new System.Drawing.Size(203, 23);
            this.tbLongTrack.TabIndex = 17;
            this.tbLongTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbLongTrack, "Live contents of LongTrack.txt");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreDefaultsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // restoreDefaultsToolStripMenuItem
            // 
            this.restoreDefaultsToolStripMenuItem.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_restore_50;
            this.restoreDefaultsToolStripMenuItem.Name = "restoreDefaultsToolStripMenuItem";
            this.restoreDefaultsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restoreDefaultsToolStripMenuItem.Text = "Restore Defaults";
            this.restoreDefaultsToolStripMenuItem.ToolTipText = "Restore the default settings.";
            this.restoreDefaultsToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TIDAL_Now_Playing.Properties.Resources.icons8_about_50;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About this tool.";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 177);
            this.Controls.Add(this.tbLongTrack);
            this.Controls.Add(this.btnCopyLongTrack);
            this.Controls.Add(this.btnCopyShortTrack);
            this.Controls.Add(this.nmTrackWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbShortTrack);
            this.Controls.Add(this.tbNowPlaying);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopyNowPlaying);
            this.Controls.Add(this.btnResetFormat);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tidal Now Playing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmTrackWidth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnStartStop;
        private TextBox tbFormat;
        private Button btnResetFormat;
        private Button btnCopyNowPlaying;
        private Label label3;
        private TextBox tbNowPlaying;
        private System.Windows.Forms.Timer updater;
        private TextBox tbShortTrack;
        private Label label5;
        private Label label6;
        private NumericUpDown nmTrackWidth;
        private Button btnCopyShortTrack;
        private Button btnCopyLongTrack;
        private TextBox tbLongTrack;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem restoreDefaultsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTip toolTip;
    }
}