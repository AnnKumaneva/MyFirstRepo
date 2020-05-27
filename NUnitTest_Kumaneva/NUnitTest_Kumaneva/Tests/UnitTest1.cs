using NUnit.Framework;
using NUnitTest_Kumaneva.business_object;
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
        private AllProductsPage checkNewProduct;
        //private const string nameProduct = "Kukuruku";
        //private const string costUnitPrice = "123";
        //private const string numberQuantityPerUnit = "5-10";
        //private const string numberUnitsInStock = "6";
        //private const string numberUnitsOnOrder = "2";
        //private const string numberReorderLevel = "10";
        private const string loginName = "user";
        private const string password = "user";
        private Products newProduct = new Products("Kukuruku", "123,0000", "5-10", "6", "2", "10");

        private string nameProduct => newProduct.productName;
        //= "Kukuruku";
        //=> newProduct.productName;


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
            createProductPage.InputProduct(newProduct, newProduct, newProduct, newProduct, newProduct, newProduct);

            //ѕроверка корректности полей созданного продукта
            checkNewProduct = new AllProductsPage(driver);
            Assert.AreEqual(newProduct.productName, checkNewProduct.GetNameProductText(nameProduct));
            Assert.AreEqual("Confections", checkNewProduct.GetCategoryText(nameProduct));
            Assert.AreEqual("Pasta Buttini s.r.l.", checkNewProduct.GetSupplierText(nameProduct));
            Assert.AreEqual(newProduct.quantityPerUnit, checkNewProduct.GetQuantityPerUnitText(nameProduct));
            Assert.AreEqual(newProduct.unitPrice, checkNewProduct.GetUnitPriceText(nameProduct));
            Assert.AreEqual(newProduct.unitsInStock, checkNewProduct.GetUnitInStockText(nameProduct));
            Assert.AreEqual(newProduct.unitsOnOrder, checkNewProduct.GetUnitsOnOrderText(nameProduct));
            Assert.AreEqual(newProduct.reorderLevel, checkNewProduct.GetReorderLevelText(nameProduct));
            Assert.AreEqual("True", checkNewProduct.GetDiscontinuedText(nameProduct));
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