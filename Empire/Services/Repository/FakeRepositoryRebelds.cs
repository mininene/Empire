using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using EmpireTest.InfraestructureTransversal.ServicesException;
using EmpireTest.Models;
using EmpireTest.Services.FactoryService.Rebeldfactory;
using EmpireTest.Services.FactoryService.RebeldListFactory;
using EmpireTest.Services.LogService;
using EmpireTest.Services.SplitService;

namespace EmpireTest.Services.Repository
{
    public class FakeRepositoryRebelds : IRepositoryRebelds
    {

        private readonly IRebeldListFactory _listFactory;
        private readonly IRebeldFactory _factory;
        private readonly ILog _log;
        private readonly DevelopmentLog _developmentLog;
        

        public FakeRepositoryRebelds(DevelopmentLog developmentLog)
        {
            this._developmentLog = developmentLog;
        }

        public FakeRepositoryRebelds( ILog log, IRebeldListFactory listFactory, IRebeldFactory factory)
        {
            _log = log;
            _listFactory = listFactory;
            _factory = factory;
        }


       public IEnumerable<ICitizen> Lista { get; } = new List<ICitizen>()
         {
            new Rebelds("Darius","Saturno"),
            new Rebelds("Volibear","Urano"),
            new Rebelds("Sona","Pluton")

          
        };

    public void CreateStringCollection(StringCollection rebeldes)
        {

            var result = string.Empty;
            try
            {
                var obj = _factory.CreateRebeld(rebeldes);
                List<ICitizen> existingList = Lista.ToList();
                existingList.Add(obj);
                result = existingList.ToString();
                _log.WriteLog(result);
            }
            catch (Exception ex)
            {
                throw new FactoryException("No se ha podido listar todos los rebeldes", ex);
            }
        }
    }
}

