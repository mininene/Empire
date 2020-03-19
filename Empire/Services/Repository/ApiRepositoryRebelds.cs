using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using EmpireTest.InfraestructureTransversal.ServicesException;
using EmpireTest.Models;
using EmpireTest.Services.FactoryService.Rebeldfactory;
using EmpireTest.Services.FactoryService.RebeldListFactory;
using EmpireTest.Services.LogService;

namespace EmpireTest.Services.Repository
{
    public class ApiRepositoryRebelds : IRepositoryRebelds
    {
        private readonly IRebeldListFactory _listFactory;
        private readonly IRebeldFactory _factory;
        private readonly ILog _log;
        private  DevelopmentLog Log { get; }

        public ApiRepositoryRebelds(ILog log, IRebeldListFactory listFactory, IRebeldFactory factory, DevelopmentLog developmentLog)
        {
            _log = log;
            _listFactory = listFactory;
            _factory = factory;
            Log = developmentLog;
        }
        public IEnumerable<Rebelds> Lista { get; set; }

        IEnumerable<ICitizen> IRepositoryRebelds.Lista => throw new NotImplementedException();

        public void CreateStringCollection(StringCollection rebeldes)
        {
            try
            {
                Rebelds obj = _factory.CreateRebeld(rebeldes);
                var ExistingList = Lista.ToList();
                ExistingList.Add(obj);
                var result = ExistingList.ToString();
                _log.WriteLog(result);
            }
            catch (Exception ex)
            {
                throw new FactoryException("No se ha podido listar todos los rebeldes", ex);
            }
        }

        public void Import()
        {
            using (var client = new HttpClient())
            {


                HttpResponseMessage response = client.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
                string contenido = response.Content.ReadAsStringAsync().Result;
                {
                    // List<Cliente> lista;
                    Lista = JsonConvert.DeserializeObject<List<Rebelds>>(contenido);

                }
            }
        }

    }

}
