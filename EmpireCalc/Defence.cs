using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireCalc
{
    public class Defence
    {
        public Defence(Castle castle, Castelean castelan, DefenceTools defenceTools, double defenceMeleePercent)
        {
            Wall = castle.Wall + castelan.Wall + defenceTools.Wall;
            Moat = castle.Moat + castelan.Moat + defenceTools.Moat;
            Range = 100 + castelan.Range + defenceTools.Range;
            Melee = 100 + castelan.Melee + defenceTools.Melee;
            DefenceMeleePercent = defenceMeleePercent / 100;
            DefenceRangePercent = (100 - defenceMeleePercent)/100;
            SoldierCount = 400;
        }

        public double Wall { get; set; }

        public double Moat { get; set; }

        public double Range { get; set; }

        public double Melee { get; set; }

        public double SoldierCount { get; set; }

        public double DefenceMeleePercent { get; set; }
        public double DefenceRangePercent { get; set; }

        public double MeleePower(double attackMeleePercent, double attackWall, double attackMoat)
        {
            double meleeRangePower = 75;
            double meleeMeleePower = 196;
            return (SoldierCount * DefenceMeleePercent) * meleeRangePower * MeleePowerBoost(attackWall, attackMoat);
        }

        public double RangePower(double RangePercent, double attackWall, double attackMoat, double attackRange)
        {
            double rangeRangePower = 183;
            double rangeMeleePower = 80;
            return (SoldierCount * DefenceRangePercent) * rangeRangePower * RangePowerBoost(attackWall, attackMoat, attackRange);
        }

        public double MeleePowerBoost(double attackWall, double attackMoat)
        {
            var boost = Melee + Math.Max(0, Wall - attackWall) + Math.Max(0, Moat - attackMoat);
            return boost / 100;
        }

        public double RangePowerBoost(double attackWall, double attackMoat, double attackRange)
        {
            var rangePwr = Range - attackRange;
            if (Range < attackRange)
            {
                return 0;
            }
            var boost = Math.Max(0, Range - attackRange) + Math.Max(0, Wall - attackWall) + Math.Max(0, Moat - attackMoat);
            return boost / 100; 
        }
    }
}
