using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondital
{
    public class Kondital
    {
        public static int BeregnKondital(int hvilePuls, int maxPuls)
        {
            double kondital = (maxPuls - hvilePuls) * 15.3;
            return (int)kondital;
        }
        public static double BeregnIltoptagelse(int kondital, double vægt)
        {
            double iltoptagelse = kondital * vægt / 1000;
            return Math.Round(iltoptagelse,1);
        }
    }
}
