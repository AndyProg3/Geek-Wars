using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace GeekWars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Attack att1, att2, att3, att4, att5, att6;
        public static bool ValuesSent, killed;
        public static List<double> values = new List<double>();
        public System.Timers.Timer checkValues, checkKill, StartKill;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form1_FormClosing;
            Thread th = new Thread(new ThreadStart(ClientHandler.StartClient));
            th.IsBackground = true;
            th.Start();

            att1 = new Attack(ref Attack1, ref pbAttack1, 0.20, 100, 1);
            att2 = new Attack(ref Attack2, ref pbAttack2, 0.40, 500, 100);
            att3 = new Attack(ref Attack3, ref pbAttack3, 0.60, 1000, 100);
            att4 = new Attack(ref Attack4, ref pbAttack4, 0.80, 2500, 100);
            att5 = new Attack(ref Attack5, ref pbAttack5, 1, 7500, 100);
            att6 = new Attack(ref Attack6, ref pbAttack6, 2, 10000, 100);

            att1.BackColor = Color.Transparent;
            this.Controls.Add(att1);
            att2.BackColor = Color.Transparent;
            this.Controls.Add(att2);
            att3.BackColor = Color.Transparent;
            this.Controls.Add(att3);
            att4.BackColor = Color.Transparent;
            this.Controls.Add(att4);
            att5.BackColor = Color.Transparent;
            this.Controls.Add(att5);
            att6.BackColor = Color.Transparent;
            this.Controls.Add(att6);


            checkValues = new System.Timers.Timer(500);
            checkValues.Elapsed += SetValues;
            checkValues.AutoReset = true;
            checkValues.Enabled = true;
            checkValues.Start();

            checkKill = new System.Timers.Timer(1000);
            checkKill.Elapsed += triggerKill;
            checkKill.AutoReset = true;
            checkKill.Enabled = true;
            checkKill.Start();
        }

        private void Attack1_Click(object sender, EventArgs e)
        { att1.start(); }

        private void Attack2_Click(object sender, EventArgs e)
        { att2.start(); }

        private void Attack3_Click(object sender, EventArgs e)
        { att3.start();  }

        private void Attack4_Click(object sender, EventArgs e)
        { att4.start(); }

        private void Attack5_Click(object sender, EventArgs e)
        { att5.start(); }

        private void Attack6_Click(object sender, EventArgs e)
        { att6.start(); }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void triggerKill(Object source, ElapsedEventArgs e)
        {
            if (killed == true)
            {
                Console.WriteLine("Killing...");
                att1.ResetTimer();
                att2.ResetTimer();
                att3.ResetTimer();
                att4.ResetTimer();
                att5.ResetTimer();
                att6.ResetTimer();
                killed = false;

                StartKill = new System.Timers.Timer(1000);
                StartKill.Elapsed += killedTimer;
                StartKill.AutoReset = true;
                StartKill.Enabled = true;
                StartKill.Start();

                Invoke(new Action(() =>
                {
                    lblKilled.Visible = true;
                    lblKilled.Text = "You've been killed. Revive in 15 seconds";
                }));
            }
        }

        private int killCount = 0;

        public void killedTimer(Object source, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblKilled.Visible = true;
                lblKilled.Text = "You've been killed. Revive in " + (14 - killCount) + " seconds";


                killCount++;

                if(killCount >= 15)
                {
                    killCount = 0;

                    lblKilled.Visible = false;
                    StartKill.Stop();
                }
            }));
        }

        public void SetValues(Object source, ElapsedEventArgs e)
        {
            if (ValuesSent == true)
            {
                Invoke(new Action(() =>
                {
                    if (values.Count >= 1)
                    {
                        att1.amt = values[0];
                        att1.click.Text = String.Format("{0:0.00}", values[0]) + " dmg";
                    }

                    if (values.Count >= 2)
                    {
                        att2.amt = values[1];
                        att2.click.Text = String.Format("{0:0.00}", values[1]) + " dmg";
                    }

                    if (values.Count >= 3)
                    {
                        att3.amt = values[2];
                        att3.click.Text = String.Format("{0:0.00}", values[2]) + " dmg";
                    }

                    if (values.Count >= 4)
                    {
                        att4.amt = values[3];
                        att4.click.Text = String.Format("{0:0.00}", values[3]) + " dmg";
                    }

                    if (values.Count >= 5)
                    {
                        att5.amt = values[4];
                        att5.click.Text = String.Format("{0:0.00}", values[4]) + " dmg";

                    }

                    if (values.Count >= 6)
                    {
                        att6.amt = values[5];
                        att6.click.Text = String.Format("{0:0.00}", values[5]) + " dmg";

                    }
                }));

                ValuesSent = false;
                checkValues.Stop();
            }
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(checkValues != null && checkValues.Enabled)
                checkValues.Stop();
            if (checkKill != null && checkKill.Enabled)
                checkKill.Stop();
            if (StartKill != null && StartKill.Enabled)
                StartKill.Stop();

            if (att1.tmrCoolDown != null && att1.tmrCoolDown.Enabled)
                att1.tmrCoolDown.Stop();
            if (att2.tmrCoolDown != null && att2.tmrCoolDown.Enabled)
                att2.tmrCoolDown.Stop();
            if (att3.tmrCoolDown != null && att3.tmrCoolDown.Enabled)
                att3.tmrCoolDown.Stop();
            if (att4.tmrCoolDown != null && att4.tmrCoolDown.Enabled)
                att4.tmrCoolDown.Stop();
            if (att5.tmrCoolDown != null && att5.tmrCoolDown.Enabled)
                att5.tmrCoolDown.Stop();
            if (att6.tmrCoolDown != null && att6.tmrCoolDown.Enabled)
                att6.tmrCoolDown.Stop();
        }
    }
}
