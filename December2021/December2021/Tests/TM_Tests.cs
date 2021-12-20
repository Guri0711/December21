using December2021.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace December2021
{
   public class TM_Tests
    {
        public static void Main(string[] args)
      
        {
            IWebDriver driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageob = new LoginPage();
            loginPageob.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);

            // TMPage object intialization and defintion
            TMPage tmPageob = new TMPage();
            tmPageob.CreateTM(driver);

            // Edit TM
            tmPageob.EditTM(driver);

            // Delete TM
            tmPageob.DeleteTM(driver);

        }

    }
}