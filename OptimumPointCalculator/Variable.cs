using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public class Variable
    {
        public double Coefficient { get; set; } = double.PositiveInfinity;

        public string DisplayMemberForVariableComboBox
        {
            get
            {
                return "x" + (Index+1).ToString();
            }
        }

        public int Index { get; set; }

        public override string ToString()
        {
            return string.Format("{0}x{1}", Coefficient, Index+1);
        }
    }
}
