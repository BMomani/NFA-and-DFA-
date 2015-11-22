using System.Collections;
using System.Collections.Generic;

namespace NfaAndDfa
{
    public interface IFiniteAutomaton
    {
        IList States { get; set; }
        List<char> Symbols { get; set; }
        State StartState { get; set; }
        List<State> FinalStates { get; set; }
        List<TransitionFunction> TransitionFunctions { get; set; }
        bool TestInput(string input);
        string Log { get; set; }
    }
}