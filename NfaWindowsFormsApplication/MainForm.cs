using System;
using System.Windows.Forms;
using static NfaWindowsFormsApplication.Program;

namespace NfaWindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void FillMachineComponent()
        {
            label6.Text = MachineType.ToString();

            foreach (var symbol in Machine.Symbols)
            {
                listBox1.Items.Add(symbol);
            }
            foreach (var state in Machine.States)
            {
                listBox2.Items.Add(state);
            }

            listBox3.Items.Add(InitialState);

            foreach (var finalState in Machine.FinalStates)
            {
                listBox4.Items.Add(finalState);
            }
            foreach (var transitionFunction in Machine.TransitionFunctions)
            {
                listBox5.Items.Add(transitionFunction);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var newFrm = new NewMachineForm();
            newFrm.Closed += delegate
            {
                FillMachineComponent();     
            };
            newFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Machine!=null)
                Machine.TestInput(textBox1.Text);
        }
    }
}
