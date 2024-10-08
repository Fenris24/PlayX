using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace PlayX
{
    public partial class PlayX : Form
    {
        private List<int> songHistory = new List<int>();
        private int historyIndex = -1;
        public string selectedFolderPath;
        public bool playPause = false;
        public bool isDragging = false;
        public bool isBackward = false;
        public bool isRandom = false;
        public bool nextSong = false;
        public enum speed { speed05, speed075, speedNormal, speed125, speed15 };
        public speed playSpeed;
        public PlayX()
        {
            InitializeComponent();
            MenuPanel.Visible = true;
            PlayPanel.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            this.Size = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChange);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            trackBar1.MouseDown += new MouseEventHandler(trackBar1_MouseDown);
            trackBar1.MouseUp += new MouseEventHandler(trackBar1_MouseUp);
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            PictureBox.BackColor = Color.Transparent;
            PictureBox.Image = null;
            playSpeed = speed.speedNormal;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSelectedPath))
            {
                selectedFolderPath = Properties.Settings.Default.LastSelectedPath;
                LoadSongs(selectedFolderPath);
            }
        }
        private void NoHover()
        {
            RandomButton.FlatAppearance.MouseOverBackColor = RandomButton.BackColor;
            RandomButton.BackColorChanged += (sender, e) =>
            {
                RandomButton.FlatAppearance.MouseOverBackColor = RandomButton.BackColor;
            };
            PlayPauseButton.FlatAppearance.MouseOverBackColor = PlayPauseButton.BackColor;
            PlayPauseButton.BackColorChanged += (sender, e) =>
            {
                PlayPauseButton.FlatAppearance.MouseOverBackColor = PlayPauseButton.BackColor;
            };
            ForwardButton.FlatAppearance.MouseOverBackColor = ForwardButton.BackColor;
            ForwardButton.BackColorChanged += (sender, e) =>
            {
                ForwardButton.FlatAppearance.MouseOverBackColor = ForwardButton.BackColor;
            };
            BackwardButton.FlatAppearance.MouseOverBackColor = BackwardButton.BackColor;
            BackwardButton.BackColorChanged += (sender, e) =>
            {
                BackwardButton.FlatAppearance.MouseOverBackColor = BackwardButton.BackColor;
            };
        }
        private void LoadSong(string filePath)
        {
            axWindowsMediaPlayer1.URL = filePath;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            trackBar1.Value = 0;
        }
        private void LoadSongs(string folderPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            List<FileInfo> files = new List<FileInfo>();

            files.AddRange(dirInfo.GetFiles("*.mp3", SearchOption.AllDirectories));
            files.AddRange(dirInfo.GetFiles("*.mp4", SearchOption.AllDirectories));
            files.AddRange(dirInfo.GetFiles("*.wav", SearchOption.AllDirectories));
            files.AddRange(dirInfo.GetFiles("*.flac", SearchOption.AllDirectories));
            files.AddRange(dirInfo.GetFiles("*.aac", SearchOption.AllDirectories));

            MusicList.Items.Clear();

            foreach (FileInfo file in files)
            {
                MusicList.Items.Add(file.Name);
            }
        }
        private void MusicList_SelectedIndexChange(object sender, EventArgs e)
        {
            if (MusicList.SelectedIndex != -1)
            {
                string selectedSong = MusicList.SelectedItem.ToString();
                SongTitle.Text = selectedSong;
                string filePath = selectedFolderPath + "\\" + selectedSong;
                if (songHistory.Count == 0 || songHistory.Last() != MusicList.SelectedIndex && isBackward == false)
                {
                    songHistory.Add(MusicList.SelectedIndex);
                    historyIndex = songHistory.Count - 1;
                }
                isBackward = false;
                LoadSong(filePath);
                PlaySong(filePath);
                try
                {
                    Image thumbnail = GetThumbnail(filePath);
                    UpdatePictureBoxWithImage(thumbnail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving thumbnail: " + ex.Message);
                }
            }
            nextSong = false;
        }
        private void PlaySong(string filePath)
        {
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                switch (playSpeed)
                {
                    case speed.speedNormal:
                        axWindowsMediaPlayer1.settings.rate = 1;
                        break;
                    case speed.speed05:
                        axWindowsMediaPlayer1.settings.rate = 0.5;
                        break;
                    case speed.speed075:
                        axWindowsMediaPlayer1.settings.rate = 0.75;
                        break;
                    case speed.speed125:
                        axWindowsMediaPlayer1.settings.rate = 1.25;
                        break;
                    case speed.speed15:
                        axWindowsMediaPlayer1.settings.rate = 1.5;
                        break;
                }
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            PlayPauseButton.Text = "⏸︎";
            playPause = true;
        }
        private void PlayRandomSong()
        {
            isBackward = false;
            if (MusicList.Items.Count > 0)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(MusicList.Items.Count);
                MusicList.SelectedIndex = randomIndex;
            }
        }
        private Image GetThumbnail(string filePath)
        {
            using (ShellObject shellObject = ShellObject.FromParsingName(filePath))
            {
                Bitmap thumb = shellObject.Thumbnail.LargeBitmap;
                return thumb;
            }
        }
        private void UpdatePictureBoxWithImage(Image image)
        {
            PictureBox.Width = image.Width;
            PictureBox.Height = image.Height;

            int baseX = 50;
            int baseY = 30;

            double aspectRatio = (double)image.Width / image.Height;

            if (aspectRatio > 1.0)
            {
                baseY = (int)((double)baseY * aspectRatio * 2);
            }
            else if (aspectRatio < 1.0)
            {
                baseX = (int)((double)baseX * aspectRatio);
            }
            PictureBox.Location = new Point(baseX + 30, baseY);

            PictureBox.Image = image;
        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.LastSelectedPath;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.LastSelectedPath = selectedFolderPath;
                    Properties.Settings.Default.Save();
                    LoadSongs(selectedFolderPath);
                }
            }
        }

        private void EnterPlayButton_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - 200, this.Location.Y - 150);
            MenuPanel.Visible = false;
            PlayPanel.Visible = true;
            this.Size = new Size(820, 520);
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                    LoadSongs(selectedFolderPath);
                }
            }
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(axWindowsMediaPlayer1.URL) && playPause == false)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                PlayPauseButton.Text = "⏸︎";
                playPause = true;
            }
            else if (playPause == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                PlayPauseButton.Text = " ▶";
                playPause = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(axWindowsMediaPlayer1.URL) && isDragging == false)
            {
                if (!axWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsPaused) &&
                !axWindowsMediaPlayer1.playState.Equals(WMPLib.WMPPlayState.wmppsStopped))
                {
                    double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                    double duration = axWindowsMediaPlayer1.currentMedia.duration;
                    SongTime.Text = ((int)currentPosition / 60).ToString() + ":" + ((int)currentPosition % 60).ToString("00") + " / " +
                        ((int)duration / 60).ToString() + ":" + ((int)duration % 60).ToString("00");

                    if (duration > 0)
                    {
                        if((int)((currentPosition / duration) * trackBar1.Maximum) < 1000)
                        trackBar1.Value = (int)((currentPosition / duration) * trackBar1.Maximum);
                    }
                    if (trackBar1.Value == 999)
                    {
                        if (isRandom)
                        {
                            PlayRandomSong();
                        }
                        else
                        {
                            if (MusicList.SelectedIndex < MusicList.Items.Count - 1)
                                MusicList.SelectedIndex++;
                            else
                                MusicList.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void trackBar1_MouseUp(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(axWindowsMediaPlayer1.URL))
            {
                double percent = trackBar1.Value / 10.0;

                double durationInMilliseconds = axWindowsMediaPlayer1.currentMedia.duration * 1000;
                double seekPosition = (percent / 100) * durationInMilliseconds;

                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = seekPosition / 1000;
            }
            isDragging = false;
        }
        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            TrackBar trackBar = (TrackBar)sender;
            double dblValue;
            dblValue = ((double)e.X / (double)trackBar.ClientSize.Width) * trackBar.Maximum;
            trackBar.Value = Convert.ToInt32(dblValue);
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (historyIndex >= 0)
            {
                if (isRandom)
                {
                    PlayRandomSong();
                }
                else if (historyIndex + 1 < songHistory.Count)
                {
                    MusicList.SelectedIndex = songHistory[++historyIndex];
                }
                else if (MusicList.SelectedIndex < MusicList.Items.Count - 1)
                {
                    MusicList.SelectedIndex++;
                }
                else
                {
                    MusicList.SelectedIndex = 0;
                }
            }
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if (historyIndex > 0)
            {
                historyIndex--;
                isBackward = true;
                MusicList.SelectedIndex = songHistory[historyIndex];
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
/*            if (nextSong == false && e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (isRandom)
                {
                    PlayRandomSong();
                }
                else
                {
                    if (MusicList.SelectedIndex < MusicList.Items.Count - 1)
                        MusicList.SelectedIndex++;
                    else
                        MusicList.SelectedIndex = 0;
                    PlaySong(MusicList.SelectedItem.ToString());
                }
                nextSong = true;
            }*/
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                isRandom = true;
                RandomButton.ForeColor = Color.Black;
            }
            else 
            {
                isRandom = false;
                RandomButton.ForeColor = Color.White;
            }
        }

        private void PlayRandom_Click(object sender, EventArgs e)
        {
            PlayRandomSong();
        }

        private void Speed05_Click(object sender, EventArgs e)
        {
            Speed05.Text = "0.5x        ♫";
            Speed075.Text = "0.75x";
            SpeedNormal.Text = "normal";
            Speed125.Text = "1.25x";
            Speed15.Text = "1.5x";
            playSpeed = speed.speed05;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                axWindowsMediaPlayer1.settings.rate = 0.5;
            }
        }

        private void Speed075_Click(object sender, EventArgs e)
        {
            Speed05.Text = "0.5x";
            Speed075.Text = "0.75x      ♫";
            SpeedNormal.Text = "normal";
            Speed125.Text = "1.25x";
            Speed15.Text = "1.5x";
            playSpeed = speed.speed075;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                axWindowsMediaPlayer1.settings.rate = 0.75;
            }
        }

        private void SpeedNormal_Click(object sender, EventArgs e)
        {
            Speed05.Text = "0.5x";
            Speed075.Text = "0.75x";
            SpeedNormal.Text = "normal";
            Speed125.Text = "1.25x";
            Speed15.Text = "1.5x";
            playSpeed = speed.speedNormal;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                axWindowsMediaPlayer1.settings.rate = 1;
            }
        }

        private void Speed125_Click(object sender, EventArgs e)
        {
            Speed05.Text = "0.5x";
            Speed075.Text = "0.75x";
            SpeedNormal.Text = "normal";
            Speed125.Text = "1.25x      ♫";
            Speed15.Text = "1.5x";
            playSpeed = speed.speed125;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                axWindowsMediaPlayer1.settings.rate = 1.25;
            }
        }

        private void Speed15_Click(object sender, EventArgs e)
        {
            Speed05.Text = "0.5x";
            Speed075.Text = "0.75x";
            SpeedNormal.Text = "normal";
            Speed125.Text = "1.25x";
            Speed15.Text = "1.5x        ♫";
            playSpeed = speed.speed15;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
            {
                axWindowsMediaPlayer1.settings.rate = 1.5;
            }
        }
    }
}
