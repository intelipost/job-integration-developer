using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace IntelipostMiddleware.API.Validation
{
    public abstract class ValidationManager<T> : IValidationManager
    {
        protected T subject;
        protected List<Validation.IValidator> validators;

        public ValidationManager(T subject)
        {
            this.subject = subject;
            this.validators = new List<IValidator>();
        }

        public virtual bool Validate(ModelStateDictionary state)
        {
            this.RegisterValidators();

            foreach (var validator in this.validators)
            {
                if (!validator.IsValid())
                    return false;
            }

            return true;
        }

        protected abstract void RegisterValidators();
    }
}
