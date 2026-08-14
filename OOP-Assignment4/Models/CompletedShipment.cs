using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public sealed class CompletedShipment : Shipment
    {
        public override string ShipmentType => "Completed Shipment";

        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        // Implement the abstract EstimatedCost property from Shipment.
        // Currently returns DeliveryFee; change the expression if you need a different calculation.
        public override decimal EstimatedCost => DeliveryFee;

        public override void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
