using System.ComponentModel;
using System.Media;

namespace eilidh_finalproject
{
    public partial class MusicPlayer : Form
    {
        private BindingList<Music> musicList;
        private SoundPlayer musicPlayer = new SoundPlayer();

        private int currentTrackIndex = 0;
        private double progress = 0;

        private System.Windows.Forms.Timer playbackTimer;
        private int remainingPlaybackTime;
        private int elapsedTimeInSeconds = 0;

        public MusicPlayer()
        {
            InitializeComponent();
            LoadData(lvSongSelection);
            this.DoubleBuffered = true;
            InitializeTimer();

            lvSongSelection.DoubleClick += lvSongSelection_DoubleClick;
            btnForward.Click += btnForward_Click;
            btnBack.Click += btnBack_Click;
            cbPausePlay.CheckedChanged += cbPausePlay_CheckedChanged;
        }

        private void LoadData(ListView lvSongSelection)
        {
            lvSongSelection.Clear();

            lvSongSelection.View = View.Details;
            lvSongSelection.FullRowSelect = true;

            lvSongSelection.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvSongSelection.Columns.Add("Song", 200, HorizontalAlignment.Left);
            lvSongSelection.Columns.Add("Artist", 200, HorizontalAlignment.Left);
            lvSongSelection.Columns.Add("Duration", 110, HorizontalAlignment.Left);

            // Clear previous items before adding new ones
            lvSongSelection.Items.Clear();

            // Retrieve the updated list of songs
            var songs = Data.GetMusic();
            musicList = new BindingList<Music>(songs.ToList());

            foreach (Music music in songs)
            {
                ListViewItem item = new ListViewItem(music.SongID.ToString());
                item.SubItems.Add(music.SongName);
                item.SubItems.Add(music.Artist);
                item.SubItems.Add(music.Duration);
                lvSongSelection.Items.Add(item);
            }
        }

        public void UpdateListView(object sender, ListChangedEventArgs e)
        {
            // Clear previous items before adding updated data
            lvSongSelection.Items.Clear();

            // Retrieve the updated list of songs from the Data layer
            var songs = Data.GetMusic();
            foreach (var song in songs)
            {
                ListViewItem item = new ListViewItem(song.SongID.ToString());
                item.SubItems.Add(song.SongName);
                item.SubItems.Add(song.Artist);
                item.SubItems.Add(song.Duration);
                lvSongSelection.Items.Add(item);
            }
        }

        public void RefreshListView()
        {
            lvSongSelection.Clear();
            LoadData(lvSongSelection);
        }

        public Music GetSelectedMusic()
        {
            if (lvSongSelection.SelectedItems.Count > 0)
            {
                var selectedItem = lvSongSelection.SelectedItems[0];
                int songId = int.Parse(selectedItem.Text);
                return musicList.FirstOrDefault(m => m.SongID == songId);
            }
            return null;
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopPlayback();
        }

        private void InitializeTimer()
        {
            playbackTimer = new System.Windows.Forms.Timer();
            playbackTimer.Interval = 1000; // Set the interval to 1 second
            playbackTimer.Tick += PlaybackTimer_Tick; // Attach event handler
        }

        private void cbPausePlay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPausePlay.Checked)
            {
                PausePlayback();
            }
            else
            {
                var currentSong = musicList[currentTrackIndex];
                StartPlayback(currentSong);
            }
        }

        private void StartPlayback(Music song)
        {
            try
            {
                // Ensure the SongFile stream is valid
                if (song.SongFile == null || song.SongFile.Length == 0)
                {
                    MessageBox.Show("The selected song file is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (musicList.Count > 0)
                {
                    var currentSong = musicList[currentTrackIndex];

                    lblSongName.Text = currentSong.SongName;
                    lblArtist.Text = currentSong.Artist;

                    try
                    {
                        // Reset stream position to start the song
                        currentSong.SongFile.Position = 0;

                        musicPlayer.Stream = currentSong.SongFile;
                        musicPlayer.Play();

                        // Calculate the duration in seconds
                        remainingPlaybackTime = currentSong.GetDurationInSeconds() * 1000; // Convert to milliseconds

                        playbackTimer.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error starting song: {ex.Message}", "Playback Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing song: {ex.Message}");
            }
        }

        private void PausePlayback()
        {
            if (musicPlayer.Stream != null)
            {
                musicPlayer.Stop();
                playbackTimer.Stop();
            }
        }

        public void UpdatePlayback(Music newSong)
        {
            // Ensure the new song is selected correctly
            if (newSong == null)
            {
                MessageBox.Show("Selected song is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Stop current playback
            musicPlayer.Stop();
            playbackTimer.Stop();
            remainingPlaybackTime = 0; // Reset the remaining time

            // Set the song index to the one provided
            currentTrackIndex = musicList.ToList().FindIndex(m => m.SongID == newSong.SongID);

            if (currentTrackIndex >= 0)
            {
                lblSongName.Text = musicList[currentTrackIndex].SongName;
                lblArtist.Text = musicList[currentTrackIndex].Artist;
                lblDuration.Text = musicList[currentTrackIndex].Duration;

                try
                {
                    // Start the song playback
                    musicPlayer.Stream = musicList[currentTrackIndex].SongFile;
                    musicList[currentTrackIndex].SongFile.Position = 0; // Reset position to the beginning
                    musicPlayer.Play();

                    // Update remaining playback time based on the song's duration
                    remainingPlaybackTime = musicList[currentTrackIndex].GetDurationInSeconds() * 1000; // Convert to milliseconds
                    playbackTimer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing song: {ex.Message}", "Playback Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Song not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaybackTimer_Tick(object sender, EventArgs e)
        {
            // Only update remaining time if playback is running
            if (remainingPlaybackTime > 0)
            {
                remainingPlaybackTime -= 1000;
                elapsedTimeInSeconds++;

                // Calculate the progress as a fraction of elapsed time vs total duration
                if (musicList.Count > 0)
                {
                    var currentSong = musicList[currentTrackIndex];
                    progress = (double)elapsedTimeInSeconds / currentSong.GetDurationInSeconds();
                }
            }

            if (remainingPlaybackTime <= 0)
            {
                playbackTimer.Stop();
                progress = 1.0; // Set progress to 100% when the song ends

                // Play the next song automatically
                btnForward_Click(sender, e);
            }
            // Invalidate the form to trigger the repaint and update the moving line
            this.Invalidate();
        }


        private void lvSongSelection_DoubleClick(object sender, EventArgs e)
        {
            if (lvSongSelection.SelectedItems.Count > 0 && musicList != null)
            {
                var selectedItem = lvSongSelection.SelectedItems[0];
                int songId = int.Parse(selectedItem.Text);

                Music selectedMusic = musicList.FirstOrDefault(m => m.SongID == songId);

                if (selectedMusic != null)
                {
                    UpdatePlayback(selectedMusic);
                }
                else
                {
                    MessageBox.Show("Song not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (musicList == null)
            {
                MessageBox.Show("Music list is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (musicList.Count > 0)
            {
                currentTrackIndex++;
                if (currentTrackIndex >= musicList.Count)
                {
                    currentTrackIndex = 0; // Loop back to the first track if at the end
                }

                StopPlayback();
                UpdatePlayback(musicList[currentTrackIndex]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (musicList.Count > 0)
            {
                currentTrackIndex--;
                if (currentTrackIndex < 0)
                {
                    currentTrackIndex = musicList.Count - 1; // Loop back to the last track if at the beginning
                }

                StopPlayback();
                UpdatePlayback(musicList[currentTrackIndex]);
            }
        }

        private void StopPlayback()
        {
            musicPlayer.Stop();
            playbackTimer.Stop();
            remainingPlaybackTime = 0;
            elapsedTimeInSeconds = 0; // Reset elapsed time when a new song starts
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen musicBarStart = new Pen(Color.White, 14);
            Pen musicProgressBar = new Pen(Color.FromArgb(232, 172, 161), 14);

            // Define the starting position and width for both bars
            int startX = 100;
            int startY = 550;
            int endX = 550; // end position for the bar
            int barWidth = endX - startX;

            g.DrawLine(musicBarStart, startX, startY, endX, startY);

            // Draw the progress bar based on the song's progress
            int progressWidth = (int)(progress * barWidth); // Calculate progress width
            g.DrawLine(musicProgressBar, startX, startY, startX + progressWidth, startY);

            base.OnPaint(e);
        }
    }
}