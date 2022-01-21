using December2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace December2021.Utilities
{
    class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()

        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageob = new LoginPage();
            loginPageob.LoginSteps(driver);

        }
            [OneTimeTearDown]
            public void CloseTestRun()
            {
                driver.Quit();

            }
    }
}
