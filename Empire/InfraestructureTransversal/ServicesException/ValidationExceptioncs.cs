using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class ValidationExceptioncs:Exception
    {
        public ValidationExceptioncs(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
