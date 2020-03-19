using System;
using System.Collections.Specialized;
using EmpireTest.InfraestructureTransversal.ServicesException;
using EmpireTest.Models;
using EmpireTest.Services.SplitService;
using EmpireTest.Services.ValidationService;

namespace EmpireTest.Services.FactoryService.Rebeldfactory
{
    public class RebeldFactory : IRebeldFactory
    {

        private Rebelds _rebelde;
        private readonly IValidationRegisterSpecification _validationRegisterSpecification;
        private readonly ISplitService _split;
          public RebeldFactory(ISplitService split)
        {
            _split = split;
            _validationRegisterSpecification = new ValidationRegisterSpecification();
           
        }

      

        public Rebelds CreateRebeld(StringCollection collection)
        {
            try
            {

                var cadena = _split.Convert(collection[0], ',');
                _rebelde = new Rebelds(cadena[0], cadena[1]);
                if (_validationRegisterSpecification.IsSatisfiedBy(_rebelde) == true)
                {
                    return _rebelde;
                }
                  else { throw new FactoryException("No se ha podido crear el objeto "); }
              
             }
            catch (Exception ex)
            {
                throw new FactoryException("No se ha podido crear el objeto de rebelde", ex);
            }
            return _rebelde;

        }




    }

}
