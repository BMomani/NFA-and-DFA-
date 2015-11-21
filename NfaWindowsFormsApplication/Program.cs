using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NfaAndDfa;
using Alphapit =System.Char;

namespace NfaWindowsFormsApplication
{
    enum machineType
    {
        Nfa,Dfa
    }
    static class Program
    {
        public static IFiniteAutomaton Machine=null;
        public static machineType MachineType;
        public static List<State> States;
        public static State InitialState;
        public static List<State> FinalStates;

        public static List<Alphapit> Seqma;
        public static List<TransitionFunction> Transitions; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
