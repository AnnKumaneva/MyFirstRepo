﻿using NUnitTest_Kumaneva.business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        

        public AllProductsPage InputProduct(Products product)
        {
            
            
            ProductNameInput.SendKeys(product.nameProduct);
            CategoryName.Click();
            SupplierName.Click();
            UnitPriceCost.SendKeys(product.costUnitPrice);
            QuantityPerUnitNumber.SendKeys(product.numberQuantityPerUnit);
            UnitsInStockNumber.SendKeys(product.numberUnitsInStock);
            UnitsOnOrderNumber.SendKeys(product.numberUnitsOnOrder);
            ReorderLevelNumber.SendKeys(product.numberReorderLevel);
            DiscontinuedTrue.Click();
            new Actions(driver).Click(CreateButton).Build().Perform();
            

            return new AllProductsPage(driver);
            
        }
        
    }
}
