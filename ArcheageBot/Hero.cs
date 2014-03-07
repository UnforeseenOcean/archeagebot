using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ArcheageBot
{
    class Hero
    {
        public static int? Health = null;
        public static int? Mana = null;
        public static int PositionX;
        public static int PositionY;
        public static string Direction;
        public static int NoUpdateDirectionIteration = 0;
        public static bool ForceUpdateDirection;
        public static bool Target = false;
        public static string Action = "Start ArcheageBot";


    }
}
