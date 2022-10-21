using Mars_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginActions()
        {
            //Open Chrome browser
            driver = new ChromeDriver();

            //Login Page obj
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
