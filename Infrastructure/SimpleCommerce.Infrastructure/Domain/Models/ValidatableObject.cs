using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Infrastructure.Domain.Models
{
    public abstract class ValidatableObject
    {
        public virtual bool IsValid()
        {
            return ValidationResults().Count == 0;
        }

        public virtual IList<ValidationResult> ValidationResults()
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this, null, null), validationResults, true);
            return validationResults;
        }
    }
}