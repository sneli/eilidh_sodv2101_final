namespace eilidh_finalproject
{
    partial class Ambiance
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
            cbSun = new CheckBox();
            cbBeach = new CheckBox();
            cbWind = new CheckBox();
            cbRain = new CheckBox();
            cbSnow = new CheckBox();
            cbFire = new CheckBox();
            SuspendLayout();
            // 
            // cbSun
            // 
            cbSun.Appearance = Appearance.Button;
            cbSun.BackColor = Color.FromArgb(250, 231, 206);
            cbSun.BackgroundImage = Properties.Resources.sun_icon;
            cbSun.BackgroundImageLayout = ImageLayout.Zoom;
            cbSun.FlatStyle = FlatStyle.Flat;
            cbSun.ForeColor = Color.FromArgb(232, 172, 161);
            cbSun.Location = new Point(419, 29);
            cbSun.Name = "cbSun";
            cbSun.Size = new Size(120, 120);
            cbSun.TabIndex = 5;
            cbSun.UseVisualStyleBackColor = false;
            cbSun.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // cbBeach
            // 
            cbBeach.Appearance = Appearance.Button;
            cbBeach.BackColor = Color.FromArgb(250, 231, 206);
            cbBeach.BackgroundImage = Properties.Resources.beach_icon;
            cbBeach.BackgroundImageLayout = ImageLayout.Zoom;
            cbBeach.FlatStyle = FlatStyle.Flat;
            cbBeach.ForeColor = Color.FromArgb(232, 172, 161);
            cbBeach.Location = new Point(419, 186);
            cbBeach.Name = "cbBeach";
            cbBeach.Size = new Size(120, 120);
            cbBeach.TabIndex = 6;
            cbBeach.UseVisualStyleBackColor = false;
            // 
            // cbWind
            // 
            cbWind.Appearance = Appearance.Button;
            cbWind.BackColor = Color.FromArgb(250, 231, 206);
            cbWind.BackgroundImage = Properties.Resources.wind_icon;
            cbWind.BackgroundImageLayout = ImageLayout.Zoom;
            cbWind.FlatStyle = FlatStyle.Flat;
            cbWind.ForeColor = Color.FromArgb(232, 172, 161);
            cbWind.Location = new Point(223, 183);
            cbWind.Name = "cbWind";
            cbWind.Size = new Size(120, 120);
            cbWind.TabIndex = 8;
            cbWind.UseVisualStyleBackColor = false;
            // 
            // cbRain
            // 
            cbRain.Appearance = Appearance.Button;
            cbRain.BackColor = Color.FromArgb(250, 231, 206);
            cbRain.BackgroundImage = Properties.Resources.rain_icon;
            cbRain.BackgroundImageLayout = ImageLayout.Zoom;
            cbRain.FlatStyle = FlatStyle.Flat;
            cbRain.ForeColor = Color.FromArgb(232, 172, 161);
            cbRain.Location = new Point(223, 26);
            cbRain.Name = "cbRain";
            cbRain.Size = new Size(120, 120);
            cbRain.TabIndex = 7;
            cbRain.UseVisualStyleBackColor = false;
            // 
            // cbSnow
            // 
            cbSnow.Appearance = Appearance.Button;
            cbSnow.BackColor = Color.FromArgb(250, 231, 206);
            cbSnow.BackgroundImage = Properties.Resources.snow_icon;
            cbSnow.BackgroundImageLayout = ImageLayout.Zoom;
            cbSnow.FlatStyle = FlatStyle.Flat;
            cbSnow.ForeColor = Color.FromArgb(232, 172, 161);
            cbSnow.Location = new Point(29, 183);
            cbSnow.Name = "cbSnow";
            cbSnow.Size = new Size(120, 120);
            cbSnow.TabIndex = 10;
            cbSnow.UseVisualStyleBackColor = false;
            // 
            // cbFire
            // 
            cbFire.Appearance = Appearance.Button;
            cbFire.BackColor = Color.FromArgb(250, 231, 206);
            cbFire.BackgroundImage = Properties.Resources.fire_icon;
            cbFire.BackgroundImageLayout = ImageLayout.Zoom;
            cbFire.FlatStyle = FlatStyle.Flat;
            cbFire.ForeColor = Color.FromArgb(232, 172, 161);
            cbFire.Location = new Point(29, 26);
            cbFire.Name = "cbFire";
            cbFire.Size = new Size(120, 120);
            cbFire.TabIndex = 9;
            cbFire.UseVisualStyleBackColor = false;
            // 
            // Ambiance
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cbSnow);
            Controls.Add(cbFire);
            Controls.Add(cbWind);
            Controls.Add(cbRain);
            Controls.Add(cbBeach);
            Controls.Add(cbSun);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Ambiance";
            Size = new Size(566, 329);
            ResumeLayout(false);
        }

        #endregion
        private CheckBox cbSun;
        private CheckBox cbBeach;
        private CheckBox cbWind;
        private CheckBox cbRain;
        private CheckBox cbSnow;
        private CheckBox cbFire;
    }
}
