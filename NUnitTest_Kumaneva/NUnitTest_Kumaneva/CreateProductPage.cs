using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva
{
    class CreateProductPage
    {
        private IWebDriver driver;

        public CreateProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement CreateNewProductButton => driver.FindElement(By.XPath("//a[@class=\"btn btn-default\"]"));


        private IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]"));

        private IWebElement CategoryName => driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]/option[@value=\"3\"]"));


        private IWebElement SupplierName => driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]/option[@value=\"26\"]"));

        private IWebElement UnitPriceCost => driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] "));

        private IWebElement QuantityPerUnitNumber => driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] "));

        private IWebElement UnitsInStockNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] "));

        private IWebElement UnitsOnOrderNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] "));

        private IWebElement ReorderLevelNumber => driver.FindElement(By.XPath("//input[contains(@id,\"ReorderLevel\")] "));

        private IWebElement DiscontinuedTrue => driver.FindElement(By.XPath("//input[contains(@id,\"Discontinued\")] "));


        private IWebElement CreateButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));

        private IWebElement namePrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/a"));

        private IWebElement categoryPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[1]"));

        private IWebElement supplierPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[2]"));

        private IWebElement unitPricePrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[4]"));

        private IWebElement quantityPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[3]"));

        private IWebElement unitInStockPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[5]"));

        private IWebElement unitsOnOrderPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[6]"));

        private IWebElement reorderLevelPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[7]"));

        private IWebElement discontPrdct => driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[8]"));

        public void InputProduct(string nameProduct, string costUnitPrice, string numberQuantityPerUnit, string numberUnitsInStock, string numberUnitsOnOrder, string numberReorderLevel)
        {
            CreateNewProductButton.Click();
            ProductNameInput.SendKeys(nameProduct);
            CategoryName.Click();
            SupplierName.Click();
            UnitPriceCost.SendKeys(costUnitPrice);
            QuantityPerUnitNumber.SendKeys(numberQuantityPerUnit);
            UnitsInStockNumber.SendKeys(numberUnitsInStock);
            UnitsOnOrderNumber.SendKeys(numberUnitsOnOrder);
            ReorderLevelNumber.SendKeys(numberReorderLevel);
            DiscontinuedTrue.Click();

            CreateButton.Click();
        }
        public string GetNameProductText()
        {
            return namePrdct.Text;
        }
        public string GetCategoryText()
        {
            return categoryPrdct.Text;
        }
        public string GetSupplierText()
        {
            return supplierPrdct.Text;
        }
        public string GetUnitPriceText()
        {
            return unitPricePrdct.Text;
        }
        public string GetQuantityPerUnitText()
        {
            return quantityPrdct.Text;
        }
        public string GetUnitInStockText()
        {
            return unitInStockPrdct.Text;
        }
        public string GetUnitsOnOrderText()
        {
            return unitsOnOrderPrdct.Text;
        }
        public string GetReorderLevelText()
        {
            return reorderLevelPrdct.Text;
        }
        public string GetDiscontinuedText()
        {
            return discontPrdct.Text;
        }

    }
}
