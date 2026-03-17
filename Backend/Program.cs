using Backend;

class Program
{
    static void Main()
    {

        Student student = new Student("John", 23, "Computer Science");
        student.StudentDetails();

        TaskBeginner taskBeginner = new TaskBeginner();
        taskBeginner.VarTask();
        taskBeginner.DataTypeTask();
        taskBeginner.OperatorTask();
        taskBeginner.IfElseTask();
        taskBeginner.SwitchTask();
        taskBeginner.ForLoopTask();
        taskBeginner.WhileLoopTask();
        taskBeginner.ArrayTask();
        taskBeginner.AddNumbers(5, 5);

        PracticeMethodTypes practiceMethodTypes = new PracticeMethodTypes();
        practiceMethodTypes.StringTypePractice();

        EncapsulationPractice practice = new EncapsulationPractice();
        var balance = practice.Balance = 500;

        Console.WriteLine($"Current Balance: {practice.Balance}");

        double amount;

        if (double.TryParse(Console.ReadLine(), out amount))
        {
            practice.Deposit(ref amount);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        if (balance > amount)
        {
            Console.WriteLine($"Deposit after current Balance: {practice.Balance}");
        }
        else
        {
            Console.WriteLine("Not Deposited enter valid amount.");
        }


        List<User> users = new List<User>()
        {
            new User { Name="Jack", Age=25 },
            new User { Name="John", Age=17 },
            new User { Name="David", Age=30 }
        };

        //Adults filter
        var adults = users.Where(x => x.Age >= 18);
        Console.WriteLine("Adults: " + string.Join(" | ", adults.Select(x => x.Age)));

        //Names only
        var names = users.Select(x => x.Name);
        Console.WriteLine("Names: " + string.Join(" | ", names));

        //Age descending
        var sorted = users.OrderByDescending(x => x.Age);
        Console.WriteLine("Sorted: " + string.Join(" | ", sorted.Select(x => x.Age)));

        //Eligible Wise
        var eligibleAge = users.Where(x => x.Age >= 18);
        Console.WriteLine("Eligibled Age: " + string.Join(" | ", eligibleAge.Select(x => x.Age)));
    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
}