using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment4
{
    public class DeliveryAddress
    {
            public string City;
            public string Street;
            public int BuildingNumber;

            public DeliveryAddress(string city, string street, int buldingNumber)
            {
                City = city;
                Street = street;
                BuildingNumber = buldingNumber;
            }
            public string GetFullAddress()
            {
                return $"city: {City}, street: {Street}, building: {BuildingNumber}";
        }
    }
}
