using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondital
{
    public class Kondital
    {

        public static double BeregnKondital(int hvilePuls, int maxPuls)
        {
            double kondital = (maxPuls / hvilePuls) * 15.3;
            return kondital;
        }
        public static double BeregnIltoptagelse(double kondital, double vægt)
        {
            double iltoptagelse = kondital * vægt / 1000;
            return Math.Round(iltoptagelse,1);
        }
    }
}
