using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication2
{
    internal interface ITransitionFunction
    {
        State InputState { get; set; }
        State OutputState { get; set; }
        char InputSymbol { get; set; }

    }
}