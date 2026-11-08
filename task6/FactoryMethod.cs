using System;

namespace Task6.FactoryMethod
{

    interface ITransport
    {
        void Deliver();
    }

    class Truck : ITransport
    {
        public void Deliver() => Console.WriteLine("Доставка по суші вантажівкою.");
    }

    class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("Доставка морем на вантажному судні.");
    }

    abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            ITransport transport = CreateTransport();
            transport.Deliver();
        }
    }

    class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Truck();
    }

    class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Ship();
    }

    class Program
    {
        public static void Run()
        {
            Console.WriteLine("--- Factory Method ---");
            Logistics logistics1 = new RoadLogistics();
            logistics1.PlanDelivery();

            Logistics logistics2 = new SeaLogistics();
            logistics2.PlanDelivery();
        }
    }
}