using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_Project.Pages
{
    public class ProfilePage : CommonDriver
    {

        #region Description
        //Finding Elements by Xpath for description
        private IWebElement Descriptionwriteline => driver.FindElement(By.XPath("//i[@class='outline write icon']"));
        private string e_deswrite => ("//i[@class='outline write icon']");
        private IWebElement DescriptionTextbox => driver.FindElement(By.XPath("//textarea[@name='value']"));

        private string s_button => ("//button[@type='button']");
        private IWebElement Savebutton => driver.FindElement(By.XPath("//button[@type='button']"));
        #endregion 

        #region Availability
        //Finding Elements by Xpath for availability
        private IWebElement EditAvailabiltyButton => driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']"));
        private string e_avawrite => ("//i[@class='right floated outline small write icon']");
        private IWebElement AvailabilityDropdownButton => driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
        private string e_avdrop => ("//select[@class='ui right labeled dropdown']");
        //private IWebElement FullTimeText => driver.FindElement(By.XPath("//option[@value='1']"));
        //private string e_full => ("//option[@value='1']");


        private IWebElement newAvailability => driver.FindElement(By.XPath(e_availabilityType));
        private string e_availabilityType = "//div[@class='ui list']//div[2]/div/span";
        private string message = "//div[@class='ns-box-inner']";

        #endregion

        #region Skills
        //Finding Elements by Xpath for Skills
         private string e_skilloption => ("//a[@data-tab='second']");
        private IWebElement Skilloption => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        // private string e_skilloption = ("//a[@data-tab='second']");
        private IWebElement Addnewoption => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private IWebElement Addskilloption => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement Skillleveldropdown => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
       // private IWebElement Selectintermediateoption => driver.FindElement(By.XPath("//option[@value='Intermediate']"));
        private IWebElement Addbutton => driver.FindElement(By.XPath("//input[@type='button']"));

        //Finding Elements by XPath for edit skills
        private IWebElement Skilloption1 => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private string e_skilloption1 => ("//a[@data-tab='second']");
        private IWebElement EditButton => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]"));
        private string e_editskill => ("//div[@data-tab='second']//table/tbody/tr/td[3]/span[1]");
        private IWebElement EditSkillsTextArea => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private string e_skilltext => ("//input[@placeholder='Add Skill']");

        private IWebElement EditSkillDropDown => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@type='button']"));
        private string e_skillupdate => ("//input[@type='button']");

        //Finding Elements by XPath for delete skills
        private IWebElement Skilloption2 => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private string e_Skilloption2 => ("//a[@data-tab='second']");
        private IWebElement DeleteButton => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]"));
        private string e_delbutton => ("//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]");
        #endregion

       

        public void AddDescription( string Description)
        {

            //click on DescriptionWriteline  in Profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_deswrite, 3000);
            Descriptionwriteline.Click();

            //Add description in description textbox
            DescriptionTextbox.Click();
            Thread.Sleep(2000);
            DescriptionTextbox.Clear();
            DescriptionTextbox.SendKeys(Description);
            WaitHelpers.WaitToBeClickable(driver, "XPath", s_button, 3000);

            //Click on save button
            Savebutton.Click();

            
        }
            public  string  GetDescription ()
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//textarea[@name='value'][@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
            return newDescription.Text;
        }

       
        public void AddAvailibilty(string Availability)
        {
            //Click on editAvailabilitybutton in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_avawrite, 3000);
            EditAvailabiltyButton.Click();



            //Select availability dropdown
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_avdrop, 3000);
            var selectAvailability = new SelectElement(AvailabilityDropdownButton);
            selectAvailability.SelectByText(Availability);
            Thread.Sleep(2000);

        }
        public  string GetAvailability()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", message, 3000);
            Thread.Sleep(2000);
            return newAvailability.Text;
        }
        

        public void AddSkills( string Skill, string SkillLevel)
        {
            //Click on skills in profile page
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_skilloption, 3000);
            //Thread.Sleep(3000);
            Skilloption.Click();

            //Click on AddNewOption in skills
            Addnewoption.Click();

            //Click on addskilloption in skills 
            Addskilloption.Clear();
            Addskilloption.SendKeys(Skill);
            Thread.Sleep(2000);

            //Select level option from droprdown
            var selectSkillLevel = new SelectElement(Skillleveldropdown);
            selectSkillLevel.SelectByText(SkillLevel);

            //Click on add button in skills
            Addbutton.Click();
            Thread.Sleep(2000);
            
        }
        public  string GetSkills()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@data-tab='second']//table/tbody[last()]/tr/td[1]", 3000);
            IWebElement newSkills = driver.FindElement(By.XPath("//div[@data-tab='second']//tbody[last()]/tr/td[1]"));
            return newSkills.Text;
        }
       
        

        public void EditSkills( string Skill, string SkillLevel)
        {
            //Click on skill option
            WaitHelpers.WaitToBeClickable(driver, "XPath",  e_skilloption1, 3000);
            Skilloption1.Click();

            //Click on Edit button in skills 
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_editskill, 3000);
            EditButton.Click();

            //Click on EditSkillTextarea in skills and edit skills 
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_skilltext, 3000);
            EditSkillsTextArea.Clear();
            EditSkillsTextArea.SendKeys(Skill);
            Thread.Sleep(3000);

            //Click on SkilllevelDropdown
            var selectSkillLevel = new SelectElement(Skillleveldropdown);
            selectSkillLevel.SelectByText(SkillLevel);

            //Click on update button
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_skillupdate, 3000);
            UpdateButton.Click();
            Thread.Sleep(2000);
        }

        public  string GetUpdatedSkills()
        {
            Thread.Sleep(1000);
            IWebElement updatedSkills = driver.FindElement(By.XPath("//div[@data-tab='second']//tbody[last()]/tr/td[1]"));
            return updatedSkills.Text;
            
        }



        public void DeleteSkills(string Skill, string SkillLevel)
        {
            //Click on SkillOption
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_Skilloption2, 3000);
            Skilloption2.Click();
            
            //Click on Delete button
            WaitHelpers.WaitToBeClickable(driver, "XPath", e_delbutton, 3000);
            DeleteButton.Click();

        }

        public string GetdeleteSkills()
        {
           // IWebElement deleteSkills = driver.FindElement(By.XPath("//td[1]"));
            return null;
        }
    }

}
