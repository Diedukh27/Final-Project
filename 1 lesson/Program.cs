

using _1_lesson;
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

    var p = new Pizzaria();

    switch (choice)
    {
        case 0:
            Console.WriteLine("Have a good day");
            return 0;


        case 1:
            p.AddNewPizza();
            break;

        case 2:
            p.RemoveNewPizza();
            break;

        case 22:
            p.AddNewCustomPizza();
            break;

        case 5:
            p.SavePizza();
            break;

        case 52:
            p.LoadPizzaInFail();
            break;

        case 7:
            p.ForeachPizza();
            break;

        case 72:
            p.ForeachCustomPizza();
            break;

        case 8:
            p.FindPizza();
            break;

        case 10:
            p.BuyPizza();
            break;
    }



    Console.WriteLine("Натистінь щось для продовження...");
    Console.ReadKey();

}




