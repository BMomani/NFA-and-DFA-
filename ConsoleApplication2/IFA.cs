using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal interface IFA
    {
        IList States { get; set; }
        IList Symbols { get; set; }
        State StartState { get; set; }
        IList FinalStates { get; set; }
        List<TransitionFunction> TransitionFunctions { get; set; }
        void Accepts(string input);
    }
}