using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Calculator
{
    [Serializable]
    public class NegativeResultException : Exception
    {
        public NegativeResultException()
        {
        }

        public NegativeResultException(string message)
            : base(String.Format("Het Resultaat van deze calculatie is negatief."))
        {
        }

        public NegativeResultException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
