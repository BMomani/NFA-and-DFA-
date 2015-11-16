namespace ConsoleApplication2
{
    public class TransitionFunction : ITransitionFunction
    {
        private State m_inputstate = null;
        private State m_outputstate = null;
        private char m_inputsymbol = char.MinValue;

        public TransitionFunction(State inputstate, State outputstate, char inputsymbol)
        {
            m_inputstate = inputstate;
            m_outputstate = outputstate;
            m_inputsymbol = inputsymbol;
        }

        public State InputState
        {
            get { return m_inputstate; }
            set { m_inputstate = value; }
        }

        public State OutputState
        {
            get { return m_outputstate; }
            set { m_outputstate = value; }
        }

        public char InputSymbol
        {
            get { return m_inputsymbol; }
            set { m_inputsymbol = value; }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) -> {2}", InputState, InputSymbol, OutputState);
        }

        protected bool Equals(TransitionFunction other)
        {
            return m_inputstate.Name == other.m_inputstate.Name && m_outputstate.Name == other.m_outputstate.Name && m_inputsymbol == other.m_inputsymbol;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TransitionFunction) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (m_inputstate != null ? m_inputstate.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (m_outputstate != null ? m_outputstate.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ m_inputsymbol.GetHashCode();
                return hashCode;
            }
        }
    }
}