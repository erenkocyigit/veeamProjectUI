using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veeamProject.Drivers;

namespace veeamProject.Pages
{
    public class SearchPage
    {

        public SearchPage()
        {
            PageFactory.InitElements(Driver.getDriver(),this);
        }

        public static Int32 countOfJobs;
        public static Int32 actualCountOfJobs;
        
        [FindsBy(How = How.XPath, Using = "//div[@id='cookiescript_accept']")]
        public IWebElement acceptCookies;

        [FindsBy(How = How.XPath, Using = "//button[.='All departments']")]
        public IWebElement allDepartmentsDropdown;

        [FindsBy(How = How.XPath, Using = ".dropdown-menu a")]
        public IList<IWebElement> allDepartments;

        [FindsBy(How = How.XPath, Using = "//a[.='Research & Development']")]
        public IWebElement researchAndDevelopment;

        [FindsBy(How = How.XPath, Using = "//button[.='All languages']")]
        public IWebElement allLanguagesButton;

        [FindsBy(How = How.CssSelector, Using = ".custom-control-label")]
        public IList<IWebElement> allLanguages;

        [FindsBy(How = How.CssSelector, Using = "label[for='lang-option-0']")]
        public IWebElement englishLanguage;

        [FindsBy(How = How.CssSelector, Using = ".text-secondary.pl-2")]
        public IWebElement jobs;

        [FindsBy(How = How.XPath, Using = "//div[@class='card-header pb-2']")]
        public IList<IWebElement> countOfExpectedJobs;




    }
}
