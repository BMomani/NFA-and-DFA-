using System;
using System.Drawing;
using System.Windows.Forms;
using NfaAndDfa;
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
                if(MachineType==machineType.Nfa)
                    button3.Visible = true;
            };
            newFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Machine != null)
            {
                Machine.Log = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            var nfa = Machine as NFA;
            if (nfa != null)
            {
                var dfa = nfa.ConvertToDfa();
                FillMachineComponent(dfa);
            }

        }

        private void FillMachineComponent(DFA dfa)
        {
            try
            {
                label6.Text = Resources.MachineTypeWord + machineType.Dfa;
                button3.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();


                foreach (var symbol in dfa.Symbols)
                {
                    listBox1.Items.Add(symbol);
                }
                foreach (var state in dfa.States)
                {
                    listBox2.Items.Add(state);
                }

                listBox3.Items.Add(InitialState);

                foreach (var finalState in dfa.FinalStates)
                {
                    listBox4.Items.Add(finalState);
                }
                foreach (var transitionFunction in dfa.TransitionFunctions)
                {
                    listBox5.Items.Add(transitionFunction);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button3.PerformClick();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (ActiveForm != null) ActiveForm.AcceptButton = button3;
        }
    }
}
