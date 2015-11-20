using System.Collections;
using System.Collections.Generic;

namespace NfaAndDfa
{
    public interface IFiniteAutomaton
    {
        IList States { get; set; }
        IList Symbols { get; set; }
        State StartState { get; set; }
        IList FinalStates { get; set; }
        List<TransitionFunction> TransitionFunctions { get; set; }
        bool TestInput(string input);
    }
}