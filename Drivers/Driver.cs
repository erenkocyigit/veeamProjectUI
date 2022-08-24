using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace veeamProject.Drivers
{

    
    public class Driver
    {
        public static ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();
        

        private Driver()
        {

        }
        

        public static IWebDriver getDriver()
        {
            if (driverPool.Value == null)
            {
                String browserName = ConfigurationManager.AppSettings["browser"];
                switch (browserName)
                {

                    case "Firefox":

                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                        driverPool.Value = new FirefoxDriver();
                        driverPool.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        driverPool.Value.Manage().Window.Maximize();
                        break;

                    case "Chrome":

                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        driverPool.Value = new ChromeDriver();
                        driverPool.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        driverPool.Value.Manage().Window.Maximize();
                        break;

                }
            }
            return driverPool.Value;

            
        }

        public static void closeDriver()
        {
            if(driverPool.Value != null)
            {
                driverPool.Value.Quit();
            }
        }




    }


}
