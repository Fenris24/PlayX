namespace PlayX
{
    partial class PlayX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayX));
            this.MusicList = new System.Windows.Forms.ListBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SongTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Speed05 = new System.Windows.Forms.ToolStripMenuItem();
            this.Speed075 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.Speed125 = new System.Windows.Forms.ToolStripMenuItem();
            this.Speed15 = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.PlayRandom = new System.Windows.Forms.Button();
            this.SongTime = new System.Windows.Forms.Label();
            this.RandomButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.EnterPlayButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicList
            // 
            this.MusicList.BackColor = System.Drawing.Color.Silver;
            this.MusicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicList.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 16;
            this.MusicList.Location = new System.Drawing.Point(429, 23);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(363, 224);
            this.MusicList.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.PictureBox.Location = new System.Drawing.Point(18, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(81, 71);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // SongTitle
            // 
            this.SongTitle.AutoSize = true;
            this.SongTitle.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitle.ForeColor = System.Drawing.Color.White;
            this.SongTitle.Location = new System.Drawing.Point(28, 320);
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Size = new System.Drawing.Size(71, 36);
            this.SongTitle.TabIndex = 3;
            this.SongTitle.Text = "       ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.playSpeedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem});
            this.filesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectFolderToolStripMenuItem.Text = "Select Folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // playSpeedToolStripMenuItem
            // 
            this.playSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Speed05,
            this.Speed075,
            this.SpeedNormal,
            this.Speed125,
            this.Speed15});
            this.playSpeedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playSpeedToolStripMenuItem.Name = "playSpeedToolStripMenuItem";
            this.playSpeedToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.playSpeedToolStripMenuItem.Text = "Play speed";
            // 
            // Speed05
            // 
            this.Speed05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Speed05.ForeColor = System.Drawing.Color.White;
            this.Speed05.Name = "Speed05";
            this.Speed05.Size = new System.Drawing.Size(112, 22);
            this.Speed05.Text = "0.5x";
            this.Speed05.Click += new System.EventHandler(this.Speed05_Click);
            // 
            // Speed075
            // 
            this.Speed075.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Speed075.ForeColor = System.Drawing.Color.White;
            this.Speed075.Name = "Speed075";
            this.Speed075.Size = new System.Drawing.Size(112, 22);
            this.Speed075.Text = "0.75x";
            this.Speed075.Click += new System.EventHandler(this.Speed075_Click);
            // 
            // SpeedNormal
            // 
            this.SpeedNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpeedNormal.ForeColor = System.Drawing.Color.White;
            this.SpeedNormal.Name = "SpeedNormal";
            this.SpeedNormal.Size = new System.Drawing.Size(112, 22);
            this.SpeedNormal.Text = "normal";
            this.SpeedNormal.Click += new System.EventHandler(this.SpeedNormal_Click);
            // 
            // Speed125
            // 
            this.Speed125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Speed125.ForeColor = System.Drawing.Color.White;
            this.Speed125.Name = "Speed125";
            this.Speed125.Size = new System.Drawing.Size(112, 22);
            this.Speed125.Text = "1.25x";
            this.Speed125.Click += new System.EventHandler(this.Speed125_Click);
            // 
            // Speed15
            // 
            this.Speed15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Speed15.ForeColor = System.Drawing.Color.White;
            this.Speed15.Name = "Speed15";
            this.Speed15.Size = new System.Drawing.Size(112, 22);
            this.Speed15.Text = "1.5x";
            this.Speed15.Click += new System.EventHandler(this.Speed15_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.Controls.Add(this.PlayRandom);
            this.PlayPanel.Controls.Add(this.SongTime);
            this.PlayPanel.Controls.Add(this.RandomButton);
            this.PlayPanel.Controls.Add(this.BackwardButton);
            this.PlayPanel.Controls.Add(this.ForwardButton);
            this.PlayPanel.Controls.Add(this.PlayPauseButton);
            this.PlayPanel.Controls.Add(this.trackBar1);
            this.PlayPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.PlayPanel.Controls.Add(this.SongTitle);
            this.PlayPanel.Controls.Add(this.PictureBox);
            this.PlayPanel.Controls.Add(this.MusicList);
            this.PlayPanel.ForeColor = System.Drawing.Color.Transparent;
            this.PlayPanel.Location = new System.Drawing.Point(0, 27);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(804, 460);
            this.PlayPanel.TabIndex = 5;
            // 
            // PlayRandom
            // 
            this.PlayRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PlayRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayRandom.Location = new System.Drawing.Point(678, 379);
            this.PlayRandom.Margin = new System.Windows.Forms.Padding(0);
            this.PlayRandom.Name = "PlayRandom";
            this.PlayRandom.Size = new System.Drawing.Size(48, 38);
            this.PlayRandom.TabIndex = 10;
            this.PlayRandom.Text = "�";
            this.PlayRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayRandom.UseVisualStyleBackColor = false;
            this.PlayRandom.Click += new System.EventHandler(this.PlayRandom_Click);
            // 
            // SongTime
            // 
            this.SongTime.AutoSize = true;
            this.SongTime.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTime.ForeColor = System.Drawing.Color.White;
            this.SongTime.Location = new System.Drawing.Point(12, 396);
            this.SongTime.Name = "SongTime";
            this.SongTime.Size = new System.Drawing.Size(54, 28);
            this.SongTime.TabIndex = 9;
            this.SongTime.Text = "       ";
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(729, 379);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(0);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(48, 38);
            this.RandomButton.TabIndex = 8;
            this.RandomButton.Text = "🔀";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // BackwardButton
            // 
            this.BackwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwardButton.Location = new System.Drawing.Point(305, 380);
            this.BackwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackwardButton.Size = new System.Drawing.Size(48, 38);
            this.BackwardButton.TabIndex = 7;
            this.BackwardButton.Text = "⏮︎";
            this.BackwardButton.UseVisualStyleBackColor = false;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardButton.Location = new System.Drawing.Point(454, 380);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(48, 38);
            this.ForwardButton.TabIndex = 0;
            this.ForwardButton.Text = "⏭︎";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PlayPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPauseButton.Location = new System.Drawing.Point(356, 380);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(95, 38);
            this.PlayPauseButton.TabIndex = 6;
            this.PlayPauseButton.Text = " ▶";
            this.PlayPauseButton.UseVisualStyleBackColor = false;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 435);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(780, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(66, 109);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(224, 128);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.SelectFolderButton);
            this.MenuPanel.Controls.Add(this.EnterPlayButton);
            this.MenuPanel.Location = new System.Drawing.Point(0, 27);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(804, 450);
            this.MenuPanel.TabIndex = 4;
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SelectFolderButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderButton.ForeColor = System.Drawing.Color.White;
            this.SelectFolderButton.Location = new System.Drawing.Point(66, 112);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(254, 40);
            this.SelectFolderButton.TabIndex = 1;
            this.SelectFolderButton.Text = "SELECT FOLDER";
            this.SelectFolderButton.UseVisualStyleBackColor = false;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // EnterPlayButton
            // 
            this.EnterPlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EnterPlayButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPlayButton.ForeColor = System.Drawing.Color.White;
            this.EnterPlayButton.Location = new System.Drawing.Point(66, 47);
            this.EnterPlayButton.Name = "EnterPlayButton";
            this.EnterPlayButton.Size = new System.Drawing.Size(254, 40);
            this.EnterPlayButton.TabIndex = 0;
            this.EnterPlayButton.Text = "PLAYX";
            this.EnterPlayButton.UseVisualStyleBackColor = false;
            this.EnterPlayButton.Click += new System.EventHandler(this.EnterPlayButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // PlayX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayX";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PlayPanel.ResumeLayout(false);
            this.PlayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label SongTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button EnterPlayButton;
        private System.Windows.Forms.Button SelectFolderButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Label SongTime;
        private System.Windows.Forms.Button PlayRandom;
        private System.Windows.Forms.ToolStripMenuItem playSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Speed05;
        private System.Windows.Forms.ToolStripMenuItem Speed075;
        private System.Windows.Forms.ToolStripMenuItem SpeedNormal;
        private System.Windows.Forms.ToolStripMenuItem Speed125;
        private System.Windows.Forms.ToolStripMenuItem Speed15;
    }
}

