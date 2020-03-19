using System.Collections.Generic;
using System.Collections.Specialized;
using EmpireTest.Models;

namespace EmpireTest.Services.Repository
{
    public interface IRepositoryRebelds
    {
   
        IEnumerable<ICitizen> Lista { get; }
        void CreateStringCollection(StringCollection rebeldes);


    }
}
