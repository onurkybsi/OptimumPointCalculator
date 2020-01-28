using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimumPointCalculator
{
    public partial class Form1 : Form
    {
        private ObjectiveFunction ObjectiveFunction;

        private Optimizations Optimization;

        private Constraint TransientEquation;

        private List<Constraint> Constraints;

        public Form1()
        {
            ObjectiveFunction = new ObjectiveFunction();
            TransientEquation = new Constraint();
            Constraints = new List<Constraint>();

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
            int i = 0;
            // For ListBoxes
            foreach (var item in this.ObjectiveFunction.ListBoxesToBeUpdate)
            {
                item.Items.Clear();

                for (i = 0; i < this.ObjectiveFunction.Variables.Count; i++)
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

            for (i = this.TransientEquation.Variables.Count; i < this.ObjectiveFunction.Variables.Count; i++)
            {
                TransientEquation.Variables.Add(new Variable
                {
                    Index = this.ObjectiveFunction.Variables[i].Index
                });
            }
        }

        // Optimization Changed Event
        private void Optimization_Changed(object sender, EventArgs e)
        {
            if (this.Constraints.Count > 0)
            {
                MessageBox.Show("To change the optimization option, you must delete all constraints!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (maximizationRadioButton.Checked)
                {
                    comparisonComboBox.Items.Clear();
                    comparisonComboBox.Items.AddRange(new string[] { "=", "<=" });
                    this.Optimization = Optimizations.Maximization;


                }
                else if (minimizationRadioButton.Checked)
                {

                    comparisonComboBox.Items.Clear();
                    comparisonComboBox.Items.AddRange(new string[] { "=", ">=" });
                    this.Optimization = Optimizations.Minimization;

                }
            }
        }

        // Show assigned coefficient
        private void variableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (variableComboBox.SelectedIndex >= 0)
            {
                if (!double.IsPositiveInfinity(TransientEquation.Variables[variableComboBox.SelectedIndex].Coefficient) && variableComboBox.SelectedItem != null)
                    contraintsCoeffVariableTextBox.Text = TransientEquation.Variables[variableComboBox.SelectedIndex].Coefficient.ToString();
                else if (variableComboBox.SelectedItem != null)
                    contraintsCoeffVariableTextBox.Text = "0";
            }
        }

        // Assign Coefficient to Transient Eq.
        private void assignCoefficientButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(contraintsCoeffVariableTextBox.Text) && ValidationMethods.IsThatDouble(contraintsCoeffVariableTextBox.Text) && variableComboBox.SelectedItem != null)
            {
                TransientEquation.Variables[variableComboBox.SelectedIndex].Coefficient = Convert.ToDouble(contraintsCoeffVariableTextBox.Text);
                contraintsCoeffVariableTextBox.Text = string.Empty;
                variableComboBox.SelectedItem = null;
            }
            else
            {
                if (!ValidationMethods.IsThatDouble(contraintsCoeffVariableTextBox.Text))
                    MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter variable and its coefficient!", "Error", MessageBoxButtons.OK);
            }
        }

        // Add Constraint
        private void contraintsAddConstraintButton_Click(object sender, EventArgs e)
        {
            if (TransientEquation.Variables.Count >= 0)
            {
                if (comparisonComboBox.SelectedItem != null && !string.IsNullOrEmpty(rhsTextBox.Text))
                {
                    TransientEquation.Condition = comparisonComboBox.SelectedItem.ToString();
                    TransientEquation.RHS = Convert.ToDouble(rhsTextBox.Text);
                    foreach (var item in TransientEquation.Variables)
                    {
                        if (double.IsPositiveInfinity(item.Coefficient))
                        {
                            item.Coefficient = 0;
                        }
                    }


                    // COPY TRANSIENT TO CONSTRAINTS
                    this.Constraints.Add(MyMethods.CopyTransientToConstraints(TransientEquation));

                    constraintsListBox.Items.Add(TransientEquation.DisplayMemberForConstraintsEqList);

                    comparisonComboBox.SelectedItem = null;
                    rhsTextBox.Text = string.Empty;

                    foreach (var item in TransientEquation.Variables)
                    {
                        item.Coefficient = double.PositiveInfinity;
                    }
                    this.TransientEquation.Condition = string.Empty;
                    this.TransientEquation.RHS = 0;
                }
                else
                {
                    MessageBox.Show("Please enter comparison and right hand side!", "Error", MessageBoxButtons.OK);

                    comparisonComboBox.SelectedItem = null;
                    rhsTextBox.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Please enter variables!", "Eror", MessageBoxButtons.OK);
            }
        }

        // Delete Constraint
        private void deleteConstraintButton_Click(object sender, EventArgs e)
        {
            if (constraintsListBox.SelectedItem != null)
            {
                this.Constraints.RemoveAt(constraintsListBox.SelectedIndex);
                constraintsListBox.Items.RemoveAt(constraintsListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select constraint to delete!", "Error", MessageBoxButtons.OK);
            }
        }

        private void calculateOptimumPoint_Click(object sender, EventArgs e)
        {
            // Calculating method.
        }
    }
}
