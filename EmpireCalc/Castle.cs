using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpireCalc
{
    public class Castle
    {
        public Castle()
        {
            Wall = 100;
            Moat = 20;
        }

        public double Wall { get; set; }

        public double Moat { get; set; }
    }
}
