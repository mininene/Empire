using System;
using System.ComponentModel.DataAnnotations;
using EmpireTest.Models;

namespace EmpireTest.Services.ValidationService
{
    public class ValidationRegisterSpecification : IValidationRegisterSpecification
    {
        public bool IsSatisfiedBy(ICitizen registroRebelde)
        {
               
            var resultado = false;
            try
            {
                if (!string.IsNullOrEmpty(registroRebelde.Name) && !string.IsNullOrWhiteSpace(registroRebelde.Name)
                    && !string.IsNullOrEmpty(registroRebelde.Planet) && !string.IsNullOrWhiteSpace(registroRebelde.Planet))
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new ValidationException("No se han podido validar los rebeldes", ex);
            }
            return resultado;



        }
    }

}
//string cadena = valor.Name + valor.Planet;
//if (!string.IsNullOrWhiteSpace(cadena))
//{
//    return true;

//} else {
//    return false;}