using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireCalc
{
    public class Attack
    {
        public Attack(Commander commander, double wall, double moat, double range)
        {
            Wall = commander.Wall + wall; //149.6 + 200;
            Moat = commander.Moat + moat; //74 + 150;
            Range = range; //0;
        }

        public double Wall { get; set; }

        public double Moat { get; set; }

        public double Range { get; set; }

        public double MeleePercent { get; set; }

        public double RangePercent { get; set; }
    }
}
