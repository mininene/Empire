using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpireTest.Models
{
   public interface ICitizen
    {
         string Name { get; set; }
         string Planet { get; set;}
    }
}
