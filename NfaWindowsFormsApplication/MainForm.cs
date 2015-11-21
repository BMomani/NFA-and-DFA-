using System;
using System.Drawing;
using System.Windows.Forms;
using NfaWindowsFormsApplication.Properties;
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
            try
            {
                label6.Text = Resources.MachineTypeWord + MachineType;

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
            catch (Exception exception)
            {
                Console.WriteLine(exception);
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
            if (Machine != null)
            {
                if (Machine.TestInput(textBox1.Text))
                {
                    label7.ForeColor = Color.Green;
                    label7.Text = "input accepted";
                }
                else
                {
                    label7.ForeColor = Color.Red;
                    label7.Text = "input Rejected";

                }
                textBox2.Text = Machine.Log;

            }

        }
    }
}
