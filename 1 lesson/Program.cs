using _1_lesson;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр мови
Console.Clear(); // очищення консолі


Menu menu = new ();
Pizzaria p = new ();

menu.ShowLoginMenu();
int roleChoice = menu.AskUserInput();

if (roleChoice == 1)
{
    Console.Clear(); // очищення консолі
    Console.WriteLine("------------- Welcome to Pizzaria for User! -------------");

    menu.ShowUserMenu();
    int choice = menu.AskUserInput();

    p.LoadPizzaInFail();

    switch (choice)
    {
        case 0: return 0;
        case 1:
            Console.WriteLine("You can buy something!");
            p.ForeachPizza();
            p.ForeachCustomPizza();
            p.BuyPizza();
            break;
    }
}


if (roleChoice == 2)
{
    while (true)
    {
        Console.Clear(); // очищення консолі
        Console.WriteLine("------------- Welcome to Supermarket for Admin! -------------");

        menu.ShowAdminMenu();
        int choice = menu.AskUserInput();

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
}

Console.WriteLine("Гарного дня!");
return 0;







