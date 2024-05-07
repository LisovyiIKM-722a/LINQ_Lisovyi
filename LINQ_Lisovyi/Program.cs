using System;
using System.Collections.Generic;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
{
new Product { Id = 1, Name = "Ноутбук", Category = "Електронiка", Price = 1200 },
new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
new Product { Id = 4, Name = "Смартфон", Category = "Електронiка", Price = 800 },
new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
new Product { Id = 7, Name = "Телевiзор", Category = "Електронiка", Price = 1500 },
new Product { Id = 8, Name = "Кросiвки", Category = "Взуття", Price = 80 },
new Product { Id = 9, Name = "Пiча", Category = "Їжа", Price = 10 },
new Product { Id = 10, Name = "Монiтор", Category = "Електронiка", Price = 300 },
new Product { Id = 11, Name = "Свiтшот", Category = "Одяг", Price = 35 },
new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
new Product { Id = 14, Name = "Чайник", Category = "Побутова технiка", Price = 40 },
new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
new Product { Id = 16, Name = "Мишка", Category = "Електронiка", Price = 10 },
new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
new Product { Id = 19, Name = "Кавоварка", Category = "Побутова технiка", Price = 60 },
new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
};
        //1. Вибрати всі товари з категорії "Електроніка".
        var electronics = products.Where(p => p.Category == "Електронiка").ToList();

        foreach (var product in electronics)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Цiна: {product.Price}");
        }
        //2. Знайти найдорожчий товар.
        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).First();

        Console.WriteLine($"Найдорожчий товар: ID: {mostExpensiveProduct.Id}, Назва: {mostExpensiveProduct.Name}, Категорiя: {mostExpensiveProduct.Category}, Цiна: {mostExpensiveProduct.Price}");
        //3. Підрахувати загальну вартість всіх товарів.
        double totalCost = products.Sum(p => p.Price);

        Console.WriteLine($"Загальна вартiсть всiх товарiв: {totalCost}");
        //4. Відсортувати товари за ціною у зростаючому порядку.
        var sortedProducts = products.OrderBy(p => p.Price).ToList();

        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //5. Вибрати унікальні категорії товарів.
        var uniqueCategories = products.Select(p => p.Category).Distinct().ToList();

        foreach (var category in uniqueCategories)
        {
            Console.WriteLine(category);
        }
        //6. Знайти кількість товарів у кожній категорії.
        var categoryCounts = products.GroupBy(p => p.Category)
                             .Select(g => new { Category = g.Key, Count = g.Count() })
                             .ToList();

        foreach (var item in categoryCounts)
        {
            Console.WriteLine($"Категорiя: {item.Category}, Кiлькiсть товарiв: {item.Count}");
        }
        //7.Вибрати товари з назвами, які починаються на букву "С".
        var productsStartingWithS = products.Where(p => p.Name.StartsWith("С")).ToList();

        foreach (var product in productsStartingWithS)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //8. Знайти середню ціну товарів.
        double averagePrice = products.Average(p => p.Price);

        Console.WriteLine($"Середня цiна товарiв: {averagePrice}");
        //9. Вибрати товари, ціна яких менше 50.
        var cheapProducts = products.Where(p => p.Price < 50).ToList();

        foreach (var product in cheapProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //10.Підрахувати кількість товарів з ціною більше 100.
        int expensiveProductCount = products.Count(p => p.Price > 100);

        Console.WriteLine($"Кiлькiсть товарiв з цiною бiльше 100: {expensiveProductCount}");
        //11.Вибрати перші 5 товарів.
        var firstFiveProducts = products.Take(5).ToList();

        foreach (var product in firstFiveProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //12.Повернути останній товар.
        var lastProduct = products.Last();

        Console.WriteLine($"Останнiй товар: ID: {lastProduct.Id}, Назва: {lastProduct.Name}, Категорiя: {lastProduct.Category}, Цiна: {lastProduct.Price}");
        //13.Вибрати товари з категорії "Їжа" та відсортувати їх за зростанням ціни.
        var foodProductsSortedByPrice = products.Where(p => p.Category == "Їжа").OrderBy(p => p.Price).ToList();

        foreach (var product in foodProductsSortedByPrice)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //14.Повернути імена товарів в верхньому регістрі.
        var productNamesInUpperCase = products.Select(p => p.Name.ToUpper()).ToList();

        foreach (var name in productNamesInUpperCase)
        {
            Console.WriteLine(name);
        }
        //15.Вибрати товари, ціна яких лежить у діапазоні від 10 до 100.
        var productsInRange = products.Where(p => p.Price >= 10 && p.Price <= 100).ToList();

        foreach (var product in productsInRange)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //16.Знайти найменшу ціну серед товарів.
        double minPrice = products.Min(p => p.Price);

        Console.WriteLine($"Найменша цiна серед товарiв: {minPrice}");
        //17.Вибрати товари, що містять слово "Кава" в назві.
        var coffeeProducts = products.Where(p => p.Name.Contains("Каво")).ToList();

        foreach (var product in coffeeProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }
        //18.Підрахувати загальну кількість товарів.
        int totalProductCount = products.Count;

        Console.WriteLine($"Загальна кiлькiсть товарiв: {totalProductCount}");
        //19.Знайти товар з найменшим ідентифікатором.
        int minId = products.Min(p => p.Id);
        Product productWithMinId = products.First(p => p.Id == minId);

        Console.WriteLine($"Товар з найменшим iдентифiкатором: ID: {productWithMinId.Id}, Назва: {productWithMinId.Name}, Категорiя: {productWithMinId.Category}, Цiна: {productWithMinId.Price}");
        //20.Вибрати товари, назви яких містять лише одне слово.
        var singleWordNameProducts = products.Where(p => !p.Name.Contains(" ")).ToList();

        foreach (var product in singleWordNameProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }

    }
}
