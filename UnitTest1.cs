using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://mail.ru/";
            Assert.AreEqual("Mail.ru", webDriver.Title);
            webDriver.Close();
        }
        [TearDown]
        public void tearEnd()
        {
            webDriver.Quit();
        }
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void TestSuccessfulBooking()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");

        }

        [Test]
        public void TestEventSearch()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");

        }

        [Test]
        public void TestEventFiltering()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");

        }

        [Test]
        public void TestAddToFavorite()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");

        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }


}
        