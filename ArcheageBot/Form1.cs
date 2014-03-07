using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ArcheageBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScreenCaptureTimer_Tick(object sender, EventArgs e)
        {
            ScreenCapture CurrentScreen = new ScreenCapture();
            ScreenCapture.Screen = CurrentScreen.CaptureScreen();
            pictureBox1.Image = ScreenCapture.Screen;

            ScreenCapture.LockBitmap.Screen = new ScreenCapture.LockBitmap(new Bitmap(ScreenCapture.Screen));
            ScreenCapture.LockBitmap.Screen.LockBits();
            //ScreenCapture.LockBitmap.Screen.UnlockBits(); - не известно назначение, работает и без неё
        }

        private void ViewDirectionTimer_Tick(object sender, EventArgs e)
        {
            bool FastFind1 = false;
            bool FastFind2 = false;
            bool FastFind3 = false;

            /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
            if (
                ((Hero.PositionX - 5 > 0) && (Hero.PositionY - 5 > 0)) &&
                ((Hero.PositionX + 5 < ScreenCapture.LockBitmap.Screen.Width) && (Hero.PositionY + 5 < ScreenCapture.LockBitmap.Screen.Height))

            )
            {
                bool FindForm = false;
                for (int y = Hero.PositionY - 5; y < Hero.PositionY + 5; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = Hero.PositionX - 5; x < Hero.PositionX + 5; x++)
                    {
                        if (FindForm == true) { break; }

                        int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                        if (HeroCircleForm != null)
                        {
                            FastFind1 = true;
                            FindForm = true;
                            int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                            Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                            Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                            Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                        }
                    }
                }
            }


            if (FastFind1 == false)
            {
                /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
                if (
                    ((Hero.PositionX - 10 > 0) && (Hero.PositionY - 10 > 0)) &&
                    ((Hero.PositionX + 10 < ScreenCapture.LockBitmap.Screen.Width) && (Hero.PositionY + 10 < ScreenCapture.LockBitmap.Screen.Height))

                )
                {
                    bool FindForm = false;
                    for (int y = Hero.PositionY - 10; y < Hero.PositionY + 10; y++)
                    {
                        if (FindForm == true) { break; }
                        for (int x = Hero.PositionX - 10; x < Hero.PositionX + 10; x++)
                        {
                            if (FindForm == true) { break; }

                            int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                            if (HeroCircleForm != null)
                            {
                                FastFind2 = true;
                                FindForm = true;
                                int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                                Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                                Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                                Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                            }
                        }
                    }
                }
            }

            if ((FastFind1 == false) && (FastFind2 == false))
            {
                /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
                if (
                    ((Hero.PositionX - 20 > 0) && (Hero.PositionY - 20 > 0)) &&
                    ((Hero.PositionX + 20 < ScreenCapture.LockBitmap.Screen.Width) && (Hero.PositionY + 20 < ScreenCapture.LockBitmap.Screen.Height))

                )
                {
                    bool FindForm = false;
                    for (int y = Hero.PositionY - 20; y < Hero.PositionY + 20; y++)
                    {
                        if (FindForm == true) { break; }
                        for (int x = Hero.PositionX - 20; x < Hero.PositionX + 20; x++)
                        {
                            if (FindForm == true) { break; }

                            int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                            if (HeroCircleForm != null)
                            {
                                FastFind3 = true;
                                FindForm = true;
                                int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                                Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                                Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                                Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                            }
                        }
                    }
                }
            }

            /* Если не получилось быстро найти кружочек - ищем по всей карте */
            if ((FastFind1 == false) && (FastFind2 == false) && (FastFind3 == false))
            {
                bool FindForm = false;
                for (int y = 50; y < ScreenCapture.LockBitmap.Screen.Height - 300; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = 250; x < ScreenCapture.LockBitmap.Screen.Width - 50; x++)
                    {
                        if (FindForm == true) { break; }

                        int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                        if (HeroCircleForm != null)
                        {
                            FindForm = true;
                            int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                            Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                            Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                            Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                        }
                    }
                }
            }
        }

        private void TargetTimer_Tick(object sender, EventArgs e)
        {

            bool FindForm = false;

            for (int y = 100; y < 200; y++)
            {
                if (FindForm == true) { break; }
                for (int x = 0; x < ScreenCapture.LockBitmap.Screen.Width - 900; x++)
                {
                    if (FindForm == true) { break; }

                    int? TargetBarForm = VisionForm.FindForm(VisionTarget.TargetBars, x, y);
                    if (TargetBarForm != null)
                    {
                        FindForm = true;
                        Hero.Target = true;
                        int TargetBarFormNumber = TargetBarForm ?? default(int);

                        /* Определяем количество ХП у врага */
                        int EnemyHpLenght;
                        for (EnemyHpLenght = 0; EnemyHpLenght < 365; ++EnemyHpLenght)
                        {
                            if (VisionForm.FindForm(VisionEnemy.EnemyBars, x + EnemyHpLenght + 1, y + 2) != null)
                            {
                                //continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        /* Определяем дистанцию для разных типов монстров */
                        if (TargetBarFormNumber == 0)
                        {
                            /* Обычный моб */
                            Enemy.Distance = VisionNumbers.GetDistance(x + 215, y - 12);
                            Enemy.Type = "Normal";
                        }
                        else if (TargetBarFormNumber == 1)
                        {
                            /* Босс */
                            Enemy.Distance = VisionNumbers.GetDistance(x + 325, y - 12);
                            Enemy.Type = "Boss";
                        }
                        else if (TargetBarFormNumber == 2)
                        {
                            /* Слабый моб */
                            Enemy.Distance = VisionNumbers.GetDistance(x + 110, y - 12);
                            Enemy.Type = "Easy";
                        }

                        Enemy.Health = EnemyHpLenght;
                    }
                }
            }

            if (FindForm == false)
            {
                Hero.Target = false;
                Enemy.Distance = null;
                Enemy.Health = null;
            }

        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = Hero.PositionX.ToString();
            label3.Text = Hero.PositionY.ToString();
            label7.Text = Enemy.Distance.ToString();
            label6.Text = Enemy.Health.ToString();
            label8.Text = Enemy.OnScreen.ToString();
            label9.Text = Hero.Direction;
            label10.Text = Enemy.OnScreenPosition;
            label11.Text = Hero.Health.ToString();
            label12.Text = Hero.Mana.ToString();
            label13.Text = Hero.Target.ToString();
            label14.Text = Game.ButtonG.ToString();
            label16.Text = Hero.NoUpdateDirectionIteration.ToString();
            label18.Text = GrindBot.ToCoordX.ToString();
            label19.Text = GrindBot.ToCoordY.ToString();
            label17.Text = GrindBot.Direction;
            label20.Text = GrindBot.SleepRun.ToString();
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            bool FindForm = false;

            if (Hero.Target == true)
            {
                int SearchRangeX;
                if (Enemy.GlobalSearchOnScreen == true)
                {
                    SearchRangeX = 10;
                    Enemy.GlobalSearchOnScreen = false;
                }
                else
                {
                    SearchRangeX = 430;
                }

                for (int y = 10; y < ScreenCapture.LockBitmap.Screen.Height - 300; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = SearchRangeX; x < ScreenCapture.LockBitmap.Screen.Width - SearchRangeX; x++)
                    {
                        if (FindForm == true) { break; }
                        if (VisionForm.FindForm(VisionEnemy.EnemyTooltips, x, y) != null)
                        {
                            FindForm = true;
                            Enemy.OnScreen = true;

                            /* Определяем с какой границы экрана у нас полоска ХП */

                            int FindScreenLenght = ScreenCapture.LockBitmap.Screen.Width - SearchRangeX - SearchRangeX;

                            if (x < (SearchRangeX + (FindScreenLenght / 2)))
                            {
                                Enemy.OnScreenPosition = "Left";
                            }
                            else
                            {
                                Enemy.OnScreenPosition = "Right";
                            }

                        }
                    }
                }
            }
            else
            {
                Enemy.GlobalSearchOnScreen = true;
            }

            if (FindForm == false)
            {
                Enemy.OnScreen = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
        }

        private void HeroTimer_Tick(object sender, EventArgs e)
        {
            bool FindForm = false;

            for (int y = 10; y < 100; y++)
            {
                if (FindForm == true) { break; }
                for (int x = 0; x < ScreenCapture.LockBitmap.Screen.Width - 900; x++)
                {
                    if (FindForm == true) { break; }

                    if (VisionForm.FindForm(VisionHero.HeroBars, x, y) != null)
                    {
                        FindForm = true;

                        /* Определяем количество ХП у героя */
                        int HeroHpLenght;
                        for (HeroHpLenght = 0; HeroHpLenght < 255; ++HeroHpLenght)
                        {
                            if (VisionForm.FindForm(VisionAlliance.AllianceBars, x + HeroHpLenght + 1, y + 2) != null)
                            {
                                //continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Hero.Health = HeroHpLenght;

                        /* Определяем количество ХП у героя */
                        int HeroManaLenght;
                        for (HeroManaLenght = 0; HeroManaLenght < 255; ++HeroManaLenght)
                        {
                            if (VisionForm.FindForm(VisionAlliance.ManaBars, x + HeroManaLenght + 1, y + 19) != null)
                            {
                                //continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Hero.Mana = HeroManaLenght;
                    }
                }
            }

            if (FindForm == false)
            {
                Hero.Health = null;
                Hero.Mana = null;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            Game.FindActionButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            Program.testint = Program.testint + 1;
            label15.Text = Hero.Action;

            if (Program.NextAction == true)
            {
                Program.testint = 0;
                if (Hero.Action == "RunOnLocation")
                {
                    Program.NextAction = false;
                    Program.RunOnLocation = new Thread(new ThreadStart(GrindBot.RunOnLocation));
                    Program.RunOnLocation.Start();
                }
                else if (Hero.Action == "Fight")
                {
                    Program.NextAction = false;
                    Program.Fight = new Thread(new ThreadStart(GrindBot.Fight));
                    Program.Fight.Start();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hero.Action = "RunOnLocation";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hero.Action = "Stop";

            System.Threading.Thread.Sleep(1000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RouteRecordTimer.Enabled = true;
        }

        private void RouteRecordTimer_Tick(object sender, EventArgs e)
        {
            if ((Math.Abs(Hero.PositionX - RouteRecord.LastRecordCoordX) > Convert.ToInt32(textBox3.Text)) || (Math.Abs(Hero.PositionY - RouteRecord.LastRecordCoordY) > Convert.ToInt32(textBox3.Text)))
            {
                RouteRecord.LastRecordCoordX = Hero.PositionX;
                RouteRecord.LastRecordCoordY = Hero.PositionY;

                RouteRecord.GrindRoutes.Add(new Route()
                {
                    x = Convert.ToInt32(Hero.PositionX),
                    y = Convert.ToInt32(Hero.PositionY)
                });
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RouteRecordTimer.Enabled = false;

            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"C:\RecordRoute.txt"))
            {
                for (int Route = 0; Route < RouteRecord.GrindRoutes.Count; ++Route)
                {
                    GrindRouteFile.WriteLine(RouteRecord.GrindRoutes[Route].x + "," + RouteRecord.GrindRoutes[Route].y + "," + RouteRecord.GrindRoutes[Route].SleepRun);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GrindBot.SetForegroundWindow(Program.ArcheageWindowHandle);
            GrindBot.SetKeyboardState(new byte[256]);
            SendKeys.Send("W");
            Thread.Sleep(200);
        }

    }
}
