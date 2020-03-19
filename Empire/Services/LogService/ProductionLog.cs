using System;
using System.IO;
using EmpireTest.InfraestructureTransversal.ServicesException;
using Newtonsoft.Json;

namespace EmpireTest.Services.LogService
{
    public class ProductionLog : ILog
    {
        private readonly string _filePath = AppDomain.CurrentDomain.BaseDirectory + $"Rebels{DateTime.Now:yyyy-MM-ddTHH-mm-ss}.json";


        public void WriteLog(string menssage)
        {

            try
            {
                using (var sw = new StreamWriter(_filePath))
                {
                    var jsonStr = JsonConvert.SerializeObject(menssage, Formatting.Indented);

                    sw.Write(jsonStr);
                }
            }
            catch (Exception ex)
            {
                throw new LogException("No se ha podido escribir en el archivo", ex);
            }

        }

    }



}






//public void WriteLog(string message)
//{
//    var date = DateTime.Now;
//    var path = AppDomain.CurrentDomain.BaseDirectory + "/LogFiles";
//    Directory.CreateDirectory(path);

//    try
//    {
//        using (var sw = new StreamWriter(path + "/logfile.txt", true))
//        {
//            sw.WriteLine($"[{date}] {message}");
//        }
//    }
//    catch (Exception ex)
//    {
//        throw new LogException("No se ha podido escribir en el archivo", ex);
//    }
//}

