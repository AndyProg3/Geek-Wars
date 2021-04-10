using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Timers;

namespace Server
{
    public partial class Form1 : Form
    {
        public System.Timers.Timer recieve, powerUp;
        private List<String> msgQue;
        private Thread serverThread;
        private int power = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverThread = new Thread(new ThreadStart(ServerHandler.StartListening));
            serverThread.IsBackground = true;
            serverThread.Start();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            SetTimers();
        }

        private void SetTimers()
        {
            recieve = new System.Timers.Timer(500); 
            recieve.Elapsed += OnTimedEvent;
            recieve.AutoReset = true;
            recieve.Enabled = true;

            powerUp = new System.Timers.Timer(150);
            powerUp.Elapsed += powerUpEvent;
            powerUp.AutoReset = true;
            powerUp.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            msgQue = ServerHandler.msgs.ToList();
           ServerHandler.msgs.Clear();

            if (msgQue.Count > 0)
            {
                double dmg = 0;

                for (int c = 0; c < msgQue.Count; c++)
                {
                    if (msgQue[c].IndexOf("CONNECTED") <= -1)
                    {
                        dmg += Convert.ToDouble(msgQue[c].Substring(0, msgQue.IndexOf("<EOF>")));
                    }
                }

                pbHealth.Value -= Convert.ToInt32(Math.Round(dmg));
            }
        }

        private void powerUpEvent(Object source, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                power += 1;
                pbPowerUp.Value = power;

                if(power >= 100)
                {
                    //pick a random clients to destroy;
                    power = 0;
                }
            }));
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                recieve.Stop();
                powerUp.Stop();
                this.Close();
            }
        }
    }
}
