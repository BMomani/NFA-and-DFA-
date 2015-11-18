namespace NfaAndDfa
{
    /// <summary>
    /// Summary description for DFA.
    /// </summary>
    /// 
    internal interface IState
    {
        string Name { get; }
        bool IsFinal { get; }
    }
}