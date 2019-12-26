using NUnit.Framework;

namespace exe1Test
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
            Program pr = new Program();
            pr.Print("a");
            Assert.Pass();
        }
    }
}