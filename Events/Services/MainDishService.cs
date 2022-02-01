using System;

namespace Events.Services
{
    public class MainDishService
    {
        public string Name { get; set; }
        public void OnOrderProcessed(object orderProcessor, OrderEventArgs args)
        {
            Console.WriteLine("Main Dish processed, sir!");
        }
    }
}
