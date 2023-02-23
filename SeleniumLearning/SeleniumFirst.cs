using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class SeleniumFirst
    {
        IWebDriver driver;

        [SetUp] //Pre Condition

        public void StartBrowser()
        {
            // Invoking Chrome Browser:
            // To talk to Chrome browser, we have to talk to the chrome driver => chromedriver.exe.
            // The driver takes the selenium commands and performs them on the Chrome Browser

            // For the different version management; we can use WebDriverManager; which, requires package installation.
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //create a new driver object for chrome
                        driver = new ChromeDriver();

        }

        [Test]
                public void Test1()
        {
            driver.Url = "http://tcrm4.tricubes.com/portal/Security/Login"; //The value here is set in the browser
            //Check the Chrome Page title:
            TestContext.Progress.WriteLine(driver.Title);
            // get the URL property
            TestContext.Progress.WriteLine(driver.Url);

            //close the browser
            driver.Close();
        }

        [TearDown] //Post Condtion
        public void Tear()
        {

        }
    }
}
