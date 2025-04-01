public class CustomPizza : Pizza
{
    public string NameClient { get; set; }

    public void AddPizza()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Description: ");
        Description = Console.ReadLine();
        Console.Write("Enter Price: ");
        Price = double.Parse(Console.ReadLine());
        Console.Write("Enter size: ");
        size = double.Parse(Console.ReadLine());
        Console.Write("Enter NameClient: ");
        NameClient = (Console.ReadLine());

    }
    public void Show()

    {
        Console.WriteLine("------ Pizza ------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}$");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"size: {size}%");
        Console.WriteLine($"NameClient: {NameClient}%");

    }


}








