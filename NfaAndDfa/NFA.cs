using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NfaAndDfa
{
    public class NFA : IFiniteAutomaton
    {
        private IList m_states = null;
        private List<char> m_symbols = null;
        private State m_start_state = null;
        private IList m_final_states = null;
        private List<TransitionFunction> m_transition_functions = null;

        public NFA(IList mStates, List<char> mSymbols, State mStartState, IList mFinalStates, List<TransitionFunction> mTransitionFunctions)
        {
            m_states = mStates;
            m_symbols = mSymbols;
            m_start_state = mStartState;
            m_final_states = mFinalStates;
            m_transition_functions = mTransitionFunctions;
        }

        public NFA(IList mStates, List<char> mSymbols, State mStartState, State mFinalState, List<TransitionFunction> mTransitionFunctions)
        {
            m_states = mStates;
            m_symbols = mSymbols;
            m_start_state = mStartState;
            m_final_states = new ArrayList();
            m_final_states.Add(mFinalState);
            m_transition_functions = mTransitionFunctions;
        }

        public IList States
        {
            get { return m_states; }
            set { m_states = value; }
        }

        public List<char> Symbols
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

        public DFA ConvertToDfa()
        {
            var DfaSymbols = this.Symbols;
            var DfaInitialState = this.StartState;

            var DfaStates = new List<State> {DfaInitialState};

            List<State> DfaFinalStates = null;
            List<TransitionFunction> DfaTransitions = null;

            foreach (var dfaCurrentState in DfaStates)
            {
                foreach (var symbol in DfaSymbols)
                {
                   var result = TransitionFunctions.FindAll(match: function => function.InputState.Name == dfaCurrentState.Name && function.InputSymbol == symbol);
                    if (result.Count==1)
                    {
                        DfaTransitions.Add(new TransitionFunction(dfaCurrentState,result[0].OutputState,symbol));
                        //need completion

                    }
                    if (result.Count == 0)
                    {
                        DfaTransitions.Add(new TransitionFunction(dfaCurrentState, GetTrapState(), symbol));
                        //need completion
                    }
                    if (result.Count > 1)
                    {
                       
                        //need completion
                    }



                }
            }

            return new DFA(DfaStates,DfaSymbols,DfaInitialState,DfaFinalStates,DfaTransitions);
        }

        private State GetTrapState()
        {
            throw new System.NotImplementedException();
        }

        public bool TestInput(string input)
        {
            Log += ConsoleWriter.Success("Trying to accept: " + input);

            if (Accepts(StartState, input, new StringBuilder()))
            {
                return true;
            }
            Log += ConsoleWriter.Failure("Could not accept the input: " + input);
            return false;
        }

        public string Log { get; set; }

        private bool Accepts(State currentState, string input, StringBuilder steps)
        {
            if (input.Length > 0)
            {
                var transitions = GetAllTransitions(currentState, input[0]);
                foreach (var transition in transitions)
                {
                    var currentSteps = new StringBuilder(steps.ToString() + transition);
                    if (Accepts(transition.OutputState, input.Substring(1), currentSteps))
                    {
                        return true;
                    }
                }
                return false;
            }
            if (FinalStates.Contains(currentState))
            {
                Log += ConsoleWriter.Success("Successfully accepted the input " + input + " " +
                                       "in the final state " + currentState +
                                       " with steps:\n" + steps);
                return true;
            }
            return false;

        }

        private List<TransitionFunction> GetAllTransitions(State currentState, char c)
        {
            return TransitionFunctions.FindAll(tf => tf.InputState == currentState && tf.InputSymbol == c);
        }
    }
}