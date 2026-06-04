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
    }
}
