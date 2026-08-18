using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public override string ShipmentType => "Standard Shipment";

        // Constructor Chaining - بينادي على constructor الأب
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => DeliveryFee;

        public override void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public string GetTrackingStatus()
        {
            switch (Status)
            {
                case ShipmentStatus.Ready:
                    return $"Shipment {TrackingCode} is Ready.";
                case ShipmentStatus.OutForDelivery:
                    return $"Shipment {TrackingCode} is Out for Delivery.";
                case ShipmentStatus.Delivered:
                    return $"Shipment {TrackingCode} has been Delivered.";
                default:
                    return $"Shipment {TrackingCode} status is unknown.";
            }
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}
