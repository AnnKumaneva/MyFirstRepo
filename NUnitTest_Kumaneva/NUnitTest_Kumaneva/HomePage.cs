using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement AllProductsButton => driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]"));

        private IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]"));

        public CreateProductPage AllProductView()
        {
            AllProductsButton.Click();
            return new CreateProductPage(driver);
        }

        public StartPage LogoutCheck()
        {
            LogoutButton.Click();
            return new StartPage(driver);
        }
    }
}
