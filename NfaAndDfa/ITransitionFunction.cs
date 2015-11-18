namespace NfaAndDfa
{
    internal interface ITransitionFunction
    {
        State InputState { get; set; }
        State OutputState { get; set; }
        char InputSymbol { get; set; }

    }
}