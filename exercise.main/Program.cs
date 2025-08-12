// See https://aka.ms/new-console-template for more information
using exercise.main;
using exercise.main.Product;

Console.WriteLine("Hello, World!");

Basket basket = new Basket();
Inventory inventory = new Inventory();
Bagel bagel = inventory.getPlainBagel();
for (int i = 0; i < 4; i++)
{
    basket.Add(bagel);
}

Console.WriteLine(basket.printReceipt());
