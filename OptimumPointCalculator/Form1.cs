using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimumPointCalculator
{
    public partial class Form1 : Form
    {
        List<Variable> Variables;
        public Form1()
        {
            InitializeComponent();

            Variables = new List<Variable>();
            objectiveFunction.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Adding variable for objective function
        private void objectiveFunctionAddButton_Click(object sender, EventArgs e)
        {
            if (ValidationMethods.IsThatDouble(objectiveFunctionCoeffTextBox.Text))
            {
                Variables.Add(new Variable { Coefficient = Convert.ToDouble(objectiveFunctionCoeffTextBox.Text), Index = (Variables.Count+1)});

                MessageBox.Show("Variable added!", "Adding", MessageBoxButtons.OK);

                objectiveFunctionCoeffTextBox.Text = String.Empty;
                objectiveFunctionVariablesListBox.Items.Insert((Variables.Count - 1),Variables[(Variables.Count - 1)]);
            }
            else
            {
                MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK);
            }
        }

        // Deletion variable for objective function
        private void objectiveFunctionDeleteButton_Click(object sender, EventArgs e)
        {
            Variables.RemoveAt(objectiveFunctionVariablesListBox.SelectedIndex);
            MyMethods.EditListIndexes(Variables);

            MessageBox.Show("Variable deleted!", "Deletion", MessageBoxButtons.OK);

            MyMethods.EditListBox(objectiveFunctionVariablesListBox, Variables);

            objectiveFunctionCoeffTextBox.Text = String.Empty;
        }

    }
}
