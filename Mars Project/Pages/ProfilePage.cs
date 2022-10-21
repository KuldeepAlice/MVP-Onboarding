using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class ProfilePage
    {
        public void AddDescription(IWebDriver driver)
        {

            //Add Description in Profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//i[@class='outline write icon']", 10);

            IWebElement descriptionwriteline = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            descriptionwriteline.Click();

            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            descriptionTextbox.Click();
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Hello");
            Thread.Sleep(3000);

            IWebElement savebutton = driver.FindElement(By.XPath("//button[@type='button']"));
            savebutton.Click();

            IWebElement descriptionHasBeenAddedSuccessfullyAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Thread.Sleep(5000);
        }
            public string  GetDescription (IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            return newDescription.Text;
        }

        

        public void AddAvailibilty(IWebDriver driver)
        {
            //Add Availability in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//i[@class='right floated outline small write icon']", 10);
            IWebElement editAvailabiltyButton = driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']"));
            editAvailabiltyButton.Click();
            Thread.Sleep(3000);

            IWebElement availabilityDropdownButton = driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
           availabilityDropdownButton.Click();

            IWebElement FullTimeText = driver.FindElement(By.XPath("//option[@value='1']"));
            FullTimeText.Click();
            Thread.Sleep(3000);

        }
        public string GetAvailability(IWebDriver driver)
        {
            IWebElement newAvailability = driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]"));
            return newAvailability.Text;
        }

        public void AddSkills(IWebDriver driver)
        {
            //Add skills in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            IWebElement skilloption = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skilloption.Click();

            IWebElement addnewoption = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addnewoption.Click();

            IWebElement addskilloption = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addskilloption.Clear();
            addskilloption.SendKeys("abc");

            IWebElement skillleveldropdown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            skillleveldropdown.Click();

            IWebElement selectintermediateoption = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            selectintermediateoption.Click();

            IWebElement addbutton = driver.FindElement(By.XPath("//input[@type='button']"));
            addbutton.Click();
            Thread.Sleep(5000);
        }
        public string GetSkills(IWebDriver driver)
        {
            IWebElement newSkills = driver.FindElement(By.XPath("//td[1]"));
            return newSkills.Text;
        }

        public void EditSkills(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            IWebElement skilloption = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skilloption.Click();
            Thread.Sleep(3000);

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]", 15);
            IWebElement editButton = driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            IWebElement editSkillsTextArea = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            editSkillsTextArea.Clear();
            Thread.Sleep(2000);
            editSkillsTextArea.SendKeys("Creativity");
            Thread.Sleep(3000);

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@type='button']"));
            updateButton.Click();
            Thread.Sleep(5000);
        }

        public string GetUpdatedSkills(IWebDriver driver)
        {
            IWebElement updatedSkills = driver.FindElement(By.XPath("//td[1]"));
            return updatedSkills.Text;
            //Assert.That(updatedSkills.Text == "Creativity", "Actual skills and expected skills do not match");
        }

        public void deleteSkills(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            IWebElement skilloption = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skilloption.Click();
            Thread.Sleep(3000);

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]", 15);
            IWebElement deleteButton = driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]"));
            deleteButton.Click();
            Thread.Sleep(3000);
        }

        public string GetdeleteSkills(IWebDriver driver)
        {
           // IWebElement deleteSkills = driver.FindElement(By.XPath("//td[1]"));
            return null;
        }
    }

}
