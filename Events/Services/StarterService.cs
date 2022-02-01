using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Services
{
    public class StarterService
    {
        public string Name { get; set; }
        public void OnOrderProcessed(object orderProcessor, OrderEventArgs args)
        {
            Console.WriteLine("Starter processed, sir!");
        }
    }
}
