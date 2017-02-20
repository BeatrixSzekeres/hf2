using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PrimeSearcher
    {
        static PrimeSearcher()
        {
            int pixel = 2; // ha a ciklus a form pixelein megy végig, ez a változó lehetne az index. A kezdőérték csak ideiglenes!!
            int oszto = 0;
            for (int i = 1; i <= pixel; i++)
            {
                if (pixel % i == 0)
                    oszto++;
                else { }
            }
            if (oszto == 2)
            {
                //a szám prím, kifestés
            }
            else
            {
                //nem prím, nincs kifestés
            }
        }
    }
}
