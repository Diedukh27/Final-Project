﻿Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр мови
Console.Clear(); // очищення консолі

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

public class Pizza
{
    // властивості продукта
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double size { get; set;}
    
}



