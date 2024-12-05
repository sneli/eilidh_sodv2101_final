namespace eilidh_finalproject
{
    partial class CircleTimer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTimer = new Label();
            btn15min = new ButtonDesign();
            btn30min = new ButtonDesign();
            btn10min = new ButtonDesign();
            btn1hour = new ButtonDesign();
            btn5min = new ButtonDesign();
            btnEndTimer = new ButtonDesign();
            cbPausePlayTimer = new CheckBox();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.FromArgb(250, 231, 209);
            lblTimer.Font = new Font("Segoe UI Black", 34F, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(232, 172, 161);
            lblTimer.Location = new Point(104, 239);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(438, 120);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn15min
            // 
            btn15min.BackColor = Color.FromArgb(250, 231, 209);
            btn15min.ForeColor = Color.FromArgb(232, 172, 161);
            btn15min.Location = new Point(258, 668);
            btn15min.Margin = new Padding(4, 2, 4, 2);
            btn15min.Name = "btn15min";
            btn15min.Size = new Size(106, 64);
            btn15min.TabIndex = 2;
            btn15min.Text = "15 min";
            btn15min.UseVisualStyleBackColor = false;
            // 
            // btn30min
            // 
            btn30min.BackColor = Color.FromArgb(250, 231, 209);
            btn30min.ForeColor = Color.FromArgb(232, 172, 161);
            btn30min.Location = new Point(139, 668);
            btn30min.Margin = new Padding(4, 2, 4, 2);
            btn30min.Name = "btn30min";
            btn30min.Size = new Size(106, 64);
            btn30min.TabIndex = 3;
            btn30min.Text = "30 min";
            btn30min.UseVisualStyleBackColor = false;
            // 
            // btn10min
            // 
            btn10min.BackColor = Color.FromArgb(250, 231, 209);
            btn10min.ForeColor = Color.FromArgb(232, 172, 161);
            btn10min.Location = new Point(379, 668);
            btn10min.Margin = new Padding(4, 2, 4, 2);
            btn10min.Name = "btn10min";
            btn10min.Size = new Size(106, 64);
            btn10min.TabIndex = 4;
            btn10min.Text = "10 min";
            btn10min.UseVisualStyleBackColor = false;
            // 
            // btn1hour
            // 
            btn1hour.BackColor = Color.FromArgb(250, 231, 209);
            btn1hour.ForeColor = Color.FromArgb(232, 172, 161);
            btn1hour.Location = new Point(19, 668);
            btn1hour.Margin = new Padding(4, 2, 4, 2);
            btn1hour.Name = "btn1hour";
            btn1hour.Size = new Size(106, 64);
            btn1hour.TabIndex = 5;
            btn1hour.Text = "1 hour";
            btn1hour.UseVisualStyleBackColor = false;
            // 
            // btn5min
            // 
            btn5min.BackColor = Color.FromArgb(250, 231, 209);
            btn5min.ForeColor = Color.FromArgb(232, 172, 161);
            btn5min.Location = new Point(500, 668);
            btn5min.Margin = new Padding(4, 2, 4, 2);
            btn5min.Name = "btn5min";
            btn5min.Size = new Size(106, 64);
            btn5min.TabIndex = 6;
            btn5min.Text = "5 min";
            btn5min.UseVisualStyleBackColor = false;
            // 
            // btnEndTimer
            // 
            btnEndTimer.BackColor = Color.FromArgb(250, 231, 209);
            btnEndTimer.ForeColor = Color.FromArgb(232, 172, 161);
            btnEndTimer.Location = new Point(329, 752);
            btnEndTimer.Margin = new Padding(4, 2, 4, 2);
            btnEndTimer.Name = "btnEndTimer";
            btnEndTimer.Size = new Size(156, 64);
            btnEndTimer.TabIndex = 8;
            btnEndTimer.Text = "End Timer";
            btnEndTimer.UseVisualStyleBackColor = false;
            // 
            // cbPausePlayTimer
            // 
            cbPausePlayTimer.Appearance = Appearance.Button;
            cbPausePlayTimer.BackColor = Color.FromArgb(250, 231, 209);
            cbPausePlayTimer.FlatStyle = FlatStyle.Flat;
            cbPausePlayTimer.ForeColor = Color.FromArgb(232, 172, 161);
            cbPausePlayTimer.Location = new Point(139, 752);
            cbPausePlayTimer.Name = "cbPausePlayTimer";
            cbPausePlayTimer.Size = new Size(156, 64);
            cbPausePlayTimer.TabIndex = 9;
            cbPausePlayTimer.Text = "Pause Timer";
            cbPausePlayTimer.TextAlign = ContentAlignment.MiddleCenter;
            cbPausePlayTimer.UseVisualStyleBackColor = false;
            // 
            // CircleTimer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbPausePlayTimer);
            Controls.Add(btnEndTimer);
            Controls.Add(btn5min);
            Controls.Add(btn1hour);
            Controls.Add(btn10min);
            Controls.Add(btn30min);
            Controls.Add(btn15min);
            Controls.Add(lblTimer);
            Margin = new Padding(4, 2, 4, 2);
            Name = "CircleTimer";
            Size = new Size(622, 847);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private ButtonDesign btn15min;
        private ButtonDesign btn30min;
        private ButtonDesign btn10min;
        private ButtonDesign btn1hour;
        private ButtonDesign btn5min;
        private ButtonDesign btnEndTimer;
        private CheckBox cbPausePlayTimer;
    }
}
