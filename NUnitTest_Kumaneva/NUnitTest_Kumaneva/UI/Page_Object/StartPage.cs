using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva
{
    class StartPage
    {
        private IWebDriver driver;

        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginNameInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id=\"Password\"]"));

        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));

        private IWebElement startPageText => driver.FindElement(By.XPath("//h2"));

        public StartPage NameLoginInput(string loginNameInput)
        {
            LoginNameInput.SendKeys(loginNameInput);          
            return this;            
        }

        public StartPage LoginPaswordInput(string passwordInput)
        {            
            PasswordInput.SendKeys(passwordInput);            
            return this;
        }

        public HomePage SendButtonClick()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            LoginButton.Click();
            return new HomePage(driver);
        }


        public string GetStartPageText()
        {
            return startPageText.Text;
        }

    }
}
