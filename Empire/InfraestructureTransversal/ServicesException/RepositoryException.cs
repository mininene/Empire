using System;

namespace EmpireTest.InfraestructureTransversal.ServicesException
{
    public class RepositoryException:Exception
    {
        public RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
