using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veeamProject.Drivers;

namespace veeamProject.Utilities
{
    public class BrowserUtils
    {

        public static void clickNonSelectDropdown(IList<IWebElement> nonSelectDropdown, String attributeValue)
        {
            foreach (IWebElement each in nonSelectDropdown)
            {
                if (each.Text.Equals(attributeValue))
                {
                    waitForElementToBeClickable(each);
                    each.Click();
                    break;
                }
            }
        }

        public static void waitForElementToBeClickable(IWebElement webElement)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));

        }
    }
}
