using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TrainingTask20
{
    public class Variables
    {

        public static void LogintoAccount()
        {
            var driver = new ChromeDriver();
            driver.Url="https://yandex.by/";

            IWebElement startLoginButton = driver.FindElement(By.ClassName("desk-notif-card__login-new-item-title"));
            IWebElement usernameField = driver.FindElement(By.Id("passp-field-login"));
            IWebElement continueLoginButton = driver.FindElement(By.Id("passp:sign-in"));
            IWebElement passwordField = driver.FindElement(By.Name("passwd"));
            IWebElement signInButton = driver.FindElement(By.Id("passp:sign-in"));


            startLoginButton.Click();
            usernameField.SendKeys("mastermister123");
            continueLoginButton.Click();
            passwordField.SendKeys("mastermister123");
            signInButton.Click();
            driver.Quit();

        }

    }
}
