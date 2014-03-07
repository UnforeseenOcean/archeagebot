using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ArcheageBot
{
    static class Program
    {
        public static string ArcheageWindowTitle;
        public static bool NextAction = true;
        public static int testint = 0;
        public static Thread RunOnLocation;
        public static Thread Fight;
        public static IntPtr Archeage;
        public static IntPtr ArcheageWindowHandle;

        [STAThread]
        static void Main()
        {
            /* Ищем процесс арчейджа, получаем его TITLE для того чтобы использовать в CaptureScreen */
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (process.ProcessName == "archeage")
                {
                    Program.ArcheageWindowTitle = process.MainWindowTitle;
                    Program.ArcheageWindowHandle = process.MainWindowHandle;

                }
            }

            Program.Archeage = User32.FindWindow(null, Program.ArcheageWindowTitle);

            /* Загружаем элементы интерфейса для распознавания */

            VisionHeroLocation.LoadHeroCircle();
            VisionTarget.LoadTargetBars();
            VisionEnemy.LoadEnemyBars();
            VisionHero.LoadHeroBars();
            VisionAlliance.LoadAllianceBars();
            VisionAlliance.LoadManaBars();
            VisionEnemy.LoadEnemyTooltips();
            VisionNumbers.LoadDistanceNumbers();
            VisionGame.LoadButtonF();
            VisionGame.LoadButtonG();

            Route.LoadGrindRoute("D:\\CurrentRoute.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
