using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public class Variable
    {
        public double Coefficient { get; set; }

        public string VariableName
        {
            get
            {
                return "x" + Index.ToString();
            }
        }

        public int Index { get; set; }

    }
}
