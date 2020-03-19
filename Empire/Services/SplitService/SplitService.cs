using EmpireTest.InfraestructureTransversal.ServicesException;

namespace EmpireTest.Services.SplitService
{
    public class SplitService : ISplitService
    {
        public string[] Convert(string cadena, char caracter)
        {
            var arrayString = cadena.Split(caracter);

            if (arrayString.Length == 1 )
            {
                throw new SplitException("No se ha podido separar la cadena por '" + caracter + "'");
            }

            return arrayString;
        }
    }
}
