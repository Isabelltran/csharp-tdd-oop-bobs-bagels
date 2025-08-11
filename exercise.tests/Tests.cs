using exercise.main;
using exercise.main.Product;

namespace exercise.tests;

public class Tests
{
    

    [Test]
    public void AddTest()
    {
        Basket basket = new Basket(); 
        Bagel bagel = new Bagel();
        bagel.Name = "Plain";
        basket.Add(bagel);

        Assert.That(basket.Items[0].Name, Is.EqualTo("Plain"));
        Assert.That(basket.Capacity, Is.EqualTo(4));
    }

    [Test]
    public void RemoveTest()
    {
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        Bagel bagel1 = new Bagel();
        bagel.Name = "Plain";
        bagel1.Name = "Onion";

        basket.Add(bagel);
        basket.Add(bagel1);
        bool result = basket.Remove("Plain");

        Assert.That(result, Is.True);
        Assert.That(basket.Capacity, Is.EqualTo(4));

    }

    [Test]
    public void IsFullTest()
    {
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        Bagel bagel1 = new Bagel();
        Bagel bagel2 = new Bagel();
        Bagel bagel3 = new Bagel();
        Bagel bagel4 = new Bagel();

        bagel.Name = "Plain";
        bagel1.Name = "Onion";
        bagel2.Name = "Everything";
        bagel3.Name = "Everything";
        bagel4.Name = "Plain";

        basket.Add(bagel);
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);
        basket.Add(bagel4);
        bool result = basket.IsFull();

        Assert.That(result, Is.False);

    }
    [Test]
    public void ChangeCapacityTest()
    {
        Basket basket = new Basket();
        basket.Capacity = 7;

        Assert.That(basket.Capacity, Is.EqualTo(7));
    }

    [Test]
    public void RemoveExistTest()
    {
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        bagel.Name = "Plain";
        basket.Add(bagel);

        bool result = basket.Remove("Plain");
        bool result2 = basket.Remove("Onion");
        
        Assert.That(result, Is.True);
        Assert.That(result2, Is.False);

    }

    [Test]
    public void TotalCostTest()
    {
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        Bagel bagel1 = new Bagel();

        bagel.Price = 0.49;
        bagel1.Price = 0.49;

        basket.Add(bagel);
        basket.Add(bagel1);

        double price = basket.TotalCost();

        Assert.That(price, Is.EqualTo(0.49 * 2));
    }
}