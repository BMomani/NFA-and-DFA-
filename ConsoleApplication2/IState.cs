namespace ConsoleApplication2
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