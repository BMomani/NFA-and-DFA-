using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NfaAndDfa
{
    public class NFA : IFiniteAutomaton
    {
        private IList m_states = null;
        private List<char> m_symbols = null;
        private State m_start_state = null;
        private List<State> m_final_states = null;
        private List<TransitionFunction> m_transition_functions = null;

        public NFA(IList mStates, List<char> mSymbols, State mStartState, List<State> mFinalStates, List<TransitionFunction> mTransitionFunctions)
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
            m_final_states = new List<State>();
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

        public List<State> FinalStates
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

            List<State> DfaFinalStates = FinalStates;
            List<TransitionFunction> DfaTransitions = new List<TransitionFunction>();

            for (int i = 0; i < DfaStates.Count; i++)// i cant use foreach
            {
                var dfaCurrentState = DfaStates[i];
                foreach (var symbol in DfaSymbols)
                {
                    var result = TransitionFunctions.FindAll(transitionFunction => transitionFunction.InputState.Name == dfaCurrentState.Name && transitionFunction.InputSymbol == symbol);
                    if (result.Count == 1)
                    {
                        DfaTransitions.Add(new TransitionFunction(dfaCurrentState, result[0].OutputState, symbol));
                        if (!DfaStates.Contains(result[0].OutputState))
                            DfaStates.Add(result[0].OutputState);
                    }
                    if (result.Count == 0)
                    {
                        DfaTransitions.Add(new TransitionFunction(dfaCurrentState,
                            GetTrapState(DfaStates, DfaTransitions), symbol));
                    }
                    if (result.Count > 1)
                    {
                        string name = null; // create name to state from two states
                        foreach (var function in result)
                            name = name + function.InputState.Name;
                        var combinedState = new State(name);
                        DfaTransitions.Add(new TransitionFunction(dfaCurrentState, combinedState, symbol));
                        if (!DfaStates.Contains(combinedState))
                            DfaStates.Add(combinedState);
                        //need completion
                    }
                }
            }

            return new DFA(DfaStates, DfaSymbols, DfaInitialState, DfaFinalStates, DfaTransitions);
        }

        private State GetTrapState(List<State> dfaStates, List<TransitionFunction> dfaTransitions)
        {
           
            var result= dfaStates.Find(state => state.Name == "*");
            if (result != null)
                return result;
            else
            {
                var trapStat = new State("*");
                foreach (var symbol in Symbols)
                {
                    dfaTransitions.Add(new TransitionFunction(trapStat,trapStat,symbol));
                }
                dfaStates.Add(trapStat);
                return trapStat;
            }
        }

        public bool TestInput(string input)
        {
            Log += ConsoleWriter.Info("Trying to accept: " + input);

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
                    var currentSteps = new StringBuilder(steps.ToString() + transition+ "\r\n");
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
                                       " with steps:\r\n" + steps);
                return true;
            }
            return false;

        }

        private List<TransitionFunction> GetAllTransitions(State currentState, char c)
        {
            return TransitionFunctions.FindAll(tf => tf.InputState.Name == currentState.Name && tf.InputSymbol == c);
        }
    }
}