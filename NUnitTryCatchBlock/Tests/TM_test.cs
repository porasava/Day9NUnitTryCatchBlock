using NUnit.Framework;
using NUnitTryCatchBlock.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTryCatchBlock.Utilities;

namespace NUnitTryCatchBlock.Tests
{
    [TestFixture]
    public class TM_test : CommonDriver
    {
        [SetUp]
        public void TimeSetUp()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test,Order(1)]
        public void Create_TimeRecord() 
        {
            TMPage TMPageObj = new TMPage();

            //Create
            TMPageObj.Create_TimeRecord(driver);
        }

        [Test, Order(2)]
        public void EditTime_Test()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.Update_TimeRecord(driver);
        }

        [Test, Order(3)]
        public void DeleteTime_Test()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.Delete_TimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}
