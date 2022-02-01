using System;
using System.Threading;

namespace Events
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
    public class OrderProcessor
    {
        // public delegate void OrderEventHandler(object source, OrderEventArgs args);
        public event EventHandler<OrderEventArgs> OrderProcessed;  //built-in alternative to the line code above

        public void Process(Order order)
        {
            Console.WriteLine("Processing the order, sir!");
            Thread.Sleep(3000);

            OnOrderProcessed(order);
        }

        protected virtual void OnOrderProcessed(Order order)
        {
            if (OrderProcessed != null)
            {
                TellPlates(order);
                Thread.Sleep(3000);
                OrderProcessed(this, new OrderEventArgs() { Order = order });
            }
        }

        private void TellPlates(Order order)
        {
            Console.WriteLine("\nThis is your order, sir!\n");
            foreach (string plate in order.Plates)
            {
                Console.WriteLine($"You ordered {plate}");
            }
        }
    }
}
