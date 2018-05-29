using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.CustomValidations
{
    public class QuantityValidation : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var movie = (Movie)validationContext.ObjectInstance;


            if (movie.Quantity <= Movie.Zero || movie.Quantity > Movie.Max)
            {

                return new ValidationResult("Quantity needs to be between 1 or 20 ");
            }

            return ValidationResult.Success;
        }

    }
}