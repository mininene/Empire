using System;
using System.Collections.Specialized;
using EmpireTest.InfraestructureTransversal.ControllerException;
using EmpireTest.Services.LogService;
using EmpireTest.Services.Repository;
using Microsoft.AspNetCore.Mvc;
//using Moq;
//using Empire.Filters;

namespace EmpireTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RebeldsController : ControllerBase
    {
        private readonly IRepositoryRebelds _repository;
        private readonly ILog _log;
     

       public RebeldsController(IRepositoryRebelds repository, ILog log)
        {
            _repository = repository;
            _log = log;

        }

         
        [HttpGet]
        public IActionResult Get(IRepositoryRebelds _repository)
        {
            try
            {
                var result = String.Empty;
                var listRebelds = _repository.Lista;


                foreach (var obj in listRebelds)
                {
                    result = result + $"Nombre {obj.Name} on Planet {obj.Name}" + Environment.NewLine;

                }
                _log.WriteLog("Datos leidos correctamente");
                return Ok(result);
            }
            catch (ControllerException)
            {
                _log.WriteLog("Error al leer los datos");
                throw new ControllerException("Error inesperado");
            }

        }

     

        [HttpPost("/api/rebelde/post")]
        public IActionResult Post(StringCollection rebeldes)
        {

            try
            {
                _repository.CreateStringCollection(rebeldes);
                _log.WriteLog("Datos grabados correctamente");
                return Ok(true);
            }
            catch (ControllerException)
            {
                _log.WriteLog("Error al grabar los datos");
                return BadRequest("Error inesperado");
                throw new ControllerException("Error inesperado");
                
            }

        }

       






















    }
}