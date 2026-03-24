using Backend;

namespace Backend
{
    public class Button
    {
        // Declare an event using a delegate type
        public event EventHandler? OnClick;

        public void Click()
        {
            Console.WriteLine("Button clicked!");
            OnClick?.Invoke(this, EventArgs.Empty); // Raise the event
        }
    }

    public class Program
    {
        public delegate int MyDelegate(int a, int b);
        public delegate bool Filter(int x);
        public delegate void Callback();

        // MyDelegate method
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return (x - y);
        }

        // Normal method to print numbers based on a filter
        static void PrintNumbers(List<int> list, Filter filter)
        {
            foreach (var num in list)
            {
                if (filter(num))
                    Console.WriteLine(num);
            }
        }

        // Callback function in Delegate
        static void DoWork(Callback callback)
        {
            Console.WriteLine("Work started...");
            callback();
        }

        static void Main()
        {
            // Custom Exception Practice            
            CustomException customException = new CustomException();
            Console.Write("Enter Amount to Withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            customException.Withdarw(withdrawAmount);

            RvsUserIdValidation rvsUserId = new RvsUserIdValidation();
            Console.Write("Enter User Id: ");
            string? UserId = Console.ReadLine();
            rvsUserId.UserNameValidation(UserId);

            RvsUserNameValidation rvsUserName = new RvsUserNameValidation();
            Console.Write("Enter User Name: ");
            string? userName = Console.ReadLine();
            rvsUserName.UserNameValidation(userName);

            RvsUserNameDuplicateValidation rvsUserNameDuplicate = new RvsUserNameDuplicateValidation();
            Console.Write("Enter User Name for Duplication check: ");
            string? checkUserName = Console.ReadLine();
            rvsUserNameDuplicate.UserNameDuplicateValidation(checkUserName);


            // EventHandler example
            RvsAccountCreate order = new RvsAccountCreate();
            EmailNotificationService email = new EmailNotificationService();
            SmsNotificationService sms = new SmsNotificationService();
            order.OnAccountCreated += email.SendEmail;
            order.OnAccountCreated += sms.SendSms;
            order.AccountCreate("RVS Account Number: 246672");

            DoWork(() => Console.WriteLine("Work completed!"));

            List<int> numbers = new List<int>();
            PrintNumbers(numbers, x => x > 5);
            PrintNumbers(numbers, x => x % 2 == 0);

            Console.WriteLine(numbers);

            Program program = new Program();

            MyDelegate del = program.Add; // store method
            MyDelegate del1 = program.Sub; // store method
            int result = del(5, 3); // call method
            int result1 = del1(5, 3); // call method

            Console.WriteLine(result);
            Console.WriteLine(result1);

            // Hashcode - unique identifier for an object
            string name = "Kumar";
            int hashCode = name.GetHashCode(); // → oru unique number kedaikum
            Console.WriteLine(hashCode); // e.g: 1823746

            Calculator calc = new Calculator();
            int calculateResult = calc.Add(10, 5);
            Console.WriteLine(calculateResult);

            // Linq
            List<int> numerics = new List<int>() { 1, 2, 3, 4, 5 };

            var resultLinq = numbers.Where(x => x > 3).ToList();
            Console.WriteLine(string.Join(", ", resultLinq));

            // Event handling
            Button btn = new Button();

            // Subscribe to the event
            btn.OnClick += HandleClick;

            btn.Click(); // Output: Button clicked! → Handler called!
        }

        static void HandleClick(object? sender, EventArgs e)
        {
            Console.WriteLine("Handler called!");
        }
    }
}
