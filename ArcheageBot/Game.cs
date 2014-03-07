using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class Game
    {
        public static bool ButtonF = false;
        public static bool ButtonG = false;

        public static void FindActionButtons()
        {
            bool FindButtonF = false;
            bool FindButtonG = false;

            for (int y = 550; y < ScreenCapture.LockBitmap.Screen.Height - 190; y++)
            {
                for (int x = 400; x < ScreenCapture.LockBitmap.Screen.Width - 400; x++)
                {
                    if (VisionForm.FindForm(VisionGame.ButtonF, x, y) != null)
                    {
                        FindButtonF = true;
                        Game.ButtonF = true;
                    }
                    if (VisionForm.FindForm(VisionGame.ButtonG, x, y) != null)
                    {
                        FindButtonG = true;
                        Game.ButtonG = true;
                    }
                }
            }

            if (FindButtonF == false)
            {
                Game.ButtonF = false;
            }

            if (FindButtonG == false)
            {
                Game.ButtonG = false;
            }
        }


    }
}
