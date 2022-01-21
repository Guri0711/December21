using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace December2021
{
    [TestFixture]
    [Parallelizable]
   class TM_Tests : CommonDriver
    {

        [Test, Order (1), Description("Check if user is able to create new record")]
        public void CreateTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);

            // TMPage object intialization and defintion
            TMPage tmPageob = new TMPage();
            tmPageob.CreateTM(driver);

        }
        [Test, Order (2), Description("Check if user is able to edit existed record")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);


            // TMPage object intialization and defintion
            TMPage tmPageob = new TMPage();
            tmPageob.EditTM(driver);

        }
        [Test, Order (3), Description("Check if user is able to delete existed record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);


            // TMPage object intialization and defintion
            TMPage tmPageob = new TMPage();
            tmPageob.DeleteTM(driver);

        }
         
    }
}