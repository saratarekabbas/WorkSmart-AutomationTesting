namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Sett");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is Test 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is Test 2");
        }

        [TearDown]

        public void CloseBroswer() {
            TestContext.Progress.WriteLine("Teardown method");
        }
    }
}