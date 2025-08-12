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
        Assert.That(basket.Capacity, Is.EqualTo(29));
        Assert.That(bagel.ID, Is.EqualTo(0));
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
        basket.Remove(0);

        Assert.That(basket.Capacity, Is.EqualTo(29));
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

        basket.Remove(0);
        
        Assert.That(basket.Capacity, Is.EqualTo(30));

    }

    [Test]
    public void TotalCostTest()
    {
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        Bagel bagel1 = new Bagel();

        bagel.BagelPrice = 0.49;
        bagel1.BagelPrice = 0.49;

        basket.Add(bagel);
        basket.Add(bagel1);

        double price = basket.TotalCost();

        Assert.That(price, Is.EqualTo(0.49 * 2));
    }

    [Test]
    public void PriceBagelTest()
    {
       
        Bagel bagel = new Bagel();

        bagel.BagelPrice = 0.49;

        Assert.That(bagel.BagelPrice, Is.EqualTo(0.49));

        
    }

    [Test]
    public void AddFillingTest()
    {
        Inventory inventory = new Inventory();
        Basket basket = new Basket();
        Bagel bagel = new Bagel();

        basket.Add(bagel);

        Filling bacon = inventory.GetBaconFilling();
        bagel.AddFilling(bacon);

       

        Assert.That(bagel.Filling.Count, Is.EqualTo(1));
    }

    [Test]
    public void SeeFillingCostTest()
    {
        Inventory inventory = new Inventory();
        Basket basket = new Basket();
        Bagel bagel = new Bagel();
        Filling bacon = inventory.GetBaconFilling();
        Filling cheese = inventory.GetCheeseFilling();
        bagel.AddFilling(bacon);
        bagel.AddFilling(cheese);

        bagel.SeeFillingCost();

    }

    [Test]
    public void InventoryTest()
    {
        Basket basket = new Basket();
        Inventory inventory = new Inventory();
        Bagel bagel = inventory.getOnionBagel();
        Filling bacon = inventory.GetBaconFilling();  
        Coffee coffee = inventory.getBlackCoffee();

        bagel.AddFilling(bacon);
        basket.Add(bagel);
        basket.Add(coffee);


        // 0.49 + 0.12 + 0.99 = 0.61

        Assert.That(basket.TotalCost, Is.EqualTo(1.6));
    }
}