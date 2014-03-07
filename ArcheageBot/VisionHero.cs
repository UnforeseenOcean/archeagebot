using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionHero
    {
        public static List<List<VisionForm>> HeroBars = new List<List<VisionForm>>();

        public static void LoadHeroBars()
        {
            /* Заливаем пиксели в переменные, так как форма имеет однообразный цвет */

            int ObjectMaxR = 70;
            int ObjectMinR = 50;
            int ObjectMaxG = 55;
            int ObjectMinG = 35;
            int ObjectMaxB = 30;
            int ObjectMinB = 10;

            int ManaBarMaxR = 50;
            int ManaBarMinR = 0;
            int ManaBarMaxG = 40;
            int ManaBarMinG = 0;
            int ManaBarMaxB = 30;
            int ManaBarMinB = 0;

            List<VisionForm> HeroBar1 = new List<VisionForm>
            {
                /* Определяем что нет буквы М */
                new VisionForm(){
                    OffsetX = 254, 
                    OffsetY = -6, 
                    MaxR = 250,
                    MinR = 0,
                    MaxG = 250,
                    MinG = 0,
                    MaxB = 250,
                    MinB = 0,
                },


                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 248, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 249, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },


                /* Полоса хп над маной */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },

            };

            VisionHero.HeroBars.Add(HeroBar1);

        }
    }
}
