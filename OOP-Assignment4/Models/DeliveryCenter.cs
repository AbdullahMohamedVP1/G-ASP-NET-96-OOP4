using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    internal class DeliveryCenter
    {
        public string CenterName { get; set; }
        public Driver Driver { get; set; }
        private Shipment[] shipments;
        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine(new string('=', 50));

            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    Console.WriteLine();
                    s.PrintShipment();
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}
