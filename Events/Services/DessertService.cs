using System;

namespace Events.Services
{
    public class DessertService
    {
        public string Name { get; set; }
        public void OnOrderProcessed(object orderProcessor, OrderEventArgs args)
        {
            Console.WriteLine("Dessert processed, sir!");
        }
    }
}
