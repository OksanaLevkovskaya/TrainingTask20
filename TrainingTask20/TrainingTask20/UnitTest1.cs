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
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SuccessfullLogin()
        {
            IWebElement startLoginButton = driver.FindElement(By.ClassName("desk-notif-card__login-new-item-title"));
            startLoginButton.Click();
            IWebElement usernameField = driver.FindElement(By.Id("passp-field-login"));
            usernameField.SendKeys("mastermister123");
            IWebElement continueLoginButton = driver.FindElement(By.Id("passp:sign-in"));
            continueLoginButton.Click();
            Thread.Sleep(2000);
            IWebElement passwordField = driver.FindElement(By.Name("passwd"));
            passwordField.SendKeys("mastermister1231");
            IWebElement signInButton = driver.FindElement(By.Id("passp:sign-in"));
            signInButton.Click();
            Thread.Sleep(2000);
            var userLabelDisplayed = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var userLoggedInLabel = "mastermister1233";

            Assert.AreEqual(userLabelDisplayed, userLoggedInLabel, "User Label is not found on page.");
                
        }
    }
}