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

    class AccountCreateEventArgs : EventArgs
    {
        public string? AccountId { get; set; }
    }

    // Publisher
    class RvsAccountCreate
    {
        public event EventHandler<AccountCreateEventArgs>? OnAccountCreated;

        public void AccountCreate(string id)
        {
            Console.WriteLine("Account created");

            OnAccountCreated?.Invoke(this, new AccountCreateEventArgs { AccountId = id });
        }
    }

    // Subscribers
    class EmailNotificationService
    {
        public void SendEmail(object? sender, AccountCreateEventArgs? e)
        {
            Console.WriteLine($"Email sent for {e?.AccountId} from the user");
        }
    }

    class SmsNotificationService
    {
        public void SendSms(object? sender, AccountCreateEventArgs? e)
        {
            Console.WriteLine($"SMS sent for {e?.AccountId} from the user");
        }
    }

    // Additionaly add logging, inventory update, etc.
}
