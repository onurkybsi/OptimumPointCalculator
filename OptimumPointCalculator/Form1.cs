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
        public Optimizations Optimization { get; set; }

        Equation ObjectiveFunction;

        Equation TransientEquation;

        List<Equation> Constraints;

        public Form1()
        {
            ObjectiveFunction = new Equation(new List<Variable>());
            TransientEquation = new Equation(new List<Variable>());

            Constraints = new List<Equation>();

            InitializeComponent();

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

                ObjectiveFunction.Variables.Add(new Variable { Coefficient = Convert.ToDouble(objectiveFunctionCoeffTextBox.Text), Index = ObjectiveFunction.Variables.Count });

                MessageBox.Show("Variable added!", "Adding", MessageBoxButtons.OK);

                MyMethods.CopyListToTarget(ObjectiveFunction, objectiveFunctionVariablesListBox.Items);
                MyMethods.CopyListToTarget(ObjectiveFunction, variableComboBox.Items);

                objectiveFunctionCoeffTextBox.Text = String.Empty;
                MyMethods.UpdateObjectiveFunctionLabel(objectiveFunction, this.ObjectiveFunction);

            }
            else
            {
                MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK);
            }
        }

        // Deletion variable for objective function
        private void objectiveFunctionDeleteButton_Click_1(object sender, EventArgs e)
        {
            if (objectiveFunctionVariablesListBox.SelectedIndex >= 0)
            {
                ObjectiveFunction.Variables.RemoveAt(objectiveFunctionVariablesListBox.SelectedIndex);
                MyMethods.EditListIndexes(ObjectiveFunction.Variables);

                MessageBox.Show("Variable deleted!", "Deletion", MessageBoxButtons.OK);

                MyMethods.EditListControl(objectiveFunctionVariablesListBox, ObjectiveFunction.Variables);
                MyMethods.EditListControl(variableComboBox, ObjectiveFunction.Variables);

                objectiveFunctionCoeffTextBox.Text = String.Empty;
                MyMethods.UpdateObjectiveFunctionLabel(objectiveFunction, this.ObjectiveFunction);
            }
            else
            {
                MessageBox.Show("Please select the variable to delete!", "Error", MessageBoxButtons.OK);
            }


        }

        // Optimization = Minimization 
        private void minimizationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as RadioButton;

            if (check.Checked)
                this.Optimization = Optimizations.Minimization;
        }

        // Optimization = Maximization 
        private void maximizationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as RadioButton;

            if (check.Checked)
                this.Optimization = Optimizations.Maximization;
        }

        // While the objective function changes,TransientEquation changes too.
        private void objectiveFunction_TextChanged(object sender, EventArgs e)
        {
            MyMethods.CopyListToTarget(ObjectiveFunction, TransientEquation);
        }
        
        


    }
}
