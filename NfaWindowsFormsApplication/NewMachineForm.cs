using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NfaAndDfa;
using NfaWindowsFormsApplication.Properties;
using static NfaWindowsFormsApplication.Program;

namespace NfaWindowsFormsApplication
{
    public partial class NewMachineForm : Form
    {
        public NewMachineForm()
        {
            InitializeComponent();
            Program.Seqma=new List<char>();
            Program.States = new List<State>();
            FinalStates = new List<State>();
            
            Program.Transitions=new List<TransitionFunction>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //alpha
            if (!string.IsNullOrEmpty(textBox1.Text) && !Seqma.Contains(char.Parse(textBox1.Text)))
            {
                listBox1.Items.Add(textBox1.Text);
                Seqma.Add(char.Parse(textBox1.Text));
                textBox1.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
                try
                {
                    Seqma.Remove(Convert.ToChar(listBox1.SelectedItem.ToString()));
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (ActiveForm != null) ActiveForm.AcceptButton = button1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //states
            var newState =new State(textBox2.Text);
            if (!string.IsNullOrEmpty(textBox2.Text) && !States.Contains(newState))
            {
                listBox2.Items.Add(newState);
                States.Add(newState);
                textBox2.Text = "";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
                try
                {
                    States.Remove(new State(listBox2.SelectedItem.ToString()));
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (ActiveForm != null) ActiveForm.AcceptButton = button2;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button2.PerformClick();
            }
        }

       
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //initial State
            if(listBox4.Items.Count==1) return;
            if (listBox3.SelectedIndex >= 0)
                try
                {
                    listBox4.Items.Add(listBox3.Items[listBox3.SelectedIndex]);
                    InitialState=new State(listBox3.Items[listBox3.SelectedIndex].ToString());
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox4.SelectedIndex >= 0)
                try
                {
                    listBox4.Items.RemoveAt(listBox4.SelectedIndex);
                    InitialState = null;
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {listBox3.Items.Clear();
            //get all states
            foreach (var item in listBox2.Items)
            {
                listBox3.Items.Add(item);
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            //get all states
            foreach (var item in listBox2.Items)
            {
                listBox5.Items.Add(item);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox5.SelectedIndex >= 0)
                try
                {
                    var findedState = States.Find(state => state.Name==listBox5.SelectedItem.ToString());
//                    FindedState.IsFinal = true;
                    FinalStates.Add(findedState);
                    listBox6.Items.Add(listBox5.SelectedItem);
                    listBox5.Items.Remove(listBox5.SelectedItem);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox6.SelectedIndex >= 0)
                try
                {
                    FinalStates.Remove(new State(listBox6.SelectedItem.ToString()));
                    listBox5.Items.Add(listBox6.SelectedItem);
                    listBox6.Items.Remove(listBox6.SelectedItem);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex!=0)
                tabControl1.SelectedIndex -= 1;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount)
                tabControl1.SelectedIndex += 1;
            if (btn_next.Text == Resources.DoneWord)
            {
                try
                {
                    if (MachineType == machineType.Dfa)
                        Machine = new DFA(States, Seqma, InitialState, FinalStates, Transitions);
                    else Machine = new NFA(States, Seqma, InitialState, FinalStates, Transitions);
                    Close();
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Resources.ErrorWord, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(exception);
                }
            }
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            comboBox1.Items.Clear();
            //get all states
            foreach (var item in listBox2.Items)
            {
                listBox7.Items.Add(item);
                listBox8.Items.Add(item);
            }
            //get all alphapet
            foreach (var item in listBox1.Items)
            {
                comboBox1.Items.Add(item);
            }
            if (MachineType != null)
                btn_next.Text = Resources.DoneWord;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox7.SelectedIndex >= 0 && listBox8.SelectedIndex >=0 && comboBox1.SelectedIndex>=0 )
                try
                {
                    var newTransFunc = new TransitionFunction(new State(listBox7.SelectedItem.ToString()), new State(listBox8.SelectedItem.ToString()), Convert.ToChar(comboBox1.SelectedItem.ToString()));

                    listBox9.Items.Add(newTransFunc);
                    Transitions.Add(newTransFunc);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
           
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBox9.SelectedIndex >= 0)
                try
                {
                    
                    Transitions.RemoveAt(listBox9.SelectedIndex);
                    listBox9.Items.RemoveAt(listBox9.SelectedIndex);
                }
                catch (Exception exception)
                {
                    ConsoleWriter.Failure(exception.Message);
                }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MachineType = (RadioButton)sender== radioButton2 ? machineType.Dfa : machineType.Nfa;
        }

    }
}
