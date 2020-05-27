using NUnitTest_Kumaneva.business_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva.service.UI
{
    class ProductService
    {
        public static AllProductsPage CreateProduct(Products product, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            CreateProductPage createProductPage = homePage.AllProductView();
            AllProductsPage allProductsPage = new AllProductsPage(driver);
            allProductsPage = createProductPage.InputProduct(product);
            return new AllProductsPage(driver);
        }

    }
}
