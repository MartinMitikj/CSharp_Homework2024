﻿
using Models.Domain;
using Models.Domain.Enum;
using System.Collections;

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};


static void PrintCollectionItems(IEnumerable collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"{item} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Products with a price greater than $500:");
List<string> requirements1 = products.Where(product => product.Price > 500).Select(product => product.Title).ToList();
PrintCollectionItems(requirements1);

Console.WriteLine("Skincare products:");
List<string> requirements2 = products.Where(product => product.Category == ProductCategory.Skincare).Select(product => product.Title).ToList();
PrintCollectionItems(requirements2);

Console.WriteLine("Products titles:");
List<string> requirements3 = products.Select(product => product.Title).ToList();
PrintCollectionItems(requirements3);

Console.WriteLine("Laptops category:");
List<string> requirements4 = products.Where(product => product.Category == ProductCategory.Laptops).Select(product => product.Title).ToList();
PrintCollectionItems(requirements4);

Console.WriteLine("Stock of less than 50");
List<string> requirements5 = products.Where(product => product.Stock < 50).Select(product => product.Description).ToList();
PrintCollectionItems(requirements5);

Console.WriteLine("Rating above 4.5");
List<string> requirements6 = products.Where(product => product.Rating > 4.6).Select(product => product.Title).ToList();
PrintCollectionItems(requirements6);

Console.WriteLine("Between $100 and $200");
List<string> requirements7 = products.Where(product => product.Price > 100 && product.Price < 200).Select(product => product.Title).ToList();
PrintCollectionItems(requirements7);

Console.WriteLine("Fragrances category with a rating above 4.6");
List<string> requirements8 = products.Where(product => product.Category == ProductCategory.Fragrances && product.Rating > 4.6).Select(product => product.Title).ToList();
PrintCollectionItems(requirements8);

Console.WriteLine("Price above $1000");
List<string> requirements9 = products.Where(product => product.Price > 1000).Select(product => product.Brand).ToList();
PrintCollectionItems(requirements9);

Console.WriteLine("Word perfume in the title.");
List<string> requirements10 = products.Where(product => product.Title.Contains("perfume")).Select(product => product.Title).ToList();
PrintCollectionItems(requirements10);

Console.WriteLine("Last Grocery product");
Product requirements11 = products.LastOrDefault(product => product.Category == ProductCategory.Groceries);
Console.WriteLine(requirements11.Title);

Console.WriteLine();
Console.WriteLine("First product with a price above 1000");
Product requirements12 = products.FirstOrDefault(product => product.Price > 1000);
Console.WriteLine(requirements12.Title);

Console.WriteLine("Groceries category with a stock above 150");
List<string> requirements13 = products.Where(product => product.Category == ProductCategory.Groceries && product.Stock > 150).Select(product => product.Title).ToList();
PrintCollectionItems(requirements13);

Console.WriteLine("First item from the brand Hemani Tea");
Product requirements14 = products.First(product => product.Brand == "Hemani Tea");
Console.WriteLine(requirements14.Title);

Console.WriteLine();
Console.WriteLine("Ratings of all products with a stock between 30 and 50");
List<string> requirements15 = products.Where(product => product.Stock > 30 && product.Stock < 50).Select(product => product.Title).ToList();
PrintCollectionItems(requirements15);

// Bonus

Console.WriteLine("Average price of all products");
List<double> requirements16 = products.Select(product => product.Price).ToList();
Console.WriteLine(requirements16.Average());


Console.WriteLine();
Console.WriteLine("Total stock of all products");
List<int> requirements17 = products.Select(product => product.Stock).ToList();
Console.WriteLine(requirements17.Sum());


Console.WriteLine();
Console.WriteLine("Product with price over 2000");
List<string> requirements18 = products.Where(product => product.Price > 2000).Select(product => product.Title).ToList();
if (requirements18.Any())
{
    PrintCollectionItems(requirements18);
}
else
{
    Console.WriteLine("Nothing");
}

Console.WriteLine();
Console.WriteLine("Most expensive Laptop");
List<Product> requirements19 = products.Where(product => product.Category == ProductCategory.Laptops).ToList();
double expensiv = requirements19.Max(product => product.Price);
Console.WriteLine(expensiv);

Console.WriteLine();
Console.WriteLine("Skincare category");
var skinCare = from product in products
                      where product.Category == ProductCategory.Skincare
                      select product;
foreach (var product in skinCare)
{
    Console.WriteLine($"Title: {product.Title}, Description: {product.Description}");
}