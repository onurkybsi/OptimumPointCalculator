using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace OptimumPointCalculator
{
    
    public static class MyMethods
    {
        // Copy Transient Eq. to List of Constraints 
        public static Constraint CopyTransientToConstraints(Constraint transientEq)
        {
            Constraint constraint = new Constraint();

            constraint.Condition = transientEq.Condition;
            constraint.RHS = transientEq.RHS;
            
            foreach(Variable variable in transientEq.Variables)
            {
                constraint.Variables.Add(new Variable
                {
                    Coefficient = variable.Coefficient,
                    Index = variable.Index
                });
            }

            return constraint;
        }

        // Calculate with simplex method
        public static void CalculateWithSimplexMethod(ObjectiveFunction objectiveFunction,List<Constraint> constraints,Optimizations optimization)
        {

        }
    }
}
