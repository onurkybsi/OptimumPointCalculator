using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public class Variable
    {
        public double Coefficient { get; set; } = double.NaN;

        public string DisplayMember
        {
            get
            {
                return Coefficient .ToString() + "x" + (Index+1).ToString();
            }
        }

        public string DisplayMemberForVariableComboBox
        {
            get
            {
                return "x" + (Index+1).ToString();
            }
        }

        public int Index { get; set; }

    }
}
