using System.Collections.Specialized;
using EmpireTest.Models;


namespace EmpireTest.Services.FactoryService.Rebeldfactory
{
   public interface IRebeldFactory
    {

        Rebelds CreateRebeld(StringCollection collection);
    }
}
