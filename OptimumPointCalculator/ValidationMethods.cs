using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimumPointCalculator
{
    public static class ValidationMethods
    {
        public static bool IsThatDouble(string data)
        {
            try
            {
                Convert.ToDouble(data);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
