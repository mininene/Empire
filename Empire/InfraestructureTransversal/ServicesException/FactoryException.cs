using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class FactoryException:Exception
    {
        public FactoryException(string message) : base(message)
        {
        }

        public FactoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
