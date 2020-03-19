using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class SplitException : Exception
    {
        public SplitException(string message) : base(message)
        {
        }
    }
}
