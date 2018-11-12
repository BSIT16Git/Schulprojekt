using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FormsInvaders
{
    public partial class FormMainForm : Form
    {
        int Frames = 0;
        int PlayerSpeed = 15;
        int EnemySpeed = 1;
        int ShotSpeed = 2;
        int MaxEnemys = 5;
        int MaxShots = 15;

        int DeadYuecels = 0;
        int FreeYuecels = 0;
        //Lower = Faster Spawn
        int EnemySpawnRate = 100;
        List<Label> EnemyList = new List<Label>();
        List<Label> ShotList = new List<Label>();

        bool KeydownRight = false;
        bool KeydownLeft = false;
        bool KeydownFire = false;
        bool GameEnd = false;

        public FormMainForm()
        {
            InitializeComponent();
        }

        private void FormMainForm_Shown(object sender, EventArgs e)
        {
            //Ini Stuff:
            InitStats();

            //Update Loop:
            System.Timers.Timer FPSTicker = new System.Timers.Timer(1000);
            FPSTicker.Elapsed += FPSTicker_Elapsed;
            FPSTicker.Enabled = true;
            while (!GameEnd)
            {
                Update();
                Thread.Sleep(10);
            }
        }

        private void InitStats()
        {
            labelShotsLeft.Text = "Shots left: " + (MaxShots - ShotList.Count).ToString();
            labelDeadYücels.Text = "Dead Yücel's: 0";
            labelFreeYücels.Text = "Free Yücel's: 0";
        }

        private void FPSTicker_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Text = "FormsInvaders  FPS: " + Frames;
                });
            }
            catch
            {
                Environment.Exit(-1);
            }
            Frames = 0;
        }

        //Called once per Frame
        private void Update()
        {
            //framecount
            Frames++;

            //key handling
            if (KeydownRight)
            {
                player.Location = new Point(player.Location.X + PlayerSpeed, player.Location.Y);
                KeydownRight = false;
            }
            if (KeydownLeft)
            {
                player.Location = new Point(player.Location.X - PlayerSpeed, player.Location.Y);
                KeydownLeft = false;
            }
            if (KeydownFire)
            {
                //Shots
                //Shots Spawn
                if (ShotList.Count < MaxShots)
                {
                    
                        Label NewShots = new Label();
                        NewShots.Text = "Pew";
                        NewShots.Location = player.Location;
                        NewShots.AutoSize = true;
                        NewShots.Show();
                        this.Controls.Add(NewShots);
                        NewShots.Show();
                        NewShots.BringToFront();
                        ShotList.Add(NewShots);
                    
                }
                labelShotsLeft.Text = "Shots left: " + (MaxShots - ShotList.Count).ToString();
                KeydownFire = false;
            }

            List<Label> ShotsToDelete = new List<Label>();
            //Shots Movement && Deletion
            foreach (Label Shot in ShotList)
            {
                Shot.Location = new Point(Shot.Location.X, Shot.Location.Y - ShotSpeed);
                if (Shot.Location.Y < 0)
                {
                    this.Controls.Remove(Shot);
                    ShotsToDelete.Add(Shot);
                }
            }
            //Remove Useless Shots to rescue Resources
            foreach (Label UselessShot in ShotsToDelete)
            {
                ShotList.Remove(UselessShot);
            }


            //Enemys Spawn
            Random Rand = new Random();
            if (EnemyList.Count < MaxEnemys)
            {
                if (Rand.Next(1, 100) == 1)
                {
                    Label NewLabel = new Label();
                    NewLabel.Text = "Yücel";
                    NewLabel.Location = new Point(Rand.Next(1, this.Width - 200), 5);
                    NewLabel.AutoSize = true;
                    NewLabel.Show();
                    this.Controls.Add(NewLabel);
                    NewLabel.Show();
                    NewLabel.BringToFront();
                    EnemyList.Add(NewLabel);
                }
            }
            List<Label> ToDelete = new List<Label>();

            //Collision Detection:
            foreach (Label Enemy in EnemyList)
            {

                foreach (Label Shot in ShotList)
                {
                    if (Enemy.Bounds.IntersectsWith(Shot.Bounds))
                    {
                        DeadYuecels++;
                        Enemy.Text = "Dead Yücel";
                        ToDelete.Add(Enemy);
                    }
                }
            }
            //Enemys Movement && Deletion
            foreach (Label Enemy in EnemyList)
            {
                Enemy.Location = new Point(Enemy.Location.X, Enemy.Location.Y + EnemySpeed);
                if (Enemy.Location.Y >= this.Height)
                {
                    FreeYuecels++;
                    this.Controls.Remove(Enemy);
                    ToDelete.Add(Enemy);
                }
            }
            //Remove Useless Enemys to rescue Resources
            foreach (Label UselessEnemy in ToDelete)
            {
                EnemyList[EnemyList.IndexOf(UselessEnemy)].Visible = false;
                EnemyList[EnemyList.IndexOf(UselessEnemy)].Dispose();
                EnemyList.Remove(UselessEnemy);
            }

            labelDeadYücels.Text = "Dead Yücel's: " + DeadYuecels;
            labelShotsLeft.Text = "Shots left: " + (MaxShots - ShotList.Count).ToString();
            labelFreeYücels.Text = "Free Yücel's: " + FreeYuecels;

            if (FreeYuecels >= 5)
            {
                panelLost.Dock = DockStyle.Fill;
                panelLost.Visible = true;
                panelLost.BringToFront();
                GameEnd = true;
            }
            if (DeadYuecels >= 100 && FreeYuecels <= 0)
            {
                panelWin.Dock = DockStyle.Fill;
                panelWin.Visible = true;
                panelWin.BringToFront();
                GameEnd = true;
            }

            Application.DoEvents();
        }

        private void FormMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                KeydownRight = true;
            else if (e.KeyCode == Keys.Left)
                KeydownLeft = true;
            else if (e.KeyCode == Keys.Space)
                KeydownFire = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}