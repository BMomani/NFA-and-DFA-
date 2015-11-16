using System;

namespace ConsoleApplication2
{
    public class State : IState
    {
        private string m_name = string.Empty;
        private bool m_isFinal = false;

        public State(string name, bool isFinal)
        {
            m_name = name;
            m_isFinal = isFinal;
        }

        public State(string name)
        {
            m_name = name;
            m_isFinal = false;
        }

        public string Name
        {
            get { return m_name; }
        }

        public bool IsFinal
        {
            get { return m_isFinal; }
        }

        public override string ToString()
        {
            return Name;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((State) obj);
        }

        protected bool Equals(State other)
        {
            return string.Equals(m_name, other.m_name);
        }

        public override int GetHashCode()
        {
            return (m_name != null ? m_name.GetHashCode() : 0);
        }
    }
}