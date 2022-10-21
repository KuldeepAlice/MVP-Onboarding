using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch Local host website

            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Click on Sign Button
            IWebElement signButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signButton.Click();

            //Enter Username

            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("kuldeepalice@gmail.com");

            //Enter Password

            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("kuldeepalice07");


            //Click on login button

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(2000);

        }
    }
}
