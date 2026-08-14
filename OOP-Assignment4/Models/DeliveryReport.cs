using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    internal static class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()} EGP");
        }
    }
}
