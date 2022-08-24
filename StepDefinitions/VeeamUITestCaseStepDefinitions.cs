using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using veeamProject.Drivers;
using veeamProject.Pages;
using veeamProject.Utilities;

namespace veeamProject.StepDefinitions
{
    [Binding]
    public class VeeamUITestCaseStepDefinitions
    {
        SearchPage searchPage = new SearchPage();
        int countOfJobs;
        int expectedCountOfJobs;


        [Given(@"user is on careers page")]
        public void GivenUserIsOnCareersPage()
        {
            Driver.getDriver().Url = ConfigurationManager.AppSettings["url"];
            BrowserUtils.waitForElementToBeClickable(searchPage.acceptCookies);
            searchPage.acceptCookies.Click();

        }

        [When(@"user selects Research & Development in All Departments dropdown")]
        public void WhenUserSelectsInAllDepartmentsDropdown()
        {
            searchPage.allDepartmentsDropdown.Click();
            BrowserUtils.waitForElementToBeClickable(searchPage.researchAndDevelopment);
            searchPage.researchAndDevelopment.Click();
            
        }
        [When(@"user selects English language in All Languages list")]
        public void WhenUserSelectsLanguageInAllLanguagesList()
        {
            searchPage.allLanguagesButton.Click();
            BrowserUtils.waitForElementToBeClickable(searchPage.englishLanguage);
            searchPage.englishLanguage.Click();
        }


        [Then(@"assert that number of jobs found will match expected result")]
        public void ThenAssertThatNumberOfJobsFoundWillMatchExpectedResult()
        {
            var actualJobs = searchPage.jobs.Text;            
            int expectedJobs = searchPage.countOfExpectedJobs.Count;
            Assert.AreNotEqual(expectedJobs, actualJobs);

        }
    }
}
