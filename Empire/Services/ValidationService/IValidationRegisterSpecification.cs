using EmpireTest.Models;

namespace EmpireTest.Services.ValidationService
{
    public interface IValidationRegisterSpecification
    {
        bool IsSatisfiedBy(ICitizen registroRebelde);
    }
}
