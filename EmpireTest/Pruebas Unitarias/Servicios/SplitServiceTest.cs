using EmpireTest.InfraestructureTransversal.ServicesException;
using EmpireTest.Services.SplitService;
using NUnit.Framework;


namespace EmpireTest.Pruebas_Unitarias.Servicios
{
   public class SplitServiceTest
    {

        private SplitService _split;

        private  string _invalidCollection;
        private  string _validCollection;
        private  char _simbol;



        [Test]

        public void StringToArray()
        {
            _invalidCollection =  "abc" ;
            _validCollection = "Darius, Jupiter" ;
            _simbol = ',';
            _split = new SplitService();

           var result= _split.Convert(_validCollection, _simbol);
            Assert.AreEqual(2,result.Length);

        }

        
        [Test]

        public void BadStringToArray()
        {
            _invalidCollection = "xed";
            _simbol = ',';
            _split = new SplitService();

            Assert.Throws<SplitException>(() => _split.Convert(_invalidCollection, _simbol));
        }
        






    }
}
