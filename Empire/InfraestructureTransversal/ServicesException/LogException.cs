using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class LogException : Exception
    {
        public LogException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
