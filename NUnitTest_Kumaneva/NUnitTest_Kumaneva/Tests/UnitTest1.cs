using NUnit.Framework;
using NUnitTest_Kumaneva.business_object;
using NUnitTest_Kumaneva.service.UI;
using NUnitTest_Kumaneva.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace NUnitTest_Kumaneva
{
    public class UnitTest1 : BaseTest
    {




        //private StartPage startPage;
        //private HomePage homePage;
        //private AllProductsPage allProductsPage;
        //private const string loginName = "user";
        //private const string password = "user";
        //private Products newProduct = new Products("Kukuruku", "123", "5-10", "6", "2", "10");

        //[SetUp]
        //public void Start()
        //{
        //    startPage = new StartPage(driver);
        //    homePage = startPage.LoginInput(loginName, password);
        //}

        //[Test]
        //public void TestLogin()
        //{            
        //    Assert.AreEqual("Home page", homePage.GetText());           
        //}

        //[Test]
        //public void TestCreateProduct()
        //{
        //    allProductsPage = ProductService.CreateProduct(newProduct, driver);
            
        //    Assert.AreEqual("Kukuruku", allProductsPage.GetNameProductText(newProduct.nameProduct));
        //    Assert.AreEqual("Confections", allProductsPage.GetCategoryText(newProduct.nameProduct));
        //    Assert.AreEqual("Pasta Buttini s.r.l.", allProductsPage.GetSupplierText(newProduct.nameProduct));
        //    Assert.AreEqual("5-10", allProductsPage.GetQuantityPerUnitText(newProduct.nameProduct));
        //    Assert.AreEqual("123,0000", allProductsPage.GetUnitPriceText(newProduct.nameProduct));
        //    Assert.AreEqual("6", allProductsPage.GetUnitInStockText(newProduct.nameProduct));
        //    Assert.AreEqual("2", allProductsPage.GetUnitsOnOrderText(newProduct.nameProduct));
        //    Assert.AreEqual("10", allProductsPage.GetReorderLevelText(newProduct.nameProduct));
        //    Assert.AreEqual("True", allProductsPage.GetDiscontinuedText(newProduct.nameProduct));
        //}

        //[Test]
        //public void testlogout()
        //{
        //    startPage = homePage.LogoutCheck();            
        //    Assert.AreEqual("Login", startPage.GetStartPageText());
        //}

        
    }
}