using NUnit.Framework;
using EmpireTest.Services.LogService;

namespace EmpireTest.Pruebas_Unitarias.Servicios
{
    class LogService
    {
        public readonly string Contain;
        private readonly ILog _log = new DevelopmentLog();


      
        public LogService()
        {
            Contain = "Esto es una prueba de funcionamiento!";
            _log.WriteLog(Contain);
        }

        [Test]
        public void LogWrite()
        {
            _log.WriteLog(Contain);
        }

    }
}
