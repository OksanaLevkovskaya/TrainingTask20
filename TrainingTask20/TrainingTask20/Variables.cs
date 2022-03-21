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

        public void LogintoAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url="https://yandex.by/";

            IWebElement startlogin = driver.FindElement(By.ClassName("desk-notif-card__login-new-item-title"));
            IWebElement userfield = driver.FindElement(By.Id("passp-field-login"));
            IWebElement continuelogin = driver.FindElement(By.Id("passp:sign-in"));
            IWebElement passwordfield = driver.FindElement(By.Name("passwd"));
            IWebElement signin = driver.FindElement(By.Id("passp:sign-in"));
           

            startlogin.Click();
            userfield.SendKeys("mastermister123");
            continuelogin.Click();
            passwordfield.SendKeys("mastermister123");
            signin.Click();
            driver.Quit();

        }

    }
}
