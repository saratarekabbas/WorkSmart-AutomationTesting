using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace WorkSmart_SeleniumTesting
{
    public class LoginTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://tcrm4.tricubes.com/portal/Security/Login";
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //driver = new FirefoxDriver();
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //driver = new EdgeDriver();
                    }

        [Test]
        public void LoginAdminValidData()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).SendKeys("Tricubes131");

           //driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
           driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            Thread.Sleep(3000);
            String successMessage = driver.FindElement(By.ClassName("username")).Text;
            TestContext.Progress.WriteLine(successMessage);


            //driver.Close(); //closes only the originally opened window
            driver.Quit(); //Quits all windows that were caused by automation
        }

        [Test]
        public void LoginInvalidPassword()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).SendKeys("123456789");

            //driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            String expectedErrorMessage = "You must specify a valid username and password."; //You must specify a valid username and password
            String actualErrorMessage = driver.FindElement(By.ClassName("error")).Text; //You must specify a valid username and password

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), $"FAIL: Actual error message '{actualErrorMessage}' does not match expected error message '{expectedErrorMessage}'.");

            //driver.Close(); //closes only the originally opened window
            driver.Quit(); //Quits all windows that were caused by automation
        }

        [Test]
        public void LoginInvalidUsername()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).SendKeys("123456789");

            //driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            String expectedErrorMessage = "You must specify a valid username and password."; //You must specify a valid username and password
            String actualErrorMessage = driver.FindElement(By.ClassName("error")).Text; //You must specify a valid username and password

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), $"FAIL: Actual error message '{actualErrorMessage}' does not match expected error message '{expectedErrorMessage}'.");

            //driver.Close(); //closes only the originally opened window
            driver.Quit(); //Quits all windows that were caused by automation
        }

        [Test]
        public void PasswordAttemptsExceeded()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).SendKeys("123456789");

            //driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            String expectedErrorMessage = "You must specify a valid username and password."; //You must specify a valid username and password
            String actualErrorMessage = driver.FindElement(By.ClassName("error")).Text; //You must specify a valid username and password

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), $"FAIL: Actual error message '{actualErrorMessage}' does not match expected error message '{expectedErrorMessage}'.");

            //driver.Close(); //closes only the originally opened window
            driver.Quit(); //Quits all windows that were caused by automation
        }

        [Test]
        public void LoginEmptyData()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).SendKeys("123456789");

            //driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();

            String expectedErrorMessage = "You must specify a valid username and password."; //You must specify a valid username and password
            String actualErrorMessage = driver.FindElement(By.ClassName("error")).Text; //You must specify a valid username and password

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage), $"FAIL: Actual error message '{actualErrorMessage}' does not match expected error message '{expectedErrorMessage}'.");

            //driver.Close(); //closes only the originally opened window
            driver.Quit(); //Quits all windows that were caused by automation
        }

        //[Test]
        //public void Test1()
        //{
        //   driver.Url = "http://tcrm4.tricubes.com/portal/Security/Login";
        //   //driver.Url = "http://rahulshettyacademy.com/loginpagePractice";
        //   TestContext.Progress.WriteLine(driver.Title);
        //   TestContext.Progress.WriteLine(driver.Url);
        //   //driver.Close(); //closes only the originally opened window
        //   //driver.Quit(); //Quits all windows that were caused by automation
        //}

    }
}