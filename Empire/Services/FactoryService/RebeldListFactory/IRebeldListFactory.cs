using System.Collections.Generic;
using System.Collections.Specialized;
using EmpireTest.Models;

namespace EmpireTest.Services.FactoryService.RebeldListFactory
{
    public interface IRebeldListFactory
    {
        IEnumerable<Rebelds> CreateListRebelds(StringCollection collection);
    }
}
