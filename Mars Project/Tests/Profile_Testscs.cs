using Mars_Project.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Mars_Project.Utilities;
using NUnit.Framework;

namespace Mars_Project.Tests
{ 
    [TestFixture]
    public class Profile_Testscs : CommonDriver
    {

        public void LoginActions()
        {
            // Open Chrome Browser
            IWebDriver driver = new ChromeDriver();


            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }
        [Test, Order(1), Description("Check if user is able to add description with valid credentials")]
        public void AddDescription()
        {
            //Profile page object initialization and definition(Description)
            ProfilePage profilePageObj = new ProfilePage(driver);
            profilePageObj.AddDescription(driver);
        }
        [Test, Order(2), Description("Check if user is able to add availability with valid credentials")]
        public void AddAvailability()
        {
            //For Availability
            ProfilePage profilePageObj = new ProfilePage(driver);
            profilePageObj.AddAvailibilty(driver);
        }
        [Test, Order(3), Description("Check if user is able to add skills with valid credentials")]
        public void AddSkills()
        {
            //For Skills
            ProfilePage profilePageObj = new ProfilePage(driver);
            profilePageObj.AddSkills(driver);

        }
        [Test, Order(4), Description("Check if user is able to edit skills with valid credentials")]
        public void EditSkills()
        {
            ProfilePage profilePageObj = new ProfilePage(driver);
            profilePageObj.EditSkills(driver);
        }

        [Test, Order(5), Description("Check if user is able to delete skills with valid credentials")]

        public void deleteSkills()
        {
            ProfilePage profilePageObj = new ProfilePage(driver);
            profilePageObj.DeleteSkills(driver);

        }



    }
}
