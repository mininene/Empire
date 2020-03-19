using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using EmpireTest.InfraestructureTransversal.ServicesException;
using EmpireTest.Models;
using EmpireTest.Services.SplitService;

namespace EmpireTest.Services.FactoryService.RebeldListFactory
{
    public class RebeldListFactory : IRebeldListFactory
    {

#pragma warning disable CS0649 // Field 'RebeldListFactory._listRebelds' is never assigned to, and will always have its default value null
        private IEnumerable<Rebelds> _listRebelds;
#pragma warning restore CS0649 // Field 'RebeldListFactory._listRebelds' is never assigned to, and will always have its default value null
        private readonly ISplitService _split;
        private Rebelds Rebeld { get; set; }


        public RebeldListFactory(ISplitService split)
        {
            _split = split;
        }

        public IEnumerable<Rebelds> CreateListRebelds(StringCollection collection)
        {

            try
            {
                foreach (var item in collection)
                {
                    var cadena = _split.Convert(item, ',');
                    _listRebelds.Append(Rebeld = new Rebelds(cadena[0], cadena[1]));
                }
            }
            catch (Exception ex)
            {
                throw new FactoryException("No se ha podido crear la lista de rebeldes", ex);
            }

            return _listRebelds;
        }

        
    }
}
