using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTryCatchBlock.Utilities;

namespace NUnitTryCatchBlock.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //Navigate to time and material 
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();

            Wait.WaitToBeClickable(driver, "Xpath","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);
            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
        }
    }
}
