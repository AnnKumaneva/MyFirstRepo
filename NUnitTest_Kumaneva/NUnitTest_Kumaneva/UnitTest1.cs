using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace NUnitTest_Kumaneva
{
    public class Tests
    {
        private IWebDriver driver;
        private CreateProductPage createProductPage;
        private StartPage startPage;
        private HomePage homePage;
        private const string nameProduct = "Kukuruku";
        private const string costUnitPrice = "123";
        private const string numberQuantityPerUnit = "5-10";
        private const string numberUnitsInStock = "6";
        private const string numberUnitsOnOrder = "2";
        private const string numberReorderLevel = "10";
        private const string loginName = "user";
        private const string password = "user";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [SetUp]
        public void Start()
        {
            startPage = new StartPage(driver);
            homePage = startPage.LoginInput(loginName, password);
            
        }
        [Test]
        public void TestLogin()
        {
            
            Assert.AreEqual("Home page", homePage.GetText());
           
        }

        [Test]
        public void TestCreateProduct()
        {            
            createProductPage = homePage.AllProductView();
            
            //заполнение полей нового продукта
            createProductPage.InputProduct(nameProduct, costUnitPrice, numberQuantityPerUnit, numberUnitsInStock, numberUnitsOnOrder, numberReorderLevel);
            
            //ѕроверка корректности полей созданного продукта
            Assert.AreEqual("Kukuruku", createProductPage.GetNameProductText());
            Assert.AreEqual("Confections", createProductPage.GetCategoryText());
            Assert.AreEqual("Pasta Buttini s.r.l.", createProductPage.GetSupplierText());
            Assert.AreEqual("5-10", createProductPage.GetQuantityPerUnitText());
            Assert.AreEqual("123,0000", createProductPage.GetUnitPriceText());
            Assert.AreEqual("6", createProductPage.GetUnitInStockText());
            Assert.AreEqual("2", createProductPage.GetUnitsOnOrderText());
            Assert.AreEqual("10", createProductPage.GetReorderLevelText());
            Assert.AreEqual("True", createProductPage.GetDiscontinuedText());
        }

        [Test]
        public void testlogout()
        {

            startPage = homePage.LogoutCheck();            
            Assert.AreEqual("Login", startPage.GetStartPageText());
        }

        [TearDown]
        public void cleanup()
        {
            driver.Close();
            driver.Quit();

        }
    }
}