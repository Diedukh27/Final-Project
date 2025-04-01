public class Pizza
{
    // властивості продукта
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double size { get; set;}

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
    }
    public void Show()

    {
        Console.WriteLine("------ Pizza ------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}$");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"size: {size}%");
        
    }


}








