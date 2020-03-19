using System.Collections.Specialized;
using NUnit.Framework;
using EmpireTest.Controllers;
using EmpireTest.Services.Repository;
using EmpireTest.Services.LogService;

namespace EmpireTest.Pruebas_Unitarias.Controller
{
    public class RebeldControllerTest
    {
      //  public  Mock<IRepositoryRebelds> _repositoryMock;
       
       private  StringCollection _invalidRebelCollection;
        private  StringCollection _validRebelCollection;
        private RebeldsController _controller;
        private IRepositoryRebelds _repository;
        private  DevelopmentLog _developmentLog;
#pragma warning disable CS0649 // Field 'RebeldControllerTest._log' bvj is never assigned to, and will always have its default value null
        private  readonly ILog _log;
#pragma warning restore CS0649 // Field 'RebeldControllerTest._log' is never assigned to, and will always have its default value null

        [SetUp]

        public void Inicializar()
        {

           _developmentLog= new DevelopmentLog();
           _repository = new FakeRepositoryRebelds(_developmentLog);
            _invalidRebelCollection = new StringCollection  { "abc" };
            _validRebelCollection = new StringCollection {"Paco, Murcia"} ;
           _controller = new RebeldsController(_repository,_log);
        }

        [Test]
        
        public void ItReturnsCollection()
        {
             
            RebeldsController miControlador = new RebeldsController(_repository, _developmentLog);
            var lista = miControlador.Get(_repository);
            Assert.IsNotNull(lista);
            
        }

        [Test]
        public void ItHasPostMethod()
        {
           
            RebeldsController miControlador = new RebeldsController(_repository, _developmentLog);
         // var actionResult = miControlador.Post(_validRebelCollection);
           //Assert.IsNotNull(actionResult);
        }

    }
}

