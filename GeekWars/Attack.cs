using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace GeekWars
{
    class Attack : UserControl
    {
        public static double KillTime = 15000;
        public double amt { get; set; }
        public double RefreshTime { get; set; }
        public int NumRefresh { get; set; }
        public Button click { get; }
        public ProgressBar timerProgress { get; }

        public System.Timers.Timer tmrCoolDown;
        private int tmrCount = 0;
        private bool killed = false;

        public Attack(ref Button btn, ref ProgressBar pb, double amt, double RefreshTime,
                        int NumRefresh)
        {
            this.click = btn;
            this.timerProgress = pb;
            this.amt = amt;
            this.RefreshTime = RefreshTime;
            this.NumRefresh = NumRefresh;
        }
        public void start()
        {
            ClientHandler.SendAttack(amt);

            if (tmrCoolDown != null && tmrCoolDown.Enabled)
                tmrCoolDown.Stop();

            tmrCoolDown = new System.Timers.Timer(RefreshTime / NumRefresh);
            tmrCoolDown.Elapsed += CoolDown;
            tmrCoolDown.AutoReset = true;
            tmrCoolDown.Enabled = true;
            tmrCoolDown.Start();

            Console.WriteLine(RefreshTime + " : time");

            click.Enabled = false;
            timerProgress.Value = 0;
            tmrCount = 0;
        }

        public void CoolDown(Object source, ElapsedEventArgs e)
        {
            if (killed == false)
            {
                Invoke(new Action(() =>
                {
                    if (timerProgress.Value < 100)
                        timerProgress.Value = timerProgress.Value + 1;
                }));

                tmrCount++;

                if (tmrCount >= NumRefresh)
                {

                    Invoke(new Action(() =>
                    {
                        //Reset values then stop timer
                        timerProgress.Value = 100;
                        tmrCount = 0;
                        click.Enabled = true;
                    }));

                    tmrCoolDown.Stop();
                }
            }
            else
            {
                Invoke(new Action(() =>
                {
                    //Reset values then stop timer
                    timerProgress.Value = 100;
                    tmrCount = 0;
                    click.Enabled = true;
                    killed = false;
                }));

                tmrCoolDown.Stop();
            }
        }

        public void ResetTimer()
        {
            Invoke(new Action(() =>
            {
                click.Enabled = false;
                timerProgress.Value = 0;
                tmrCount = 0;
                killed = true;

                if (tmrCoolDown == null)
                {
                    Console.WriteLine("Timer null");
                    tmrCoolDown = new System.Timers.Timer(KillTime);
                    tmrCoolDown.Elapsed += CoolDown;
                    tmrCoolDown.AutoReset = true;
                    tmrCoolDown.Enabled = true;
                    tmrCoolDown.Start();
                }
                else
                {
                    Console.WriteLine("Timer reset");
                    tmrCoolDown.Stop();
                    tmrCoolDown.Interval = KillTime;
                    tmrCoolDown.Start();
                }

            }));
        }
    }
}
