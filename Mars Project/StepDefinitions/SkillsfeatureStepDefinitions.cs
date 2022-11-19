using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class SkillsfeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj;
        ProfilePage profilePageObj;

        public SkillsfeatureStepDefinitions()
        {
            loginPageObj = new LoginPage();
            profilePageObj = new ProfilePage();

        }
        [Given(@"I logged into local host website successfully")]
        public void GivenILoggedIntoLocalHostWebsiteSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I added '([^']*)' and '([^']*)'in profile page")]
        public void WhenIAddedAndInProfilePage(string Skill, string SkillLevel)
        {

            profilePageObj.AddSkills(Skill, SkillLevel);
        }

        [Then(@"The '([^']*)'  and '([^']*)' should be added successfully")]
        public void ThenTheAndShouldBeAddedSuccessfully(string Skill, string SkillLevel)
        {
            string newSkills = profilePageObj.GetSkills();
            Assert.That(newSkills == Skill, "Actual skills and expected skills do not match");
        }

        [When(@"I edited '([^']*)' and '([^']*)' in profile page")]
        public void WhenIEditedAndInProfilePage(string Skill, string SkillLevel)
        {
            profilePageObj.EditSkills(Skill, SkillLevel);
        }

        [Then(@"'([^']*)' and '([^']*)' should be edited  successfully")]
        public void ThenAndShouldBeEditedSuccessfully(string Skill, string SkillLevel)
        {
            string updatedSkills = profilePageObj.GetUpdatedSkills();
            Assert.AreEqual(updatedSkills, Skill, SkillLevel, "Actual editskills and expected skills do not match");
        }

        [When(@"I deleted '([^']*)' and '([^']*)' in profile page")]
        public void WhenIDeletedAndInProfilePage(string Skill, string SkillLevel)
        {
            profilePageObj.DeleteSkills(Skill, SkillLevel);
        }

        [Then(@"'([^']*)' and '([^']*)' should be  deleted successfully")]
        public void ThenAndShouldBeDeletedSuccessfully(string Skill, string SkillLevel)
        {
            string deleteSkills = profilePageObj.GetdeleteSkills();
            Assert.AreEqual(null, deleteSkills);
            //Assert.That(deleteskills == "Null","Actual skill and expectes skill do not match");
        }
    }
}
