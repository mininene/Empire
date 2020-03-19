using System;

namespace EmpireTest.InfraestructureTransversal.ControllerException
{
    public class ControllerException:Exception
    {

        public ControllerException(String message) : base(message) { }
    }
}
