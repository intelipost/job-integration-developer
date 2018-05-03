using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IntelipostMiddleware.API.Validation
{
    public interface IValidationManager
    {
        bool Validate(ModelStateDictionary state);
    }
}