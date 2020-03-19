namespace EmpireTest.Models
{
    public class Rebelds : ICitizen
    {


        public string Name { get; set; }
        public string Planet { get; set; }

        public Rebelds(string name, string planet)
        {

            Name = name;
            Planet = planet;
        }

    }
}
