using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class DescriptionandAvailabilityfeaturefileStepDefinitions: CommonDriver

    {
        LoginPage loginPageObj;
        ProfilePage profilePageObj;

        public DescriptionandAvailabilityfeaturefileStepDefinitions()
        {
            this.loginPageObj = new LoginPage();
            this.profilePageObj = new ProfilePage();
        }

        [Given(@"I signed into local host website successfully")]
        public void GivenISignedIntoLocalHostWebsiteSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I add '([^']*)' in profile page")]
        public void WhenIAddInProfilePage(string Description)
        {
            profilePageObj.AddDescription(Description);
        }

        [Then(@"'([^']*)' should be add successfully")]
        public void ThenShouldBeAddSuccessfully(string Description)
        {
            string newDescription = profilePageObj.GetDescription();
            Assert.That(newDescription == Description, "Actual description and expected description do not match");
        }

        [When(@"I added '([^']*)' in profile page")]
        public void WhenIAddedInProfilePage(string Availability)
        {
            profilePageObj.AddAvailibilty(Availability);
        }

        [Then(@"'([^']*)' should be added successfully")]
        public void ThenShouldBeAddedSuccessfully(string Availability)
        {
            string newAvailability = profilePageObj.GetAvailability();
            Assert.AreEqual(newAvailability, Availability, " Actual availability and expected availability do not match");
        }
    }
}
