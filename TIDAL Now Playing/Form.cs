namespace TIDAL_Now_Playing
{
    public partial class Form : System.Windows.Forms.Form
    {
        public static readonly string TEXT_FILES = "TextFiles";
        public static readonly string SETTINGS = "settings.json";
        public static readonly string OUTPUT = "NowPlaying.txt";
        public static readonly string LONG_OUTPUT = "LongTrack.txt";
        public static readonly string SHORT_OUTPUT = "ShortTrack.txt";
        private static readonly string EMPTY = "{empty}";

        public bool running { get; set; }
        private string workingDirectory { get; set; }

        private TidalTitle tidalTitle;
        public Form()
        {
            running = false;
            tidalTitle = new();
            tidalTitle.Load(SETTINGS);
            Directory.CreateDirectory(TEXT_FILES);
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            workingDirectory = System.IO.Path.GetDirectoryName(strExeFilePath)!;
            workingDirectory = System.IO.Path.Combine(workingDirectory, TEXT_FILES);
            InitializeComponent();
            tbFormat.Text = tidalTitle.settings.format;
            nmTrackWidth.Value = tidalTitle.settings.textWidth;
        }

        private void btnResetFormat_Click(object sender, EventArgs e)
        {
            tbFormat.Text = TidalTitle.SONG;
        }

        private void btnCopyNowPlaying_Click(object sender, EventArgs e)
        {
            copyPath(OUTPUT);
        }

        private void btnCopyShortTrack_Click(object sender, EventArgs e)
        {
            copyPath(SHORT_OUTPUT);
        }

        private void btnCopyLongTrack_Click(object sender, EventArgs e)
        {
            copyPath(LONG_OUTPUT);
        }

        private void copyPath(string path)
        {
            string fullpath = System.IO.Path.Combine(workingDirectory, path);
            if (File.Exists(fullpath))
            {
                Clipboard.SetText(fullpath);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                btnStartStop.Text = "Stop";
                updater.Start();

            } else
            {
                btnStartStop.Text = "Start";
                updater.Stop();
                updateOutput(tbNowPlaying, OUTPUT, "");
                updateOutput(tbShortTrack, SHORT_OUTPUT, "");
                updateOutput(tbLongTrack, LONG_OUTPUT, "");

            }
            running = !running;
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                tidalTitle.Update();
                updateOutput(tbNowPlaying, OUTPUT, tidalTitle.nowPlaying);
                updateOutput(tbShortTrack, SHORT_OUTPUT, tidalTitle.shortTrack);
                updateOutput(tbLongTrack, LONG_OUTPUT, tidalTitle.longTrack);
            }
        }

        private void updateOutput(TextBox tb, string path, string output)
        {
            string fullpath = System.IO.Path.Combine(workingDirectory, path);
            using (FileStream fs = File.Create(fullpath))
            {
                fs.Write(new System.Text.UTF8Encoding(true).GetBytes(output));
            }
            tb.Text = output == "" ? EMPTY : output;
        }

        private void restoreDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnResetFormat_Click(sender, e);
            nmTrackWidth.Value = Settings.DEFAULT_TRACK_WIDTH;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AboutBox();
            window.Owner = this;
            window.Show();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            tidalTitle.Save(SETTINGS);
        }

        private void tbFormat_TextChanged(object sender, EventArgs e)
        {
            tidalTitle.settings.format = tbFormat.Text;
        }

        private void nmTrackWidth_ValueChanged(object sender, EventArgs e)
        {
            tidalTitle.settings.textWidth = nmTrackWidth.Value;
        }
    }
}