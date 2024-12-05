using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eilidh_finalproject
{
    public partial class Ambiance : UserControl
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        public Ambiance()
        {
            InitializeComponent();

            cbSun.CheckedChanged += CheckBox_CheckedChanged;
            cbRain.CheckedChanged += CheckBox_CheckedChanged;
            cbBeach.CheckedChanged += CheckBox_CheckedChanged;
            cbFire.CheckedChanged += CheckBox_CheckedChanged;
            cbSnow.CheckedChanged += CheckBox_CheckedChanged;
            cbWind.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox == null)
                return;

            // Stop any sound playing if the checkbox is unchecked
            if (!checkBox.Checked)
            {
                soundPlayer.Stop();
                cbSun.BackColor = Color.FromArgb(250, 231, 209);
                cbWind.BackColor = Color.FromArgb(250, 231, 209);
                cbRain.BackColor = Color.FromArgb(250, 231, 209);
                cbSnow.BackColor = Color.FromArgb(250, 231, 209);
                cbFire.BackColor = Color.FromArgb(250, 231, 209);
                cbBeach.BackColor = Color.FromArgb(250, 231, 209);
                return;
            }

            // Determine which sound to play
            switch (checkBox.Name)
            {
                case "cbSun":
                    soundPlayer.Stream = Properties.Resources.sun;
                    cbSun.BackColor = Color.White;
                    break;
                case "cbRain":
                    soundPlayer.Stream = Properties.Resources.rain;
                    cbRain.BackColor = Color.White;
                    break;
                case "cbFire":
                    soundPlayer.Stream = Properties.Resources.fire;
                    cbFire.BackColor = Color.White;
                    break;
                case "cbWind":
                    soundPlayer.Stream = Properties.Resources.wind;
                    cbWind.BackColor = Color.White;
                    break;
                case "cbBeach":
                    soundPlayer.Stream = Properties.Resources.beach;
                    cbBeach.BackColor = Color.White;
                    break;
                case "cbSnow":
                    soundPlayer.Stream = Properties.Resources.snow;
                    cbSnow.BackColor = Color.White;
                    break;
            }
            soundPlayer.PlayLooping();
        }
    }
}
