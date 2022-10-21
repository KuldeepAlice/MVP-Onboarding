using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class ProfileTestfeatureStepDefinitions: CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged into local host website successfully")]
        public void GivenILoggedIntoLocalHostWebsiteSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I added description in profile page")]
        public void WhenIAddedDescriptionInProfilePage()
        {
            profilePageObj.AddDescription(driver);
        }

        [Then(@"description have been added successfully")]
        public void ThenDescriptionHaveBeenAddedSuccessfully()
        {
            string newDescription = profilePageObj.GetDescription(driver);
            Assert.That(newDescription == "Hello", "Actual description and expected description do not match");
        }

        [When(@"I added avaialbility in profile page")]
        public void WhenIAddedAvaialbilityInProfilePage()
        {
            profilePageObj.AddAvailibilty(driver);
        }

        [Then(@"availability have been added successfully")]
        public void ThenAvailabilityHaveBeenAddedSuccessfully()
        {
            string newAvailability = profilePageObj.GetAvailability(driver);
            Assert.That(newAvailability == "Full Time", " Actual availability and expected availability do not match");
        }

        [When(@"I added skills in profile page")]
        public void WhenIAddedSkillsInProfilePage()
        {
            profilePageObj.AddSkills(driver);
        }

        [Then(@"skills have been added successfully")]
        public void ThenSkillsHaveBeenAddedSuccessfully()
        {
            string newSkills = profilePageObj.GetSkills(driver);
            Assert.That(newSkills == "abc", "Actual skills and expected skills do not match");
        }

        [When(@"I edited skills in profile page")]
        public void WhenIEditedSkillsInProfilePage()
        {
            profilePageObj.EditSkills(driver);
        }

        [Then(@"skills have been edied successfully")]
        public void ThenSkillsHaveBeenEdiedSuccessfully()
        {
            string updatedSkills = profilePageObj.GetUpdatedSkills(driver);
            Assert.That(updatedSkills == "Creativity", "Actual editskills and expected skills do not match");
        }

        [When(@"I deleted skills in profile page")]
        public void WhenIDeletedSkillsInProfilePage()
        {
            profilePageObj.deleteSkills(driver);
        }

        [Then(@"skills have been deleted successfully")]
        public void ThenSkillsHaveBeenDeletedSuccessfully()
        {
            string deleteSkills = profilePageObj.GetdeleteSkills(driver);
            Assert.AreEqual(null, deleteSkills);
            //Assert.That(deleteskills == "Null","Actual skill and expectes skill do not match");
        }
    }
}
