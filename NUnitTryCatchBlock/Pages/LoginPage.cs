using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnitTryCatchBlock.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTryCatchBlock.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();

            //Lunch TurnUp Portal and navigate to the website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Wait.WaitToExist(driver, "Xpath", "//*[@id='UserName']", 8);
            //user login
            IWebElement usernameTextbox = driver.FindElement(By.XPath("//*[@id='UserName']"));
            usernameTextbox.SendKeys("hari");

            IWebElement passwordTextbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            passwordTextbox.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }


    }
}
