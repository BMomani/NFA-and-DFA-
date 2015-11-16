using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var states = new List<State>();
            states.Add(new State("Q0"));
            states.Add(new State("Q1",true));
            states.Add(new State("Q2", true));

            //var seqma = new[] { '0', '1' };
            var seqma = new List<char>();
            seqma.Add('0');
            seqma.Add('1');

            var Transitions = new List<TransitionFunction>();

            Transitions.Add(new TransitionFunction(states[0], states[1], seqma[0])); // q0 to q1 via 0
            Transitions.Add(new TransitionFunction(states[0], states[0], seqma[1])); // q0 to q0 via 1
            Transitions.Add(new TransitionFunction(states[1], states[0], seqma[0])); // q1 to q0 via 0
            Transitions.Add(new TransitionFunction(states[1], states[2], seqma[1])); // q1 to q0 via 0
            Transitions.Add(new TransitionFunction(states[2], states[0], seqma[0])); // q1 to q0 via 0
            Transitions.Add(new TransitionFunction(states[2], states[0], seqma[1])); // q1 to q0 via 0



            DFA dfa = new DFA(states, seqma, states[0], states[1], Transitions);

            dfa.Accepts("010");


            Console.ReadKey();
        }


    }
}













