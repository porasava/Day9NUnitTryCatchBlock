using OpenQA.Selenium;
using NUnitTryCatchBlock.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTryCatchBlock.Pages
{
    public class TMPage
    {
        public void Create_TimeRecord(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "Xpath","//*[@id=\"container\"]/p/a", 5);
            //Add
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            IWebElement typeCodeTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            typeCodeTime.Click();
            IWebElement createCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            createCode.SendKeys("HelloTan");
            IWebElement createDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            createDescription.SendKeys("HelloTanDes");
            Thread.Sleep(1000);
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("111");
            IWebElement createSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            createSave.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 3);
            //Go to last page
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            //try
            //{
            //IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastPage.Click();
            //}
            //catch(Exception ex)
            //{
            //    Assert.Fail("Go to last pagebutton has not been found.", ex.Message);
            //}
            
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "HelloTan", "Record has not been created.");
           



            // Check if new record has been created successfully
            //if (newCode.Text == "HelloTan")
            //{
            //    Console.WriteLine("New record has been created successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Record has not been created.");
            //}




        }
        public void Update_TimeRecord(IWebDriver driver) 
        {
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            //Edit
            IWebElement editLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editLastRecord.Click();                                 ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]
            Wait.WaitToBeClickable(driver, "Xpath", "//*[@id=\"Code\"]", 3);
         
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editCode.Clear();
            editCode.SendKeys("HelloTan1");
            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            editDescription.Clear();
            editDescription.SendKeys("HelloTanDes1");
            IWebElement EditSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            EditSave.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[4]/div/div/div[4]/a[4]/span", 3);
            
            //Go to last page
            IWebElement lastPageEdit = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            lastPageEdit.Click();
            IWebElement newCodeEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCodeEdit.Text == "HelloTan1", "Record has not been created.");
            Thread.Sleep(4000);


        }

        public void Delete_TimeRecord(IWebDriver driver) 
        {
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            IWebElement lastPageDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[2]"));
            lastPageDelete.Click();
            driver.SwitchTo().Alert().Accept();
        }
        //

    }
}
