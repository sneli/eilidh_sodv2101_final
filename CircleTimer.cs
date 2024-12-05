using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace eilidh_finalproject
{
    public partial class CircleTimer : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private TimeSpan timeLeft;
        private TimeSpan totalTime;
        private SoundPlayer soundPlayer;
        private bool isPaused;

        public CircleTimer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 335;
            this.Height = 375;

            InitializeTimer();
            InitializeSound();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            btn1hour.Click += (s, e) => StartTimer(TimeSpan.FromHours(1));
            btn30min.Click += (s, e) => StartTimer(TimeSpan.FromMinutes(30));
            btn15min.Click += (s, e) => StartTimer(TimeSpan.FromMinutes(15));
            btn10min.Click += (s, e) => StartTimer(TimeSpan.FromMinutes(10));
            btn5min.Click += (s, e) => StartTimer(TimeSpan.FromMinutes(1));

            cbPausePlayTimer.CheckStateChanged += (s, e) => TogglePauseResume();
            btnEndTimer.Click += (s, e) => StopTimer();
        }

        private void InitializeSound()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.timer_end_bells);
        }

        public void ResetTimer()
        {
            timer.Stop();
            timeLeft = TimeSpan.Zero;
            totalTime = TimeSpan.Zero;
            lblTimer.Text = "00:00:00";
            Invalidate();
        }

        private void StartTimer(TimeSpan duration)
        {
            totalTime = duration;
            timeLeft = duration;
            lblTimer.Text = FormatTime(timeLeft);
            timer.Start();
            isPaused = false;
            cbPausePlayTimer.Checked = false;
        }

        private void TogglePauseResume()
        {
            if (cbPausePlayTimer.Checked)
            {
                PauseTimer();
                cbPausePlayTimer.Text = "Play Timer";
            }
            else
            {
                ResumeTimer();
                cbPausePlayTimer.Text = "Pause Timer";
            }
        }

        private void PauseTimer()
        {
            if (timer.Enabled)
            {
                timer.Stop();
                isPaused = true;
            }
        }

        private void ResumeTimer()
        {
            if (isPaused)
            {
                timer.Start();
                isPaused = false;
            }
        }

        private void StopTimer()
        {
            ResetTimer();
            isPaused = false;
            cbPausePlayTimer.Checked = false; // Uncheck the pause checkbox
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                lblTimer.Text = FormatTime(timeLeft);
                Invalidate(); // Redraw the circle to reflect progress
            }
            else
            {
                timer.Stop();
                lblTimer.Text = "00:00:00";
                ResetTimer();
                PlaySound();
            }
        }

        private void PlaySound()
        {
            for (int i = 0; i < 3; i++)
            {
                soundPlayer.PlaySync(); // Synchronously plays the sound
            }
        }

        private string FormatTime(TimeSpan time)
        {
            return $"{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color fae7d1 = Color.FromArgb(250, 231, 209);
            Color e8aca1 = Color.FromArgb(232, 172, 161);
            Pen timerOutlineStart = new Pen(Color.FromArgb(232, 172, 161), 8);
            Pen timerOutlineEnd = new Pen(Color.White, 10);

            using (Brush brush = new SolidBrush(fae7d1))
            {
                e.Graphics.FillEllipse(brush, 30, 10, 576, 576);
            }

            g.DrawEllipse(timerOutlineStart, 30, 10, 576, 576);

            if (totalTime.TotalSeconds > 0)
            {
                double progress = 1 - (timeLeft.TotalSeconds / totalTime.TotalSeconds);
                int sweepAngle = (int)(progress * 360);

                g.DrawArc(timerOutlineEnd, 30, 10, 576, 576, -90, sweepAngle);
            }

            base.OnPaint(e);
        }
    }
}
