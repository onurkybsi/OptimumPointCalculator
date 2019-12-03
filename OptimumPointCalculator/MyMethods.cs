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
        public static void EditListIndexes(IList<Variable> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i].Index = i;
            }
        }
        public static void EditListControl(ListBox listBox, IList<Variable> list)
        {
            listBox.Items.Clear();

            for(int i=0;i<list.Count;i++)
            {
                listBox.Items.Add(list[i]);
            }
        }
        public static void EditListControl(ComboBox comboBox, IList<Variable> list)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                comboBox.Items.Add(list[i]);
            }
        }
        public static void CopyListToTarget(Equation objectiveFunction,ListBox.ObjectCollection targetList)
        {
            targetList.Clear();
            foreach(var item in objectiveFunction.Variables)
            {
                targetList.Add(item);
            }
        }
        public static void CopyListToTarget(Equation objectiveFunction,ComboBox.ObjectCollection targetList)
        {
            targetList.Clear();
            foreach(var item in objectiveFunction.Variables)
            {
                targetList.Add(item);
            }
        }
        public static void CheckTransientEq(Equation transientEquation)
        {
            foreach(var item in transientEquation.Variables)
            {
                if (double.IsPositiveInfinity(item.Coefficient)) { throw new Exception(); }
            }
        }
        public static void ClearTransientEq(Equation transientEquation)
        {
            transientEquation.RHS = 0;
            transientEquation.Condition = string.Empty;
            for (int i = 0; i < transientEquation.Variables.Count; i++)
            {
                transientEquation.Variables[i].Coefficient = double.PositiveInfinity;
            }
        }


    }
}
