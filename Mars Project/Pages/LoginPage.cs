using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    
    public class LoginPage : CommonDriver
    {
        //Finding elements by XPath
         private IWebElement signButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
         private IWebElement usernameTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
         private IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
         private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        public void LoginSteps(IWebDriver driver)
        {
             //Launch Local host website
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //Click on Sign Button
            signButton.Click();

            //Enter Username
            usernameTextbox.SendKeys("kuldeepalice@gmail.com");

            //Enter Password
            passwordTextbox.SendKeys("kuldeepalice07");

            //Click on login button
            loginButton.Click();
            

        }
    }
}
