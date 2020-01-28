using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimumPointCalculator
{
    public delegate void DelegateOfUpdate();

    public class ObjectiveFunction:Equation
    {
        public ObjectiveFunction()
        {
            this.ListBoxesToBeUpdate = new List<ListBox>();
            this.LabelsToBeUpdate = new List<Label>();
        }
        public void AddElementWithUpdateProcess(Variable variable)
        {
            Variables.Add(variable);

            EventOfUpdate();
        }
        public void DeleteElementWithUpdateProcess(int index)
        {
            Variables.RemoveAt(index);

            EventOfUpdate();

        }
        public List<ListBox> ListBoxesToBeUpdate { get; set; }
        public List<Label> LabelsToBeUpdate { get; set; }
        public List<ComboBox> ComboBoxesToBeUpdate { get; set; }

        public event DelegateOfUpdate EventOfUpdate;

    }
}
