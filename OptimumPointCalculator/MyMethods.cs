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

        public static void UpdateObjectiveFunctionLabel(Label label,Equation objectiveFunction)
        {
            foreach(var item in objectiveFunction.Variables)
            {
                if (item.Index==0)
                {
                    label.Text = item.DisplayMember;

                }
                else
                {
                    label.Text += "+" + item.DisplayMember;
                }
            }
        }

    }
}
