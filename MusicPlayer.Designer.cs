namespace eilidh_finalproject
{
    partial class MusicPlayer
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
            lvSongSelection = new ListView();
            label1 = new Label();
            lblSongName = new Label();
            lblArtist = new Label();
            pictureBox1 = new PictureBox();
            btnForward = new Button();
            btnBack = new Button();
            cbPausePlay = new CheckBox();
            lblStartTime = new Label();
            lblDuration = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvSongSelection
            // 
            lvSongSelection.Location = new Point(22, 26);
            lvSongSelection.Margin = new Padding(6);
            lvSongSelection.Name = "lvSongSelection";
            lvSongSelection.Size = new Size(598, 341);
            lvSongSelection.TabIndex = 0;
            lvSongSelection.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(22, 388);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 45);
            label1.TabIndex = 1;
            label1.Text = "Now Player...";
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblSongName.Location = new Point(59, 439);
            lblSongName.Margin = new Padding(6, 0, 6, 0);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(0, 41);
            lblSongName.TabIndex = 2;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(59, 480);
            lblArtist.Margin = new Padding(6, 0, 6, 0);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(0, 32);
            lblArtist.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.circle_console;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(110, 567);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 491);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.White;
            btnForward.BackgroundImage = Properties.Resources.forward_button;
            btnForward.BackgroundImageLayout = ImageLayout.Zoom;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.ForeColor = Color.White;
            btnForward.Location = new Point(420, 768);
            btnForward.Margin = new Padding(6);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(74, 85);
            btnForward.TabIndex = 5;
            btnForward.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.BackgroundImage = Properties.Resources.back_button;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(154, 768);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(74, 85);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // cbPausePlay
            // 
            cbPausePlay.Appearance = Appearance.Button;
            cbPausePlay.BackColor = Color.White;
            cbPausePlay.BackgroundImage = Properties.Resources.pauseplay_button;
            cbPausePlay.BackgroundImageLayout = ImageLayout.Zoom;
            cbPausePlay.FlatStyle = FlatStyle.Flat;
            cbPausePlay.ForeColor = Color.White;
            cbPausePlay.Location = new Point(290, 900);
            cbPausePlay.Margin = new Padding(6);
            cbPausePlay.Name = "cbPausePlay";
            cbPausePlay.Size = new Size(74, 85);
            cbPausePlay.TabIndex = 7;
            cbPausePlay.UseVisualStyleBackColor = false;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(22, 530);
            lblStartTime.Margin = new Padding(6, 0, 6, 0);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(71, 32);
            lblStartTime.TabIndex = 8;
            lblStartTime.Text = "00:00";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(561, 529);
            lblDuration.Margin = new Padding(6, 0, 6, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(71, 32);
            lblDuration.TabIndex = 9;
            lblDuration.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(209, 220, 227);
            label2.Location = new Point(256, 655);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 57);
            label2.TabIndex = 10;
            label2.Text = "Menu";
            // 
            // MusicPlayer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 220, 227);
            ClientSize = new Size(650, 1069);
            Controls.Add(label2);
            Controls.Add(lblDuration);
            Controls.Add(lblStartTime);
            Controls.Add(cbPausePlay);
            Controls.Add(btnBack);
            Controls.Add(btnForward);
            Controls.Add(pictureBox1);
            Controls.Add(lblArtist);
            Controls.Add(lblSongName);
            Controls.Add(label1);
            Controls.Add(lvSongSelection);
            Margin = new Padding(6);
            Name = "MusicPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicPlayer";
            FormClosing += MusicPlayer_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSongSelection;
        private Label label1;
        private Label lblSongName;
        private Label lblArtist;
        private PictureBox pictureBox1;
        private Button btnForward;
        private Button btnBack;
        private CheckBox cbPausePlay;
        private Label lblStartTime;
        private Label lblDuration;
        private Label label2;
    }
}