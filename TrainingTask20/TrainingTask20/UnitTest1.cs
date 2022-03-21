using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace TrainingTask20
{
    public class Tests

    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://yandex.by/";
        }

        [Test]
        public void SuccessfullLogin()
        {
            IWebElement startlogin = driver.FindElement(By.ClassName("desk-notif-card__login-new-item-title"));
            startlogin.Click();
            IWebElement userfield = driver.FindElement(By.Id("passp-field-login"));
            userfield.SendKeys("mastermister123");
            IWebElement continuelogin = driver.FindElement(By.Id("passp:sign-in"));
            continuelogin.Click();
            Thread.Sleep(2000);
            IWebElement passwordfield = driver.FindElement(By.Name("passwd"));
            passwordfield.SendKeys("mastermister1231");
            IWebElement signin = driver.FindElement(By.Id("passp:sign-in"));
            signin.Click();
            Thread.Sleep(2000);
            var success = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var loggedin = "mastermister123";

            Assert.AreEqual(loggedin,success);
        }
    }
}