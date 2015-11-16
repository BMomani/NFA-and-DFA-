using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    internal class NFA : IFA
    {
        private IList m_states = null;
        private IList m_symbols = null;
        private State m_start_state = null;
        private IList m_final_states = null;
        private List<TransitionFunction> m_transition_functions = null;

        public NFA(IList mStates, IList mSymbols, State mStartState, IList mFinalStates, List<TransitionFunction> mTransitionFunctions)
        {
            m_states = mStates;
            m_symbols = mSymbols;
            m_start_state = mStartState;
            m_final_states = mFinalStates;
            m_transition_functions = mTransitionFunctions;
        }

        public NFA(IList mStates, IList mSymbols, State mStartState, State mFinalState, List<TransitionFunction> mTransitionFunctions)
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

        public void Accepts(string input)
        {
            ConsoleWriter.Success("Trying to accept: " + input);

            if (Accepts(StartState, input, new StringBuilder()))
            {
                return;
            }
            ConsoleWriter.Failure("Could not accept the input: " + input);
        }

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
                ConsoleWriter.Success("Successfully accepted the input " + input + " " +
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