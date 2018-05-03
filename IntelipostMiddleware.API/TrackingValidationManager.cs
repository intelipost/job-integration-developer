using IntelipostMiddleware.API.TrackingValidations;
using IntelipostMiddleware.API.Validation;
using IntelipostMiddleware.Integrations.Intelipost.Models;

namespace IntelipostMiddleware.API
{
    public class TrackingValidationManager : ValidationManager<TrackingController>
    {
        private OrderTrackingInformation model;

        public TrackingValidationManager(TrackingController subject, OrderTrackingInformation model) : base(subject)
        {
            this.model = model;
        }
        
        protected override void RegisterValidators()
        {
            this.validators.Clear();
            this.validators.Add(new PostEntityValidation(this.model, this.subject.ModelState));
        }
    }
}
