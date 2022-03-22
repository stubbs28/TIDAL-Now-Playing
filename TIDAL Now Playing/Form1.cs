namespace TIDAL_Now_Playing
{
    public partial class Form1 : Form
    {
        public static readonly string TEXT_FILES = "TextFiles";
        public static readonly string OUTPUT = "NowPlaying.txt";
        public static readonly string OVER_OUTPUT = "NowPlaying_long.txt";
        public static readonly string UNDER_OUTPUT = "NowPlaying_short.txt";
        public bool Running { get; set; }
        public string NowPlaying { get; set; }
        public string WorkingDirectory { get; set; }
        public TidalTitle TidalTitle;
        public Form1()
        {
            Running = false;
            NowPlaying = "";
            TidalTitle = new();
            Directory.CreateDirectory(TEXT_FILES);
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            WorkingDirectory = System.IO.Path.GetDirectoryName(strExeFilePath)!;
            WorkingDirectory = System.IO.Path.Combine(WorkingDirectory, TEXT_FILES);
            InitializeComponent();
            tbOutputFormat.Text = TidalTitle.SONG;
        }

        private void btnResetOutputFormat_Click(object sender, EventArgs e)
        {
            tbOutputFormat.Text = TidalTitle.SONG;
        }

        private void btnCopyOutputPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOutputPath.Text);
        }

        private void btnCopyUnderPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbUnderPath.Text);
        }

        private void btnCopyOverPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbOverPath.Text);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                btnStartStop.Text = "Stop";
                updater.Start();

            } else
            {
                btnStartStop.Text = "Start";
                updater.Stop();
                updateOutput(tbOutputPath, OUTPUT, "");
                updateOutput(tbUnderPath, UNDER_OUTPUT, "");
                updateOutput(tbOverPath, OVER_OUTPUT, "");

            }
            Running = !Running;
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            if (Running)
            {
                string nowPlaying = TidalTitle.NowPlaying(tbOutputFormat.Text);
                if (nowPlaying != NowPlaying)
                {
                    tbLiveOutput.Text = nowPlaying;
                    NowPlaying = nowPlaying;
                    if (cbCharacterLimitEnable.Checked)
                    {
                        if (nowPlaying.Length <= nmCharacterLimit.Value)
                        {
                            updateOutput(tbOverPath, OVER_OUTPUT, "");
                            updateOutput(tbUnderPath, UNDER_OUTPUT, nowPlaying);
                            
                        }
                        else
                        {
                            updateOutput(tbUnderPath, UNDER_OUTPUT, "");
                            updateOutput(tbOverPath, OVER_OUTPUT, nowPlaying);
                            
                        }
                    }
                    updateOutput(tbOutputPath, OUTPUT, nowPlaying);
                }
            }
        }

        private void updateOutput(TextBox tb, string path, string output)
        {
            string fullpath = System.IO.Path.Combine(WorkingDirectory, path);
            using (FileStream fs = File.Create(fullpath))
            {
                fs.Write(new System.Text.UTF8Encoding(true).GetBytes(output));
                
            }
            if (tb.Text == "")
            {
                tb.Text = fullpath;
            }
        }

        private void cbCharacterLimitEnable_CheckedChanged(object sender, EventArgs e)
        {
            NowPlaying = "";
            btnCopyUnderPath.Enabled = !btnCopyUnderPath.Enabled;
            btnCopyOverPath.Enabled = !btnCopyOverPath.Enabled;
        }
    }
}