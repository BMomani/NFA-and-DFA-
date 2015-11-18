using System.Collections;
using System.Collections.Generic;

namespace NfaAndDfa
{
    internal interface IFA
    {
        IList States { get; set; }
        IList Symbols { get; set; }
        State StartState { get; set; }
        IList FinalStates { get; set; }
        List<TransitionFunction> TransitionFunctions { get; set; }
        void TestInput(string input);
    }
}