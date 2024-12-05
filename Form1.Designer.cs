namespace eilidh_finalproject
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
            circleTimer1 = new CircleTimer();
            ambiance1 = new Ambiance();
            btnHelp = new Button();
            btnToDo = new Button();
            btnOpenMusic = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtAddSongName = new TextBox();
            txtAddArtist = new TextBox();
            txtAddDuration = new TextBox();
            btnFindFile = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            lblFileName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // circleTimer1
            // 
            circleTimer1.Location = new Point(48, 35);
            circleTimer1.Margin = new Padding(2, 0, 2, 0);
            circleTimer1.Name = "circleTimer1";
            circleTimer1.Size = new Size(620, 835);
            circleTimer1.TabIndex = 1;
            // 
            // ambiance1
            // 
            ambiance1.BackColor = Color.White;
            ambiance1.Location = new Point(737, 21);
            ambiance1.Margin = new Padding(4, 2, 4, 2);
            ambiance1.Name = "ambiance1";
            ambiance1.Size = new Size(566, 329);
            ambiance1.TabIndex = 2;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(250, 231, 209);
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.FromArgb(232, 172, 161);
            btnHelp.Location = new Point(1151, 796);
            btnHelp.Margin = new Padding(6);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(152, 64);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnToDo
            // 
            btnToDo.BackColor = Color.FromArgb(250, 231, 209);
            btnToDo.FlatStyle = FlatStyle.Flat;
            btnToDo.ForeColor = Color.FromArgb(232, 172, 161);
            btnToDo.Location = new Point(15, 13);
            btnToDo.Margin = new Padding(6);
            btnToDo.Name = "btnToDo";
            btnToDo.Size = new Size(152, 64);
            btnToDo.TabIndex = 5;
            btnToDo.Text = "To-Do List";
            btnToDo.UseVisualStyleBackColor = false;
            btnToDo.Click += btnToDo_Click;
            // 
            // btnOpenMusic
            // 
            btnOpenMusic.BackColor = Color.FromArgb(250, 231, 209);
            btnOpenMusic.FlatStyle = FlatStyle.Flat;
            btnOpenMusic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpenMusic.ForeColor = Color.FromArgb(232, 172, 161);
            btnOpenMusic.Location = new Point(988, 796);
            btnOpenMusic.Margin = new Padding(6);
            btnOpenMusic.Name = "btnOpenMusic";
            btnOpenMusic.Size = new Size(152, 64);
            btnOpenMusic.TabIndex = 7;
            btnOpenMusic.Text = "Music";
            btnOpenMusic.UseVisualStyleBackColor = false;
            btnOpenMusic.Click += btnOpenMusic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(737, 380);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 384);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(232, 172, 161);
            label1.Location = new Point(747, 390);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 51);
            label1.TabIndex = 9;
            label1.Text = "Modify Playlist";
            // 
            // txtAddSongName
            // 
            txtAddSongName.Location = new Point(747, 450);
            txtAddSongName.Margin = new Padding(6);
            txtAddSongName.Name = "txtAddSongName";
            txtAddSongName.PlaceholderText = "Song Name";
            txtAddSongName.Size = new Size(544, 39);
            txtAddSongName.TabIndex = 10;
            // 
            // txtAddArtist
            // 
            txtAddArtist.Location = new Point(747, 512);
            txtAddArtist.Margin = new Padding(6);
            txtAddArtist.Name = "txtAddArtist";
            txtAddArtist.PlaceholderText = "Artist";
            txtAddArtist.Size = new Size(544, 39);
            txtAddArtist.TabIndex = 11;
            // 
            // txtAddDuration
            // 
            txtAddDuration.Location = new Point(747, 574);
            txtAddDuration.Margin = new Padding(6);
            txtAddDuration.Name = "txtAddDuration";
            txtAddDuration.PlaceholderText = "Duration";
            txtAddDuration.Size = new Size(544, 39);
            txtAddDuration.TabIndex = 12;
            // 
            // btnFindFile
            // 
            btnFindFile.Location = new Point(747, 636);
            btnFindFile.Margin = new Padding(6);
            btnFindFile.Name = "btnFindFile";
            btnFindFile.Size = new Size(175, 49);
            btnFindFile.TabIndex = 13;
            btnFindFile.Text = "Find File (.wav)";
            btnFindFile.UseVisualStyleBackColor = true;
            btnFindFile.Click += btnFindFile_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(951, 695);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 49);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(800, 695);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 49);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1101, 695);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 49);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblFileName
            // 
            lblFileName.BackColor = Color.White;
            lblFileName.Location = new Point(932, 644);
            lblFileName.Margin = new Padding(6, 0, 6, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(362, 41);
            lblFileName.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 220, 227);
            ClientSize = new Size(1324, 879);
            Controls.Add(lblFileName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnFindFile);
            Controls.Add(txtAddDuration);
            Controls.Add(txtAddArtist);
            Controls.Add(txtAddSongName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnOpenMusic);
            Controls.Add(btnToDo);
            Controls.Add(btnHelp);
            Controls.Add(ambiance1);
            Controls.Add(circleTimer1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SODV2101 Final Project";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CircleTimer circleTimer1;
        private Ambiance ambiance1;
        private Button btnHelp;
        private Button btnToDo;
        private Button btnOpenMusic;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtAddSongName;
        private TextBox txtAddArtist;
        private TextBox txtAddDuration;
        private Button btnFindFile;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblFileName;
    }
}
