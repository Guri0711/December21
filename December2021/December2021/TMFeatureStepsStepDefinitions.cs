using December2021.Pages;
using December2021.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace December2021
{
    [Binding]
    class TMFeatureStepsStepDefinitions : CommonDriver
    {
        [Given(@"I logged successfully in TurnUp Portal")]
        public void GivenILoggedSuccessfullyInTurnUpPortal()
        {
            // Login page object initialization and definition
            LoginPage loginPageob = new LoginPage();
            loginPageob.LoginSteps(driver);
        }

        [Given(@"I navigate to Time and Material option")]
        public void GivenINavigateToTimeAndMaterialOption()
        {
            // Home page object initialization and definition
            HomePage homePageob = new HomePage();
            homePageob.GoToTMPage(driver);
        }

        [When(@"I create new record in Time and Material page")]
        public void WhenICreateNewRecordInTimeAndMaterialPage()
        {
            // TMPage object intialization and defintion
            TMPage tmPageob = new TMPage();
            tmPageob.CreateTM(driver);
        }

        [Then(@"Created new record succesfully")]
        public void ThenCreatedNewRecordSuccesfully()
        {
            TMPage tmPageObj = new TMPage();

            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetDescription(driver);
            string actualPrice = tmPageObj.GetPrice(driver);

            Assert.That(actualCode == "Test codetextbox", "Actual code and expected code do not match.");
            Assert.That(actualTypeCode == "M", "Actual typecode and expected code do not match.");
            Assert.That(actualDescription == "description", "Actual description and expected code do not match.");
            Assert.That(actualPrice == "$12.00", "Actual price and expected code do not match.");
       
        }

        [When(@"I update '([^']*)' and '([^']*)' existing record in Time and Material page")]
        public void WhenIUpdateAndExistingRecordInTimeAndMaterialPage(string time, string typeCode)
        {
            throw new PendingStepException();
        }

        [Then(@"The record should be updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string time, string typeCode)
        {
            throw new PendingStepException();
        }

    }






}

