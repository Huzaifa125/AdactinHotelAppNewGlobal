using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdactinHotelAppNew
{
    [TestClass]
    public class Execution : BasePage
    {
        private TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Console.WriteLine("AssemblyInitialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("AssemblyCleanup");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Console.WriteLine("ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            ChromeOpen();
            driver.Url = "http://adactinhotelapp.com/";
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //BrowserQuit();
        }
    }
}
