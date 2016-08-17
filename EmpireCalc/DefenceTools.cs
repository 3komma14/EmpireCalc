using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireCalc
{
    public class DefenceTools
    {
        protected DefenceTools(string description, double wall, double moat, double range, double melee)
        {
            Description = description;
            Wall = wall;
            Moat = moat;
            Range = range;
            Melee = melee;
        }

        public double Wall { get; set; }

        public double Moat { get; set; }

        public double Range { get; set; }

        public double Melee { get; set; }

        public string Description { get; set; }

        public static DefenceTools FourBombs = new DefenceTools("4B", 0, 110, 0, 4 * 33);
        public static DefenceTools TreeBombsOneShields = new DefenceTools("3B1S", 0, 110, 1 * 70, 3 * 33);
        public static DefenceTools TwoBombsTwoShields = new DefenceTools("2B2S", 0, 110, 2 * 70, 2 * 33);
        public static DefenceTools OneBombsThreeShields = new DefenceTools("1B3S", 0, 110, 3 * 70, 1 * 33);
        public static DefenceTools FourShields = new DefenceTools("4S", 0, 110, 4 * 70, 0 * 34);

        public static DefenceTools FourWall = new DefenceTools("4W", 4*50, 110, 0, 0);
        public static DefenceTools TreeWallOneShields = new DefenceTools("3W1S", 3*50, 110, 1 * 70, 0);
        public static DefenceTools TwoWallTwoShields = new DefenceTools("2W2S", 2*50, 110, 2 * 70, 0);
        public static DefenceTools OneWallThreeShields = new DefenceTools("1W3S", 1*50, 110, 3 * 70, 0);

        public static DefenceTools OneWallOneBomb2Shield = new DefenceTools("1W1B2S", 1 * 50, 110, 2 * 70, 1 * 33);
        public static DefenceTools OneWallTwoBomb1Shield = new DefenceTools("1W2B1S", 1 * 50, 110, 1 * 70, 2 * 33);
        public static DefenceTools TwoWallOneBomb1Shield = new DefenceTools("2W1B1S", 2 * 50, 110, 1 * 70, 1 * 33);
        
        public override string ToString()
        {
            return this.Description;
        }
    }



}
