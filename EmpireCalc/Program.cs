using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new WaveCalc();

            var commander = new Commander();
            var wave1 = new Attack(commander, 20 * 20, 15 * 10, 0);
            var wave2 = new Attack(commander, 0, 15 * 10, 15 * 30);
            var wave3 = new Attack(commander, 20 * 20, 15 * 10, 0);
            var wave4 = new Attack(commander, 20 * 20, 15 * 10, 0);
            var wave5 = new Attack(commander, 0, 15 * 10, 15 * 30);
            var wave6 = new Attack(commander, 20* 10, 0, 15 * 30);

            var castle = new Castle();
            var castelan = new Castelean();
            var defenceToolsCombinations = new[]{
                DefenceTools.FourBombs,
                DefenceTools.TreeBombsOneShields,
                DefenceTools.TwoBombsTwoShields,
                DefenceTools.OneBombsThreeShields,
                DefenceTools.FourShields,
                DefenceTools.FourWall,
                DefenceTools.TreeWallOneShields,
                DefenceTools.TwoWallTwoShields,
                DefenceTools.OneWallThreeShields,
                DefenceTools.OneWallOneBomb2Shield,
                DefenceTools.OneWallTwoBomb1Shield,
                DefenceTools.TwoWallOneBomb1Shield
            };


            Console.WriteLine("Wave1: wall/moat");
            ComputeWave(calc, wave1, castle, castelan, defenceToolsCombinations);
            Console.WriteLine("Wave2: shield/moat");
            ComputeWave(calc, wave2, castle, castelan, defenceToolsCombinations);
            Console.WriteLine("Wave6: shield/wall");
            ComputeWave(calc, wave6, castle, castelan, defenceToolsCombinations);

            Console.ReadLine();
        }

        private static void ComputeWave(WaveCalc calc, Attack wave1, Castle castle, Castelean castelan, DefenceTools[] defenceToolsCombinations)
        {
            Console.Write("Setup\t");
            for (int i = 0; i <= 100; i = i + 10)
            {
                Console.Write("{0}%\t", i);
            }
            Console.Write("\r\n");

            foreach (var defenceTools in defenceToolsCombinations)
            {
                Console.Write("{0}:\t", defenceTools.ToString());
                for (int i = 0; i <= 100; i = i + 10)
                {
                    var defence = new Defence(castle, castelan, defenceTools, i);
                    var pwr = calc.Compute(defence, wave1);
                    Console.Write("{0}\t", pwr);
                }
                Console.Write("\r\n");
            }
        }
    }



    public class WaveCalc
    {
        public double Compute(Defence defence, Attack attack)
        {
            var meleePwr = defence.MeleePower(attack.MeleePercent, attack.Wall, attack.Moat);
            var rangePwr = defence.RangePower(attack.RangePercent, attack.Wall, attack.Moat, attack.Range);

            return meleePwr + rangePwr;
        }
    }
}
