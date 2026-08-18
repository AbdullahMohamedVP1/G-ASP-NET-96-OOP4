using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        private decimal customsFee;
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override string ShipmentType => "International Shipment";
        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public virtual string GenerateCustomsReport()
        {
            return $"Customs Report - Country: {DestinationCountry}, Fee: {CustomsFee} EGP";
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine(ShipmentType);
            Console.WriteLine();
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
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
            return EstimatedCost * 0.12m;
        }
    }
}
