using exercise.main;
using exercise.main.Product;

namespace exercise.tests;

public class Tests
{
    private Basket _basket = new Basket();

    [Test]
    public void AddTest()
    {
        Bagel bagel = new Bagel();
        bagel.Name = "Plain";
        _basket.Add(bagel);

        Assert.That(_basket.Items[0].Name, Is.EqualTo("Plain"));
    }
}