

using System.Text.Json;


Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр мови
Console.Clear(); // очищення консолі












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
            
            break;

    case 2:
            
            break;

        case 22:
           
            break;

        case 5:
            
            break;

        case 52:
           
            break;





    case 7:
            
            break;

    case 72:
            
            break;

   case 8:
           
            break;

            case 10:
           
            break;  
    }



    Console.WriteLine("Натистінь щось для продовження...");
    Console.ReadKey();

}


public class CustomPizza : Pizza
{
    public string NameClientt { get; set; }

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
        NameClientt = (Console.ReadLine());

    }
    public void Show()

    {
        Console.WriteLine("------ Pizza ------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}$");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"size: {size}%");
        Console.WriteLine($"NameClient: {NameClientt}%");

    }


}








