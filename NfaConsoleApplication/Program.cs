using System;
using System.Collections.Generic;
using NfaAndDfa;
using Alphapits =System.Char;

namespace NfaConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //var states = new List<State>();
            //var initialState = new State("Q0");
            //states.Add(initialState);
            //states.Add(new State("Q1", true));
            //states.Add(new State("Q2", true));

            ////var seqma = new[] { '0', '1' };
            //var seqma = new List<Alphapits>();
            //seqma.Add('0');
            //seqma.Add('1');

            //var Transitions = new List<TransitionFunction>();

            //Transitions.Add(new TransitionFunction(states[0], states[1], seqma[0])); // q0 to q1 via 0
            //Transitions.Add(new TransitionFunction(states[0], states[0], seqma[1])); // q0 to q0 via 1
            //Transitions.Add(new TransitionFunction(states[1], states[0], seqma[0])); // q1 to q0 via 0
            //Transitions.Add(new TransitionFunction(states[1], states[2], seqma[1])); // q1 to q0 via 1
            //Transitions.Add(new TransitionFunction(states[2], states[0], seqma[0])); // q1 to q0 via 0
            //Transitions.Add(new TransitionFunction(states[2], states[0], seqma[1])); // q1 to q0 via 1

            
            //DFA dfa = new DFA(states, seqma, initialState , states[1], Transitions);

            //dfa.TestInput("010");


            try
            {
               
                var list = new List<State>(){ new State("q0"), new State("q1") };
                var list1 = new List<char>() { 'a', 'b' };
                var list2 = new List<TransitionFunction>()
                {
                    new TransitionFunction(new State("q0"), new State("q1"), list1[0])
                };

                var nfa =new NFA(list, list1, list[0],list[1],list2);
                var dfa = nfa.ConvertToDfa();
                Console.WriteLine(dfa.ToString());

                //int a = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }
    }
}
