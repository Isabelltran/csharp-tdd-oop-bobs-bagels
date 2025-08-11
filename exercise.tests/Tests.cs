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
        Assert.That(_basket.Capacity, Is.EqualTo(9));
    }

    [Test]
    public void RemoveTest()
    {
        Bagel bagel = new Bagel();
        Bagel bagel1 = new Bagel();
        bagel.Name = "Plain";
        bagel1.Name = "Onion";

        _basket.Add(bagel);
        _basket.Add(bagel1);
        _basket.Remove(bagel);
        bool result = _basket.Remove(bagel);

        Assert.That(result, Is.True);
        Assert.That(_basket.Capacity, Is.EqualTo(9));

    }
}