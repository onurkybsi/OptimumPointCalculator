namespace OptimumPointCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectiveFunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.maximizationRadioButton = new System.Windows.Forms.RadioButton();
            this.minimizationRadioButton = new System.Windows.Forms.RadioButton();
            this.objectiveFunction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.objectiveFunctionDeleteButton = new System.Windows.Forms.Button();
            this.objectiveFunctionVariablesListBox = new System.Windows.Forms.ListBox();
            this.objectiveFunctionAddButton = new System.Windows.Forms.Button();
            this.objectiveFunctionCoeffTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.constraintsFunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteConstraint = new System.Windows.Forms.Button();
            this.constraintsListBox = new System.Windows.Forms.ListBox();
            this.contraintsAddConstraintButton = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comparisonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.variableComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contraintsVariableDeleteButton = new System.Windows.Forms.Button();
            this.contraintsVariableListBox = new System.Windows.Forms.ListBox();
            this.constraintsVariableAddButton = new System.Windows.Forms.Button();
            this.contraintsCoeffVariableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateOptimumPoint = new System.Windows.Forms.Button();
            this.objectiveFunctionGroupBox.SuspendLayout();
            this.constraintsFunctionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectiveFunctionGroupBox
            // 
            this.objectiveFunctionGroupBox.Controls.Add(this.maximizationRadioButton);
            this.objectiveFunctionGroupBox.Controls.Add(this.minimizationRadioButton);
            this.objectiveFunctionGroupBox.Controls.Add(this.objectiveFunction);
            this.objectiveFunctionGroupBox.Controls.Add(this.label2);
            this.objectiveFunctionGroupBox.Controls.Add(this.objectiveFunctionDeleteButton);
            this.objectiveFunctionGroupBox.Controls.Add(this.objectiveFunctionVariablesListBox);
            this.objectiveFunctionGroupBox.Controls.Add(this.objectiveFunctionAddButton);
            this.objectiveFunctionGroupBox.Controls.Add(this.objectiveFunctionCoeffTextBox);
            this.objectiveFunctionGroupBox.Controls.Add(this.label1);
            this.objectiveFunctionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.objectiveFunctionGroupBox.Name = "objectiveFunctionGroupBox";
            this.objectiveFunctionGroupBox.Size = new System.Drawing.Size(758, 176);
            this.objectiveFunctionGroupBox.TabIndex = 0;
            this.objectiveFunctionGroupBox.TabStop = false;
            this.objectiveFunctionGroupBox.Text = "Objective Function";
            // 
            // maximizationRadioButton
            // 
            this.maximizationRadioButton.AutoSize = true;
            this.maximizationRadioButton.Location = new System.Drawing.Point(603, 139);
            this.maximizationRadioButton.Name = "maximizationRadioButton";
            this.maximizationRadioButton.Size = new System.Drawing.Size(109, 21);
            this.maximizationRadioButton.TabIndex = 8;
            this.maximizationRadioButton.TabStop = true;
            this.maximizationRadioButton.Text = "Maximization";
            this.maximizationRadioButton.UseVisualStyleBackColor = true;
            // 
            // minimizationRadioButton
            // 
            this.minimizationRadioButton.AutoSize = true;
            this.minimizationRadioButton.Location = new System.Drawing.Point(491, 139);
            this.minimizationRadioButton.Name = "minimizationRadioButton";
            this.minimizationRadioButton.Size = new System.Drawing.Size(106, 21);
            this.minimizationRadioButton.TabIndex = 7;
            this.minimizationRadioButton.TabStop = true;
            this.minimizationRadioButton.Text = "Minimization";
            this.minimizationRadioButton.UseVisualStyleBackColor = true;
            // 
            // objectiveFunction
            // 
            this.objectiveFunction.AutoSize = true;
            this.objectiveFunction.Location = new System.Drawing.Point(585, 92);
            this.objectiveFunction.Name = "objectiveFunction";
            this.objectiveFunction.Size = new System.Drawing.Size(15, 17);
            this.objectiveFunction.TabIndex = 6;
            this.objectiveFunction.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Objective Function=";
            // 
            // objectiveFunctionDeleteButton
            // 
            this.objectiveFunctionDeleteButton.Location = new System.Drawing.Point(346, 89);
            this.objectiveFunctionDeleteButton.Name = "objectiveFunctionDeleteButton";
            this.objectiveFunctionDeleteButton.Size = new System.Drawing.Size(64, 23);
            this.objectiveFunctionDeleteButton.TabIndex = 4;
            this.objectiveFunctionDeleteButton.Text = "Delete";
            this.objectiveFunctionDeleteButton.UseVisualStyleBackColor = true;
            // 
            // objectiveFunctionVariablesListBox
            // 
            this.objectiveFunctionVariablesListBox.DisplayMember = "VariableName";
            this.objectiveFunctionVariablesListBox.FormattingEnabled = true;
            this.objectiveFunctionVariablesListBox.ItemHeight = 16;
            this.objectiveFunctionVariablesListBox.Location = new System.Drawing.Point(87, 52);
            this.objectiveFunctionVariablesListBox.Name = "objectiveFunctionVariablesListBox";
            this.objectiveFunctionVariablesListBox.Size = new System.Drawing.Size(253, 100);
            this.objectiveFunctionVariablesListBox.TabIndex = 3;
            // 
            // objectiveFunctionAddButton
            // 
            this.objectiveFunctionAddButton.Location = new System.Drawing.Point(346, 24);
            this.objectiveFunctionAddButton.Name = "objectiveFunctionAddButton";
            this.objectiveFunctionAddButton.Size = new System.Drawing.Size(98, 23);
            this.objectiveFunctionAddButton.TabIndex = 2;
            this.objectiveFunctionAddButton.Text = "Add Variable";
            this.objectiveFunctionAddButton.UseVisualStyleBackColor = true;
            this.objectiveFunctionAddButton.Click += new System.EventHandler(this.objectiveFunctionAddButton_Click);
            // 
            // objectiveFunctionCoeffTextBox
            // 
            this.objectiveFunctionCoeffTextBox.Location = new System.Drawing.Point(240, 24);
            this.objectiveFunctionCoeffTextBox.Name = "objectiveFunctionCoeffTextBox";
            this.objectiveFunctionCoeffTextBox.Size = new System.Drawing.Size(100, 22);
            this.objectiveFunctionCoeffTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coefficient of Variable:";
            // 
            // constraintsFunctionGroupBox
            // 
            this.constraintsFunctionGroupBox.Controls.Add(this.deleteConstraint);
            this.constraintsFunctionGroupBox.Controls.Add(this.constraintsListBox);
            this.constraintsFunctionGroupBox.Controls.Add(this.contraintsAddConstraintButton);
            this.constraintsFunctionGroupBox.Controls.Add(this.d);
            this.constraintsFunctionGroupBox.Controls.Add(this.label6);
            this.constraintsFunctionGroupBox.Controls.Add(this.comparisonComboBox);
            this.constraintsFunctionGroupBox.Controls.Add(this.label5);
            this.constraintsFunctionGroupBox.Controls.Add(this.variableComboBox);
            this.constraintsFunctionGroupBox.Controls.Add(this.label4);
            this.constraintsFunctionGroupBox.Controls.Add(this.contraintsVariableDeleteButton);
            this.constraintsFunctionGroupBox.Controls.Add(this.contraintsVariableListBox);
            this.constraintsFunctionGroupBox.Controls.Add(this.constraintsVariableAddButton);
            this.constraintsFunctionGroupBox.Controls.Add(this.contraintsCoeffVariableTextBox);
            this.constraintsFunctionGroupBox.Controls.Add(this.label3);
            this.constraintsFunctionGroupBox.Location = new System.Drawing.Point(12, 194);
            this.constraintsFunctionGroupBox.Name = "constraintsFunctionGroupBox";
            this.constraintsFunctionGroupBox.Size = new System.Drawing.Size(758, 352);
            this.constraintsFunctionGroupBox.TabIndex = 1;
            this.constraintsFunctionGroupBox.TabStop = false;
            this.constraintsFunctionGroupBox.Text = "Constraints";
            // 
            // deleteConstraint
            // 
            this.deleteConstraint.Location = new System.Drawing.Point(374, 256);
            this.deleteConstraint.Name = "deleteConstraint";
            this.deleteConstraint.Size = new System.Drawing.Size(125, 23);
            this.deleteConstraint.TabIndex = 18;
            this.deleteConstraint.Text = "Delete Constraint";
            this.deleteConstraint.UseVisualStyleBackColor = true;
            // 
            // constraintsListBox
            // 
            this.constraintsListBox.FormattingEnabled = true;
            this.constraintsListBox.ItemHeight = 16;
            this.constraintsListBox.Location = new System.Drawing.Point(87, 222);
            this.constraintsListBox.Name = "constraintsListBox";
            this.constraintsListBox.Size = new System.Drawing.Size(253, 100);
            this.constraintsListBox.TabIndex = 17;
            // 
            // contraintsAddConstraintButton
            // 
            this.contraintsAddConstraintButton.Location = new System.Drawing.Point(491, 182);
            this.contraintsAddConstraintButton.Name = "contraintsAddConstraintButton";
            this.contraintsAddConstraintButton.Size = new System.Drawing.Size(113, 23);
            this.contraintsAddConstraintButton.TabIndex = 16;
            this.contraintsAddConstraintButton.Text = "Add Constraint";
            this.contraintsAddConstraintButton.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(374, 182);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(70, 22);
            this.d.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Right Hand Side:";
            // 
            // comparisonComboBox
            // 
            this.comparisonComboBox.FormattingEnabled = true;
            this.comparisonComboBox.Location = new System.Drawing.Point(177, 182);
            this.comparisonComboBox.Name = "comparisonComboBox";
            this.comparisonComboBox.Size = new System.Drawing.Size(60, 24);
            this.comparisonComboBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comparison:";
            // 
            // variableComboBox
            // 
            this.variableComboBox.FormattingEnabled = true;
            this.variableComboBox.Location = new System.Drawing.Point(416, 31);
            this.variableComboBox.Name = "variableComboBox";
            this.variableComboBox.Size = new System.Drawing.Size(60, 24);
            this.variableComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Variable:";
            // 
            // contraintsVariableDeleteButton
            // 
            this.contraintsVariableDeleteButton.Location = new System.Drawing.Point(491, 96);
            this.contraintsVariableDeleteButton.Name = "contraintsVariableDeleteButton";
            this.contraintsVariableDeleteButton.Size = new System.Drawing.Size(113, 23);
            this.contraintsVariableDeleteButton.TabIndex = 9;
            this.contraintsVariableDeleteButton.Text = "Delete Variable";
            this.contraintsVariableDeleteButton.UseVisualStyleBackColor = true;
            // 
            // contraintsVariableListBox
            // 
            this.contraintsVariableListBox.FormattingEnabled = true;
            this.contraintsVariableListBox.ItemHeight = 16;
            this.contraintsVariableListBox.Location = new System.Drawing.Point(87, 59);
            this.contraintsVariableListBox.Name = "contraintsVariableListBox";
            this.contraintsVariableListBox.Size = new System.Drawing.Size(253, 100);
            this.contraintsVariableListBox.TabIndex = 8;
            // 
            // constraintsVariableAddButton
            // 
            this.constraintsVariableAddButton.Location = new System.Drawing.Point(491, 31);
            this.constraintsVariableAddButton.Name = "constraintsVariableAddButton";
            this.constraintsVariableAddButton.Size = new System.Drawing.Size(98, 23);
            this.constraintsVariableAddButton.TabIndex = 7;
            this.constraintsVariableAddButton.Text = "Add Variable";
            this.constraintsVariableAddButton.UseVisualStyleBackColor = true;
            // 
            // contraintsCoeffVariableTextBox
            // 
            this.contraintsCoeffVariableTextBox.Location = new System.Drawing.Point(240, 31);
            this.contraintsCoeffVariableTextBox.Name = "contraintsCoeffVariableTextBox";
            this.contraintsCoeffVariableTextBox.Size = new System.Drawing.Size(100, 22);
            this.contraintsCoeffVariableTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coefficient of Variable:";
            // 
            // calculateOptimumPoint
            // 
            this.calculateOptimumPoint.Location = new System.Drawing.Point(297, 581);
            this.calculateOptimumPoint.Name = "calculateOptimumPoint";
            this.calculateOptimumPoint.Size = new System.Drawing.Size(188, 36);
            this.calculateOptimumPoint.TabIndex = 2;
            this.calculateOptimumPoint.Text = "Calculate";
            this.calculateOptimumPoint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 657);
            this.Controls.Add(this.calculateOptimumPoint);
            this.Controls.Add(this.constraintsFunctionGroupBox);
            this.Controls.Add(this.objectiveFunctionGroupBox);
            this.Name = "Form1";
            this.Text = "Optimum Point Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.objectiveFunctionGroupBox.ResumeLayout(false);
            this.objectiveFunctionGroupBox.PerformLayout();
            this.constraintsFunctionGroupBox.ResumeLayout(false);
            this.constraintsFunctionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox objectiveFunctionGroupBox;
        public System.Windows.Forms.ListBox objectiveFunctionVariablesListBox;
        public System.Windows.Forms.Button objectiveFunctionAddButton;
        public System.Windows.Forms.TextBox objectiveFunctionCoeffTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox constraintsFunctionGroupBox;
        private System.Windows.Forms.RadioButton maximizationRadioButton;
        private System.Windows.Forms.RadioButton minimizationRadioButton;
        private System.Windows.Forms.Label objectiveFunction;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button objectiveFunctionDeleteButton;
        public System.Windows.Forms.Button deleteConstraint;
        public System.Windows.Forms.ListBox constraintsListBox;
        public System.Windows.Forms.Button contraintsAddConstraintButton;
        public System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comparisonComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox variableComboBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button contraintsVariableDeleteButton;
        public System.Windows.Forms.ListBox contraintsVariableListBox;
        public System.Windows.Forms.Button constraintsVariableAddButton;
        public System.Windows.Forms.TextBox contraintsCoeffVariableTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateOptimumPoint;
    }
}

