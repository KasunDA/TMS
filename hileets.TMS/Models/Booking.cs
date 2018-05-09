using System;
namespace hileets.TMS.Models
{
    public class Booking
    {
        private Route _route { get; set; }
        private bool _paymentStatus { get; set; }

        public Booking(Route route, bool paymentStatus)
        {
            this._route = route;
            this._paymentStatus = paymentStatus;
        }

    }
}
