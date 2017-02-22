using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PrimeSearcher
    {
        public static string PrimeS(int szam)
        {
         
            bool prim_e;
            int oszto = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                    oszto++;
            }
            if (oszto == 2)
            {
                prim_e = true;
            }
            else
                prim_e = false;

            if (prim_e == true)
                return ("Prím");
            else
                return ("Nem prím");


        }
    }
}
