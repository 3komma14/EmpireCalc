using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireCalc
{
    public class Attack
    {
        public Attack(Commander commander, double wall, double moat, double range, int soldierCount)
        {
            Wall = commander.Wall + wall; //149.6 + 200;
            Moat = commander.Moat + moat; //74 + 150;
            Range = range; //0;
            SoldierCount = soldierCount;

            RangePower = 162 * (1 + commander.Range / 100) * SoldierCount;
            MeleePower = 0;
        }

        public double Wall { get; private set; }

        public double Moat { get; private set; }

        public double Range { get; private set; }

        public double MeleePercent { get; private set; }

        public double RangePercent { get; private set; }


        public double RangePower { get; private set;}

        public double MeleePower { get; private set;}

        public double SoldierCount { get; set; }
    }
}
