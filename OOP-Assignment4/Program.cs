namespace OOP_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //theoretical
            #region Question1-Abstraction
            //a)  What is Abstraction in Object-Oriented Programming?
            //sol:  Abstraction means hiding unnecessary details showing only the important parts

            //b)  Why is abstraction considered one of the four pillars of OOP ?
            //sol: It is one of the four pillars of OOP because it helps us focus on what an object does
            #endregion

            #region Question2

            //a)  What is the difference between an Abstract Class and an Interface?
            //sol: Abstract Class can have fields - constructors - methods and abstract methods
            // Interface defines a contract that a class must follow

            //b)  When would you choose an Interface instead of an Abstract Class ?
            //sol: We choose an Interface when different classes me behavior

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //sol: A class cannot inherit from multiple abstract classes  But it can implement multiple interfaces

            #endregion

            DeliveryAddress add1 = new DeliveryAddress("Cairo", "Tahrir St", 12);
            StandardShipment std = new StandardShipment("SH001", "Laptop", 3, 95, add1);

            DeliveryAddress add2 = new DeliveryAddress("Alexandria", "Corniche St", 5);
            ExpressShipment exp = new ExpressShipment("SH002", "Phone", 2, 60, add2, 30);

            DeliveryAddress add3 = new DeliveryAddress("Berlin", "Unter den Linden", 1);
            InternationalShipment inational = new InternationalShipment("SH003", "Documents", 2, 50, add3, "Germany", 200);

            std.Status = ShipmentStatus.Ready;
            exp.Status = ShipmentStatus.OutForDelivery;
            inational.Status = ShipmentStatus.Delivered;

            DeliveryCenter center = new DeliveryCenter();
            center.CenterName = "Main Delivery Center";
            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(inational);

            center.PrintAllShipments();

            Console.WriteLine(new string('=', 45));
            Console.WriteLine("Tracking Status");
            Console.WriteLine(new string('=', 45));
            Console.WriteLine();
            center.PrintTrackingStatuses();

            Console.WriteLine();
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("Insurance");
            Console.WriteLine(new string('=', 45));
            Console.WriteLine();
            DeliveryReport.PrintInsurance(std);
            DeliveryReport.PrintInsurance(exp);
            DeliveryReport.PrintInsurance(inational);

            ITrackable[] trackables = { std, exp, inational };
            Console.WriteLine();
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("ITrackable[] Array - Tracking Statuses");
            Console.WriteLine(new string('=', 45));
            foreach (ITrackable t in trackables)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }

            IInsurable[] insurables = { std, exp, inational };
            Console.WriteLine();
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("IInsurable[] Array - Insurance Values");
            Console.WriteLine(new string('=', 45));
            foreach (IInsurable ins in insurables)
            {
                Console.WriteLine($"Insurance: {ins.CalculateInsurance()} EGP");
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            Console.WriteLine(new string('=', 45));

            Console.ReadLine();

        }
    }
}