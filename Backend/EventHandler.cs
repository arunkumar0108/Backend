using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{

    // Instead of custom delegates, use built-in pattern:
    // EventHandler
    // EventHandler<TEventArgs>
    // Why this pattern?
    // 1. Standard across.NET
    // 2. Easy to extend
    // 3. Clean architecture

    class OrderEventArgs : EventArgs
    {
        public string? OrderId { get; set; }
    }

    // Publisher
    class OrderService
    {
        public event EventHandler<OrderEventArgs>? OnOrderPlaced;

        public void PlaceOrder(string id)
        {
            Console.WriteLine("Order created");

            OnOrderPlaced?.Invoke(this, new OrderEventArgs { OrderId = id });
        }
    }

    // Subscribers
    class EmailService
    {
        public void SendEmail(object? sender, OrderEventArgs? e)
        {
            Console.WriteLine($"Email sent for {e?.OrderId}");
        }
    }
    class SmsService
    {
        public void SendSms(object? sender, OrderEventArgs? e)
        {
            Console.WriteLine($"SMS sent for {e?.OrderId}");
        }
    }

    // Additionaly add logging, inventory update, etc.
}

