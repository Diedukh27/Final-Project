

using System.Text.Json;


Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр мови
Console.Clear(); // очищення консолі
List<Pizza> items = new()
{
    new Pizza() { Name = "Margarita", Description = "Chesse, Tomato", Price = 12, size = 30},
    new Pizza() { Name = "Myasna", Description = "Shynka, Salyami ", Price = 20, size = 40 }
};

List<CustomPizza> itemss = new(); 










while (true)
{
    Console.Clear();
    Console.WriteLine("------------- Welcome to Pizzaira! -------------");

Console.WriteLine("\tADMIN MENU\n" +
                  "1. Add New Pizza\n" +
                  "2. Delete Pizza\n" +
                  "3. Add Pizza Product\n" +
                  "4. Detele Product Pizza\n" +
                  "5. Збереження бази піц у файлі\n" +
                  "6. Завантаження бази піц з файлу\n" +
                  "7. Перегляд  готових піц(складників, ціни)\n" +
                  "8. Пошук піц по складникам\n" +
                  "9. Замовлення піци клієнтом(ами), враховуючи можливе складання піци клієнтом\n" +
                  "10. Розрахунок клієнта(друк чеку, прийом оплати)");
Console.WriteLine("______________________________");

Console.Write("your choice:");
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
         case 0: Console.WriteLine("Have a good day");
            return 0;


    case 1:
            Pizza newItem = new();
            newItem.AddPizza();
            items.Add(newItem);
            break;

    case 2:
            Console.Write("Enter Pizza name to search: ");
            string name2 = Console.ReadLine();

            // логіка пошуку продукта
            var found2 = items.Find(x => x.Name == name2);
            if (found2 == null)
            {
                Console.WriteLine("Pizza not found!");
                break;
            }

            items.Remove(found2);
            break;

        case 22:
            CustomPizza newItems = new();
            newItems.AddPizza();
            itemss.Add(newItems);
            break;

        case 5:
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText("database.json", json);

            var json2 = JsonSerializer.Serialize(itemss);
            File.WriteAllText("database.json", json);
            break;

        case 52:
            var jsonData = File.ReadAllText("database.json");
            items = JsonSerializer.Deserialize<List<Pizza>>(jsonData);

            var jsonData2 = File.ReadAllText("CustomPizza.json");
            itemss = JsonSerializer.Deserialize<List<CustomPizza>>(jsonData2);
            break;





    case 7:
            foreach (Pizza item in items)
                item.Show();
            break;

    case 72:
            foreach (CustomPizza item in itemss)
                item.Show();
            break;

   case 8:
            Console.Write("Enter Pizza name to search: ");
            string name = Console.ReadLine();

            // логіка пошуку продукта
            var found = items.Find(x => x.Name == name);
            if (found == null)
            {
                Console.WriteLine("Pizza not found!");
                break;
            }

            found.Show();
            break;

            case 10:
            Console.Write("Enter Pizza name to buy: ");
            string name3 = Console.ReadLine();

            var prodToBuy = items.Find(x => x.Name == name3);
            if (prodToBuy == null)
            {
                Console.WriteLine("Pizza not found!");
                break;
            }

            Console.WriteLine("Your pizza will be ready in 20 minutes.");
            break;  
    }



    Console.WriteLine("Натистінь щось для продовження...");
    Console.ReadKey();

}


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








