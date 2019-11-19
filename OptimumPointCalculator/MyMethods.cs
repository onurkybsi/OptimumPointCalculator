﻿using System;
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
                list[i].Index = i + 1;
            }
        }

        public static void EditListBox(ListBox listBox, IList<Variable> list)
        {
            listBox.Items.Clear();

            for(int i=0;i<list.Count;i++)
            {
                listBox.Items.Add(list[i]);
            }
        }
    }
}
