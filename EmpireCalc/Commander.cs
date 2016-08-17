using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireCalc
{
    public class Commander
    {
        public Commander()
        {
            Wall = 149.6;
            Moat = 74;
            Gate = 0;
            Range = 90;
            Melee = 90;
        }

        public double Wall { get; set; }

        public double Moat { get; set; }

        public double Gate { get; set; }

        public double Melee { get; set; }

        public double Range { get; set; }
    }
}
