using NUnit.Framework;
using EmpireTest.Models;

namespace EmpireTest.Pruebas_Unitarias.Model
{

    public class ModelTest
    {

        [Test]
        public void RebeldeCorrecto()
        {
            Rebelds rebelde = new Rebelds("Maria", "Mercurio");
            Assert.IsNotNull(rebelde);
            Assert.IsTrue(!string.IsNullOrEmpty(rebelde.Name));
        }


        [Test]
        public void RebeldeIncorrectoPrimerVacio()
        {
            Rebelds rebelde = new Rebelds("", "Saturno");

            Assert.IsNotNull(rebelde);
            Assert.IsTrue(string.IsNullOrEmpty(rebelde.Name));
        }

        [Test]
        public void RebeldeIncorrectoSegundoVacio()
        {
            Rebelds rebelde = new Rebelds("Maria", "");

            Assert.IsNotNull(rebelde);
            Assert.IsTrue(string.IsNullOrEmpty(rebelde.Planet));
        }

        [Test]
        public void RebeldeIncorrectoVacio()
        {
            Rebelds rebelde = new Rebelds("","");

            Assert.IsNotNull(rebelde);
            Assert.IsTrue(string.IsNullOrEmpty(rebelde.Planet));
        }

    }

}
