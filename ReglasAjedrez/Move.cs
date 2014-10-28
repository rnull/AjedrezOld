using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasAjedrez
{
    public static class Move
    {
        public static bool Peon(int xO, int yO, int xD, int yD, int Color)
        {
            if (Color == 1)
            {
                if(yO == 2)
                    if ((yO + 2) == yD)
                        return true;
                if ((yO + 1) == yD)
                    return true;
            }

            if (Color == 0)
            {
                if (yO == 7)
                    if ((yO - 2) == yD)
                        return true;
                if ((yO - 1) == yD)
                    return true;
            }
            return false;
        }
    }
}
