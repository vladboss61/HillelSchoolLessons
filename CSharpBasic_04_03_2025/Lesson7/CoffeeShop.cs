using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Lesson7;

class CoffeeShop
{
    private Dictionary<string, double> _menu;
    private Dictionary<string, int> _cart;

    public CoffeeShop()
    {
        _menu = new Dictionary<string, double>
        {
            { "Espresso", 2.5 },
            { "Latte", 3.5 },
            { "Cappuccino", 3.0 },
            { "Tea", 2.0 },
            { "Croissant", 2.5 },
            { "Muffin", 3.0 }
        };

        _cart = new Dictionary<string, int>();
    }

    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Меню кав'ярні:");
        foreach (var item in _menu)
        {
            Console.WriteLine($"{item.Key}: ${item.Value:F2}");
        }
    }

    public void AddToCart(string item, int quantity)
    {
        if (_menu.ContainsKey(item))
        {
            if (_cart.ContainsKey(item))
            {
                _cart[item] = _cart[item] + quantity;
            }
            else
            {
                _cart[item] = quantity;
            }
            Console.WriteLine($"{quantity} x {item} додано до кошика.");
        }
        else
        {
            Console.WriteLine("Такого товару немає в меню.");
        }
    }

    public void ViewCart()
    {
        if (_cart.Count == 0)
        {
            Console.WriteLine("Кошик порожній.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Ваш кошик:");
        double total = 0;
        foreach (var item in _cart)
        {
            double price = _menu[item.Key] * item.Value;
            total += price;
            Console.WriteLine($"{item.Key} x {item.Value}: ${price:F2}");
        }
        Console.WriteLine($"Загальна сума: ${total:F2}");
    }

    public void PlaceOrder()
    {
        if (_cart.Count == 0)
        {
            Console.WriteLine("Ваш кошик порожній. Додайте товари перед оформленням замовлення.");
            return;
        }

        ViewCart();
        Console.WriteLine("Замовлення оформлено! Дякуємо за покупку.");
        _cart.Clear();
    }
}

class StartProgram
{
    public static void Start()
    {
        CoffeeShop shop = new CoffeeShop();

        bool isFinish = false;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Переглянути меню");
            Console.WriteLine("2. Додати до кошика");
            Console.WriteLine("3. Переглянути кошик");
            Console.WriteLine("4. Оформити замовлення");
            Console.WriteLine("5. Вийти");
            Console.Write("Виберіть опцію: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    shop.DisplayMenu();

                    break;
                case "2":
                    Console.Write("Введіть назву товару: ");
                    string item = Console.ReadLine();
                    Console.Write("Введіть кількість: ");

                    int quantity = int.Parse(Console.ReadLine());
                    shop.AddToCart(item, quantity);
                    
                    break;
                case "3":
                    shop.ViewCart();
                    break;
                case "4":
                    shop.PlaceOrder();
                    break;
                case "5":
                    Console.WriteLine("Дякуємо, що відвідали нашу кав'ярню!");
                    isFinish = true;
                    break;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }

            if (isFinish)
            {
                break;
            }
        }
    }
}
