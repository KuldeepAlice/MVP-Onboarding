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
    public class ProfilePage : CommonDriver
    {
        IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Finding Elements by Xpath
        private IWebElement Descriptionwriteline => driver.FindElement(By.XPath("//i[@class='outline write icon']"));
        private IWebElement DescriptionTextbox => driver.FindElement(By.XPath("//textarea[@name='value']"));
        private IWebElement Savebutton => driver.FindElement(By.XPath("//button[@type='button']"));

        public void AddDescription(IWebDriver driver)
        {

            //click on DescriptionWriteline  in Profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//i[@class='outline write icon']", 10);
            Descriptionwriteline.Click();

            //Add description in description textbox
            DescriptionTextbox.Click();
            DescriptionTextbox.Clear();
            DescriptionTextbox.SendKeys("Hello");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//button[@type='button']", 10);

            //Click on save button
            Savebutton.Click();

            
        }
            public  string  GetDescription (IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            return newDescription.Text;
        }

        //Finding Elements by Xpath
        private IWebElement EditAvailabiltyButton => driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']"));
        private IWebElement AvailabilityDropdownButton => driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
        private IWebElement FullTimeText => driver.FindElement(By.XPath("//option[@value='1']"));
        public void AddAvailibilty(IWebDriver driver)
        {
            //Click on editAvailabilitybutton in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//i[@class='right floated outline small write icon']", 10);
            EditAvailabiltyButton.Click();


            //Click Availability dropdown
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//select[@class='ui right labeled dropdown']", 10);
            AvailabilityDropdownButton.Click();

            //Select FullTime from availability dropdown
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//option[@value='1']", 10);
             FullTimeText.Click();

        }
        public  string GetAvailability(IWebDriver driver)
        {
            IWebElement newAvailability = driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]"));
            return newAvailability.Text;
        }
        private IWebElement Skilloption => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private IWebElement Addnewoption => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private IWebElement Addskilloption => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement Skillleveldropdown => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        private IWebElement Selectintermediateoption => driver.FindElement(By.XPath("//option[@value='Intermediate']"));
        private IWebElement Addbutton => driver.FindElement(By.XPath("//input[@type='button']"));

        public void AddSkills(IWebDriver driver)
        {
            //Click on skills in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            Skilloption.Click();

            //Click on AddNewOption in skills
            Addnewoption.Click();

            //Click on addskilloption in skills 
            Addskilloption.Clear();
            Addskilloption.SendKeys("abc");

            //Click on skillleveldropdown
            Skillleveldropdown.Click();

            //Select level option from droprdown
            Selectintermediateoption.Click();

            //Click on add button in skills
            Addbutton.Click();
            
        }
        public  string GetSkills(IWebDriver driver)
        {
            IWebElement newSkills = driver.FindElement(By.XPath("//td[1]"));
            return newSkills.Text;
        }
        //Finding Elements by XPath
        private IWebElement Skilloption1 => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private IWebElement EditButton => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]"));
        private IWebElement EditSkillsTextArea => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@type='button']"));


        public void EditSkills(IWebDriver driver)
        {
            //Click on skill option
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            Skilloption1.Click();

            //Click on Edit button in skills 
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]", 5);
            EditButton.Click();

            //Click on EditSkillTextarea in skills and edit skills 
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//input[@placeholder='Add Skill']", 10);
            EditSkillsTextArea.Clear();
            EditSkillsTextArea.SendKeys("Creativity");
            Thread.Sleep(3000);

            //Click on update button
            UpdateButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//input[@type='button']", 10);
        }

        public  string GetUpdatedSkills(IWebDriver driver)
        {
            IWebElement updatedSkills = driver.FindElement(By.XPath("//td[1]"));
            return updatedSkills.Text;
            //Assert.That(updatedSkills.Text == "Creativity", "Actual skills and expected skills do not match");
        }

        //Finding Elements by XPath
        private IWebElement Skilloption2 => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private IWebElement DeleteButton => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]"));


        public void DeleteSkills(IWebDriver driver)
        {
            //Click on SkillOption
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            Skilloption2.Click();
            
            //Click on Delete button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]", 15);
            DeleteButton.Click();

        }

        public string GetdeleteSkills(IWebDriver driver)
        {
           // IWebElement deleteSkills = driver.FindElement(By.XPath("//td[1]"));
            return null;
        }
    }

}
