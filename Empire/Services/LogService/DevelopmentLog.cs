using Newtonsoft.Json;
using System;
using System.IO;
using EmpireTest.InfraestructureTransversal.ServicesException;

namespace EmpireTest.Services.LogService
{
    public class DevelopmentLog : ILog
    {
        public void WriteLog(string message)
        {
            var date = DateTime.Now;

            try
            {
                Console.WriteLine($"[{date}] {message}");
            }
            catch (Exception ex)
               {
                    throw new LogException("No se ha podido escribir en la consola", ex);
               }
            }
        }

}































