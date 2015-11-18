using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NfaAndDfa
{
    public class DFA : IFA
    {
        private IList m_states = null;
        private IList m_symbols = null;
        private State m_start_state = null;
        private IList m_final_states = null;
        private List<TransitionFunction> m_transition_functions = null;

        public DFA(IList states, IList symbols, State startstate, IList finalstates,
            List<TransitionFunction> transitionfunctions)
        {
            m_states = states;
            m_symbols = symbols;
            m_start_state = startstate;
            m_final_states = finalstates;
            m_transition_functions = transitionfunctions;
            IsDFA(this);
        }

        public DFA(IList states, IList symbols, State startstate, State finalstate,
            List<TransitionFunction> transitionfunctions)
        {
            m_states = states;
            m_symbols = symbols;
            m_start_state = startstate;
            m_final_states = new ArrayList();
            m_final_states.Add(finalstate);
            m_transition_functions = transitionfunctions;
            IsDFA(this);
        }

        public IList States
        {
            get { return m_states; }
            set { m_states = value; }
        }

        public IList Symbols
        {
            get { return m_symbols; }
            set { m_symbols = value; }
        }

        public State StartState
        {
            get { return m_start_state; }
            set { m_start_state = value; }
        }

        public IList FinalStates
        {
            get { return m_final_states; }
            set { m_final_states = value; }
        }

        public List<TransitionFunction> TransitionFunctions
        {
            get { return m_transition_functions; }
            set { m_transition_functions = value; }
        }

        private static void IsDFA(DFA DFA1)
        {
            ArrayList ar = new ArrayList(); //to be used for earasing duplicated entries
            //check for valid symbols
            foreach (object o in DFA1.m_symbols)
            {
                if (!(o is char))
                    throw new Exception
                        ("one of your input symbols is not in the correct format");
                char ch = (char) o;
                if (!ar.Contains(ch))
                    ar.Add(ch);
            }
            DFA1.m_symbols = (IList) ar.Clone();
            //check for valid states
            ar.Clear();
            foreach (object o in DFA1.m_states)
            {
                if (!(o is State))
                    throw new Exception
                        ("one of your states is not in the correct format");
                State st = o as State;
                if (!ar.Contains(st))
                    ar.Add(st);
            }
            DFA1.m_states = (IList) ar.Clone();
            //check for valid final states
            foreach (object o in DFA1.m_final_states)
                if (!DFA1.m_states.Contains(o))
                    throw new Exception
                        ("one of your final states doesn't exist in your states");
            //check transition functions for duplicated
            ar.Clear();

            var listdupli= new List<TransitionFunction>();
            foreach (object o in DFA1.m_transition_functions)
            {
                if (!(o is ITransitionFunction))
                {
                    throw new Exception
                        ("one of your functions is not in the correct format");
                }
                TransitionFunction tf = o as TransitionFunction;
                //for repeated entries

                if (!listdupli.Contains(tf))
                    listdupli.Add(tf);
            }
            DFA1.m_transition_functions = listdupli;
            //check for valid functions according to input states
            foreach (ITransitionFunction Itf in DFA1.m_transition_functions)
            {
                if (!DFA1.m_states.Contains(Itf.InputState))
                    throw new Exception(String.Format("the state with name {0} doesn't exist in states",
                        Itf.InputState.Name));
                if (!DFA1.m_states.Contains(Itf.OutputState))
                    throw new Exception(String.Format("the state with name {0} doesn't exist in states",
                        Itf.OutputState.Name));
                if (!DFA1.m_symbols.Contains(Itf.InputSymbol))
                    throw new Exception(String.Format("the symbol with name {0} doesn't exist in symbols",
                        Itf.InputSymbol.ToString()));
            }
            //check whether it is a deterministic DFA or it is a NFA  >>case duplicated seqma 
            foreach (ITransitionFunction Itf1 in DFA1.m_transition_functions)
                foreach (ITransitionFunction Itf2 in DFA1.m_transition_functions)
                    if (Itf2.InputState == Itf1.InputState && Itf2.InputSymbol == Itf1.InputSymbol
                        && Itf1.OutputState != Itf2.OutputState)
                        throw new Exception("this is not a determenistic DFA");

            foreach (IState state in DFA1.States)
            {
                List<TransitionFunction> StateTransition = DFA1.TransitionFunctions.FindAll(function => function.InputState.Name == state.Name);

                foreach (char symbol in DFA1.Symbols)
                {
                    for (int i = 0; i < StateTransition.Count; i++)
                    {
                        var function = StateTransition[i];
                        if (function.InputSymbol == symbol)
                            break;
                        else
                        {
                            if (i== StateTransition.Count-1)
                                throw new Exception("this is not a determenistic DFA");
                            else
                                continue;
                        }
                    }
                }
            }
        }

        public void TestInput(string input)
        {
            ConsoleWriter.Success("Trying to parse: " + input);
            if (InvalidInput(input))
            {
                return;
            }
            var currentState = StartState;
            var steps = new StringBuilder();
            foreach (var symbol in input.ToCharArray())
            {
                var transitions = TransitionFunctions as List<TransitionFunction>;
                var transition = transitions.Find(t => t.InputState == currentState &&
                                                       t.InputSymbol == symbol);
                if (transition == null)
                {
                    ConsoleWriter.Failure("No transitions for current state and symbol");
                    ConsoleWriter.Failure(steps.ToString());
                    return;
                }
                currentState = transition.OutputState;
                steps.Append(transition + "\n");
            }
            if (FinalStates.Contains(currentState))
            {
                ConsoleWriter.Success("Accepted the input with steps:\n" + steps);
                return;
            }
            ConsoleWriter.Failure("Stopped in state " + currentState +
                                  " which is not a final state.");
            ConsoleWriter.Failure(steps.ToString());
        }


        private bool InvalidInput(string input)
        {
            if (InputContainsNotDefinedSymbols(input))
            {
                return true;
            }

            return false;
        }

        private bool InputContainsNotDefinedSymbols(string input)
        {
            foreach (char symbol in input.Where(c => !Symbols.Contains(c)))
            {
                ConsoleWriter.Failure("Could not accept the input since the symbol " + symbol +
                                      " is not part of the alphabet");
                return true;
            }
            return false;
        }

    }
}