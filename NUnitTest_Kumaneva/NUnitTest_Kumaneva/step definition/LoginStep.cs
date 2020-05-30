using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTest_Kumaneva.step_definition
{
    [Binding]
    public sealed class LoginStep
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenURL(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;

        }

        [When(@"I enter ""(.*)"" in the Name-field")]
        public void WhenIenterUserInTheNameField(string name)
        {
            new StartPage(driver).NameLoginInput(name);
        }

        [When(@"I enter ""(.*)"" in the Password-field")]
        public void WhenIenterUserInThePasswordField(string password)
        {
            new StartPage(driver).LoginPaswordInput(password);
        }

        [When(@"I click on the Send-button")]
        public void WhenIClickOnTheSendButton()
        {
            new StartPage(driver).SendButtonClick();            
        }

        [Then(@"Home page should be open")]
        public void ThenHomePageShouldBeOpen()
        {           
            Assert.AreEqual("Home page", new HomePage(driver).GetText());
        }
    }
}
