using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bottles
{
    class Song
    {

        public String CountBottles(int a)
        {

            String Song   = "";
            String End    = " No more bottles of beer on the wall.";

            if (a == 0)
                return End;

            for (int i = a; i >= 1; i--) {

                String Counter = i.ToString();

                String Bottle = "bottle";
                if (i > 1)
                    Bottle += "s";

                if (i < a)
                    Song += " ";

                Song += Counter + " " + Bottle + " of beer on the wall.";

                // Do this one more time
                if (i < a)
                    Song += " " + Counter + " " + Bottle + " of beer on the wall.";
                        
                Song += " " + Counter + " " + Bottle + " of beer.";

                Song += " Take one down and pass it around.";

                // End here if there are no more beer
                if (i - 1 == 0) {
                    Song += End;
                }

            }

            return Song;

        }

    }

}
