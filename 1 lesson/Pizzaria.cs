using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _1_lesson
{
    public class Pizzaria
    {
        List<Pizza> items = new()
        {
           new Pizza() { Name = "Margarita", Description = "Chesse, Tomato", Price = 12, size = 30},
           new Pizza() { Name = "Myasna", Description = "Shynka, Salyami ", Price = 20, size = 40 }
         };

        List<CustomPizza> itemss = new();


        public void AddNewPizza()
        {
            Pizza newItem = new();
            newItem.AddPizza();
            items.Add(newItem);
        }

        public void RemoveNewPizza()
        {
            Console.Write("Enter Pizza name to search: ");
            string name2 = Console.ReadLine();

            // логіка пошуку продукта
            var found2 = items.Find(x => x.Name == name2);
            if (found2 == null)
            {
                Console.WriteLine("Pizza not found!");

            }

            items.Remove(found2);
        }

        public void AddNewCustomPizza()
        {
            CustomPizza newItems = new();
            newItems.AddPizza();
            itemss.Add(newItems);
        }

        public void SavePizza()
        {
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText("database.json", json);

            var json2 = JsonSerializer.Serialize(itemss);
            File.WriteAllText("database.json", json);
        }

        public void LoadPizzaInFail()
        {
            var jsonData = File.ReadAllText("database.json");
            items = JsonSerializer.Deserialize<List<Pizza>>(jsonData);

            var jsonData2 = File.ReadAllText("CustomPizza.json");
            itemss = JsonSerializer.Deserialize<List<CustomPizza>>(jsonData2);
        }

        public void ForeachPizza()
        {
            foreach (Pizza item in items)
                item.Show();
        }

        public void ForeachCustomPizza()
        {
            foreach (CustomPizza item in itemss)
                item.Show();
        }

        public void FindPizza()
        {
            Console.Write("Enter Pizza name to search: ");
            string name = Console.ReadLine();

            // логіка пошуку продукта
            var found = items.Find(x => x.Name == name);
            if (found == null)
            {
                Console.WriteLine("Pizza not found!");
            }

            found.Show();
        }

        public void BuyPizza()
        {
            Console.Write("Enter Pizza name to buy: ");
            string name3 = Console.ReadLine();

            var prodToBuy = items.Find(x => x.Name == name3);
            if (prodToBuy == null)
            {
                Console.WriteLine("Pizza not found!");
                    
            }

            Console.WriteLine("Your pizza will be ready in 20 minutes.");
        }












    }
}
