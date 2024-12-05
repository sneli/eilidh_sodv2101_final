namespace eilidh_finalproject
{
    public partial class Form1 : Form
    {
        private Stream selectedFilePath;
        private string tempFilePath;
        private MusicPlayer musicPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer" +
                            "\nSelect an option from the 5 buttons below. There are options for 1 hour, 30 minutes, 15 minutes, 10 minutes, or 5 minutes!" +
                            "\n\nMusic" +
                            "\nTo play music, click on the 'Music' button. Double click a song from the list to start the audio." +
                            "\n\nAmbience Control" +
                            "\nOne at a time, you can click a button on or off to best specify your white noise preference!" +
                            "\n\nTo-do list" +
                            "\nTo operate the To-do list, simply click the To-Do button. There, you can add any tasks you'd like to complete during your study session.");
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            ToDoList toDoList = new ToDoList();
            toDoList.Show();
        }

        private void btnOpenMusic_Click(object sender, EventArgs e)
        {
            if (musicPlayer == null || musicPlayer.IsDisposed)
            {
                musicPlayer = new MusicPlayer();
                musicPlayer.Show();
            }
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Audio Files|*.mp3;*.wav;*.flac|All Files|*.*";
                ofd.Title = "Select an Audio File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath?.Dispose();
                    selectedFilePath = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    tempFilePath = Path.Combine(Application.StartupPath, "Temp", Path.GetFileName(ofd.FileName));
                    Directory.CreateDirectory(Path.GetDirectoryName(tempFilePath));

                    using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        selectedFilePath.CopyTo(fileStream); // Copy the contents of the stream to the temporary file
                    }

                    lblFileName.Text = $"{Path.GetFileName(ofd.FileName)}";
                    lblFileName.ForeColor = System.Drawing.Color.FromArgb(232, 172, 161);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string songName = txtAddSongName.Text;
            string artist = txtAddArtist.Text;
            string duration = txtAddDuration.Text;

            if (string.IsNullOrEmpty(songName) || string.IsNullOrEmpty(artist) || string.IsNullOrEmpty(duration))
            {
                MessageBox.Show("Please fill in all fields before adding a song.");
                return;
            }

            if (selectedFilePath == null || string.IsNullOrEmpty(tempFilePath))
            {
                MessageBox.Show("Please select a file for the song.");
                return;
            }

            // Retrieve existing songs to determine the next available SongID
            var songs = Data.GetMusic();
            int nextId = songs.Any() ? songs.Max(s => s.SongID) + 1 : 1;

            // Create a new Music object
            Music newSong = new Music
            {
                SongID = nextId, // Assign the next available ID
                SongName = songName,
                Artist = artist,
                Duration = duration,
                SongFile = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read)
            };

            Data.AddMusic(newSong);

            MessageBox.Show("Song added successfully!");
            ClearFields();
            lblFileName.Text = "";

            if (musicPlayer != null && !musicPlayer.IsDisposed)
            {
                musicPlayer.RefreshListView();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string songName = txtAddSongName.Text;

            if (string.IsNullOrEmpty(songName))
            {
                MessageBox.Show("Please enter the name of the song you want to update.");
                return;
            }

            var existingSong = Data.GetMusic().FirstOrDefault(s => s.SongName.Equals(songName, StringComparison.OrdinalIgnoreCase));

            if (existingSong != null)
            {
                existingSong.Artist = txtAddArtist.Text;
                existingSong.Duration = txtAddDuration.Text;

                if (selectedFilePath != null)
                {
                    existingSong.SongFile = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read);
                }

                MessageBox.Show("Song updated successfully!");
                ClearFields(); 
                musicPlayer.RefreshListView();

            }
            else
            {
                MessageBox.Show("Song not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string songName = txtAddSongName.Text;

            if (string.IsNullOrEmpty(songName))
            {
                MessageBox.Show("Please enter the name of the song you want to delete.");
                return;
            }

            var existingSong = Data.GetMusic().FirstOrDefault(s => s.SongName.Equals(songName, StringComparison.OrdinalIgnoreCase));

            if (existingSong != null)
            {
                existingSong.SongFile?.Dispose();
                Data.DeleteMusic(existingSong.SongID);

                MessageBox.Show("Song deleted successfully!");
                ClearFields();
                musicPlayer.RefreshListView();
            }
            else
            {
                MessageBox.Show("Song not found.");
            }
        }

        private void ClearFields()
        {
            txtAddSongName.Clear();
            txtAddArtist.Clear();
            txtAddDuration.Clear();

            // Dispose of the current file stream if it's not null
            selectedFilePath?.Dispose();
            selectedFilePath = null;
            tempFilePath = null;
        }
    }
}
