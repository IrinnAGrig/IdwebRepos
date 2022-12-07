namespace IDWebTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
               int result = 2 + 2;
               Assert.AreEqual(result, 4);
        }
    }
}