using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HackedWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string message = "Created by SpeediBoi. Coded with C#";
            string title = "Hacked Windows";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            InitializeComponent();
            Player.uiMode = "none";
            this.TopMost = true;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            Player.settings.volume = 100;
            Player.TabStop = false;
            checking();
        }

        private async void checking()
        {
        Check:
            if (Player.fullScreen == true)
            {
                Player.fullScreen = false;
            }
            await Task.Delay(200);
            goto Check;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
            ApplicationExitTimer.Enabled = true;
        }



        private void ApplicationExitTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }
    }
}
