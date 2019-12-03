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
        private Optimizations optimizations = Optimizations.Unspecified;
        public Optimizations Optimization
        {
            get
            {
                return optimizations;
            }
            set
            {
                if (value == Optimizations.Maximization)
                {
                    comparisonComboBox.Items.Clear();
                    comparisonComboBox.Items.AddRange(new string[] { "=","<="});
                    optimizations = Optimizations.Maximization;
                }
                else if(value == Optimizations.Minimization)
                {
                    comparisonComboBox.Items.Clear();
                    comparisonComboBox.Items.AddRange(new string[] { "=", ">=" });
                    optimizations = Optimizations.Minimization;
                }
            }
        }
        
        private Equation ObjectiveFunction;

        private Equation TransientEquation;

        private List<Equation> Constraints;

        public Form1()
        {
            ObjectiveFunction = new Equation();
            Constraints = new List<Equation>();

            this.ObjectiveFunction.EventOfUpdate += ObjectiveFunction_EventOfUpdate;

            InitializeComponent();

            this.ObjectiveFunction.ListBoxesToBeUpdate.Add(objectiveFunctionVariablesListBox);
            this.ObjectiveFunction.LabelsToBeUpdate.Add(objectiveFunction);

            objectiveFunctionVariablesListBox.DisplayMember = "Variable";
            objectiveFunction.Text = string.Empty;
        }

        // Adding variable for objective function
        private void objectiveFunctionAddButton_Click(object sender, EventArgs e)
        {
            if (ValidationMethods.IsThatDouble(objectiveFunctionCoeffTextBox.Text))
            {
                ObjectiveFunction.AddElementWithUpdateProcess(new Variable { Coefficient = Convert.ToDouble(objectiveFunctionCoeffTextBox.Text), Index = ObjectiveFunction.Variables.Count });

                objectiveFunctionCoeffTextBox.Text = String.Empty;
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
                ObjectiveFunction.DeleteElementWithUpdateProcess(objectiveFunctionVariablesListBox.SelectedIndex);

                objectiveFunctionCoeffTextBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Please select the variable to delete!", "Error", MessageBoxButtons.OK);
            }

        }

        //Update event
        private void ObjectiveFunction_EventOfUpdate()
        {
            // For ListBoxes
            foreach (var item in this.ObjectiveFunction.ListBoxesToBeUpdate)
            {
                item.Items.Clear();

                for (int i = 0; i < this.ObjectiveFunction.Variables.Count; i++)
                {
                    ObjectiveFunction.Variables[i].Index = i;

                    item.Items.Insert(i, this.ObjectiveFunction.Variables[i]);
                }
            }

            // For Labels
            foreach (var item in this.ObjectiveFunction.Variables)
            {
                if (item.Index == 0)
                {
                    objectiveFunction.Text = item.ToString();
                }
                else
                {
                    objectiveFunction.Text += "+" + item.ToString();
                }
            }

            // For ComboBoxes
            variableComboBox.Items.Clear();
            foreach (var item in this.ObjectiveFunction.Variables)
            {
                variableComboBox.Items.Add(item);
            }
        }

        // Optimization Changed Event
        private void Optimization_Changed(object sender, EventArgs e)
        {
            if (maximizationRadioButton.Checked)
                this.Optimization = Optimizations.Maximization;
            else if (minimizationRadioButton.Checked)
                this.Optimization = Optimizations.Minimization;
        }

        // While the objective function changes,TransientEquation changes too.
        private void objectiveFunction_TextChanged(object sender, EventArgs e)
        {
        }

        // Assign variables to TransientEquation
        private void assignCoefficient_Click(object sender, EventArgs e)
        {
           
        }

        private void contraintsAddConstraintButton_Click(object sender, EventArgs e)
        {

        }

    }
}
