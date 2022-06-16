using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TurnUpProject.Pages;
using TurnUpProject.Utilities;

namespace TurnUpProject.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged in TurnUp Portal Successfully")]
        public void GivenILoggedInTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

        // Login page object initialization and definition

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginSteps(driver);
        }

        [When(@"I Navigate to Time and Material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I Create Time and Material Record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"Time and Naterial Record Created Successfully")]
        public void ThenTimeAndNaterialRecordCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();
            string newCode = tmPageObj.GetNewCode(driver);
            string newTypeCode = tmPageObj.GetNewTypeCode(driver);
            string newDescription = tmPageObj.GetNewDescription(driver);
            string newPrice = tmPageObj.GetNewPrice(driver);


            Assert.That(newCode == "May2022", "Actual code and expected code do not match.");
            Assert.That(newTypeCode == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(newDescription == "May2022", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match.");
        }
    }
}
