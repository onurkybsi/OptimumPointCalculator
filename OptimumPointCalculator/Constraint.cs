using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public class Constraint : Equation
    {
        public string DisplayMemberForConstraintsEqList
        {
            get
            {
                string result = string.Empty;
                for (int i = 0; i < this.Variables.Count; i++)
                {
                    if (i==0)
                        result += this.Variables[i].Coefficient.ToString() + "x" + (this.Variables[i].Index + 1).ToString() + "+";
                    else if(i==this.Variables.Count-1)
                        result += this.Variables[i].Coefficient.ToString() + "x" + (this.Variables[i].Index + 1).ToString();
                    else
                        result += this.Variables[i].Coefficient.ToString() + "x" + (this.Variables[i].Index + 1).ToString() + "+";
                }

                result += this.Condition + this.RHS.ToString();

                return result;
            }
        }
    }
}
