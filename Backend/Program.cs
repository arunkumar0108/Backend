class Program
{
    static void Main()
    {
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
    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
}