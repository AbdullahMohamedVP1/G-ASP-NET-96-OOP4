using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        // sealed override محدش يقدر يعمل override تاني على الميثود دي في أي كلاس هيرث منها
        public sealed override string GenerateCustomsReport()
        {
            return $"[PRIORITY] {base.GenerateCustomsReport()}";
        }
    }
}
