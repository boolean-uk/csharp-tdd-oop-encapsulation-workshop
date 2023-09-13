using NUnit.Framework;

namespace workshop.tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CreateGroupByFromList()
        {
            //arange
            List<string> fruitBasket = new List<string>();
            fruitBasket.Add("banana");
            fruitBasket.Add("mango");
            fruitBasket.Add("banana");
            fruitBasket.Add("grapes");
            fruitBasket.Add("banana");
            fruitBasket.Add("strawberry");

            //act - var is a lazy way of writing Dictionary<string,int> in this case
            var fruitBasketBreakdown = fruitBasket.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

            //assert
            Assert.AreEqual(fruitBasketBreakdown["banana"], 3);

        }

    }
}