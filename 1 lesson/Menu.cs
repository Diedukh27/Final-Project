
public class Menu
{
    public void ShowAdminMenu()
    {
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
    }
    public void ShowUserMenu()
    {
        Console.WriteLine("\tUSER MENU\n" +
                          "0. Exit\n" +
                          "1. Order Pizza\n" +
                          "2. Order Custom Pizza");
        Console.WriteLine("______________________________");
    }
    public void ShowLoginMenu()
    {
        Console.WriteLine("\tCHOOSE YOUR ROLE\n" +
                          "0. Exit\n" +
                          "1. User\n" +
                          "2. Admin\n");
        Console.WriteLine("______________________________");
    }

    public int AskUserInput()
    {
        Console.Write("Your choice: ");
        return int.Parse(Console.ReadLine());
    }
}
