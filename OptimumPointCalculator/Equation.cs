using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public abstract class Equation
    {
        public Equation()
        {
            Variables = new List<Variable>();
        }
        public List<Variable> Variables { get; }
        public double RHS { get; set; }
        public string Condition { get; set; }
        
    }
}
