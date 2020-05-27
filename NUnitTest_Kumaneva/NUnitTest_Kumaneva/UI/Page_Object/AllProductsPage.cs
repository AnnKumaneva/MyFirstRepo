using NUnitTest_Kumaneva.business_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva
{
    class AllProductsPage
    {
        private IWebDriver driver;

        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private string NameCreateProduct;

       
        private IWebElement nameProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/a"));

        private IWebElement categoryProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[1]"));

        private IWebElement supplierProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[2]"));

        private IWebElement unitPriceProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[4]"));

        private IWebElement quantityProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[3]"));

        private IWebElement unitInStockProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[5]"));

        private IWebElement unitsOnOrderProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[6]"));

        private IWebElement reorderLevelProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[7]"));

        private IWebElement discontProduct => driver.FindElement(By.XPath($"//td[contains(a, \"{NameCreateProduct}\")]/following-sibling::td[8]"));

        public string GetNameProductText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return nameProduct.Text;
        }
        public string GetCategoryText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return categoryProduct.Text;
        }
        public string GetSupplierText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return supplierProduct.Text;
        }
        public string GetUnitPriceText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitPriceProduct.Text;
        }
        public string GetQuantityPerUnitText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return quantityProduct.Text;
        }
        public string GetUnitInStockText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitInStockProduct.Text;
        }
        public string GetUnitsOnOrderText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitsOnOrderProduct.Text;
        }
        public string GetReorderLevelText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return reorderLevelProduct.Text;
        }
        public string GetDiscontinuedText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return discontProduct.Text;
        }



    }
}
