using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class CurrencyException:Exception
    {
        public CurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
