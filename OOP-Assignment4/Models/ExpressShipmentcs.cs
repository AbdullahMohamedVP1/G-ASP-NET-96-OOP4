using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override string ShipmentType => "Express Shipment";

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
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
            return EstimatedCost * 0.08m;
        }
    }
}
