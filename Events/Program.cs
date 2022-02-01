using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Services;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order() { Plates = new List<string>() };
            OrderProcessor orderProcessor = new OrderProcessor();

            StarterService starterService = new StarterService() { Name = "Pancakes with banana and honey" };
            MainDishService mainDishService = new MainDishService() { Name = "Fish and chips" };
            DessertService dessertService = new DessertService() { Name = "Chocolate ice-cream" };

            order.Plates.Add(starterService.Name);
            order.Plates.Add(mainDishService.Name);
            order.Plates.Add(dessertService.Name);

            orderProcessor.OrderProcessed += starterService.OnOrderProcessed;
            orderProcessor.OrderProcessed += mainDishService.OnOrderProcessed;
            orderProcessor.OrderProcessed += dessertService.OnOrderProcessed;

            orderProcessor.Process(order);
        }
    }
}
