using IntelipostMiddleware.Integrations.Intelipost.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IntelipostMiddleware.API.TrackingValidations
{
    public class PostEntityValidation : DefaultValidator<OrderTrackingInformation>
    {

        public PostEntityValidation(OrderTrackingInformation data, ModelStateDictionary state) :base(data, state)
        {
        }

        private void ValidateOrderID()
        {
            if (!this.data.Order_id.HasValue)
            {
                this.dictionary.AddModelError("order_id", "Invalid value.");
            }
        }

        private void ValidateStatusID()
        {
            if (!this.data.Event.Status_id.HasValue)
            {
                this.dictionary.AddModelError("Status_id", "Invalid value.");
            }
        }

        private void ValidateDate()
        {
            if (!this.data.Event.Date.HasValue)
            {
                this.dictionary.AddModelError("date", "Invalid value.");
            }
        }

        public override bool IsValid()
        {
            this.ValidateDate();
            this.ValidateOrderID();
            this.ValidateStatusID();
            return this.dictionary.IsValid;
        }
    }
}
