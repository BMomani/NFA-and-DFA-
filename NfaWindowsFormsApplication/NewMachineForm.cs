using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NfaAndDfa;
using static NfaWindowsFormsApplication.Program;

namespace NfaWindowsFormsApplication
{
    public partial class NewMachineForm : Form
    {
        public NewMachineForm()
        {
            InitializeComponent();
            Program.States=new List<State>();
            Program.seqma=new List<char>();
            Program.Transitions=new List<TransitionFunction>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //alpha
            if (!string.IsNullOrEmpty(textBox1.Text) && !seqma.Contains(char.Parse(textBox1.Text)))
            {
                listBox1.Items.Add(textBox1.Text);
                seqma.Add(char.Parse(textBox1.Text));
                textBox1.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
                try
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
