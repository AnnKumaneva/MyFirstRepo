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
            
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
           
        }

        [Test]
        public void TestCreateProduct()
        {            
            createProductPage = homePage.AllProductView();
            
            //заполнение полей нового продукта
            createProductPage.InputProduct(nameProduct, costUnitPrice, numberQuantityPerUnit, numberUnitsInStock, numberUnitsOnOrder, numberReorderLevel);
            
            //ѕроверка корректности полей созданного продукта
            Assert.AreEqual("Kukuruku", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/a")).Text);
            Assert.AreEqual("Confections", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[1]")).Text);
            Assert.AreEqual("Pasta Buttini s.r.l.", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[2]")).Text);
            Assert.AreEqual("5-10", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[3]")).Text);
            Assert.AreEqual("123,0000", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[4]")).Text);
            Assert.AreEqual("6", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[5]")).Text);
            Assert.AreEqual("2", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[6]")).Text);
            Assert.AreEqual("10", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[7]")).Text);
            Assert.AreEqual("True", driver.FindElement(By.XPath("//td[contains(a,\"Kukuruku\")]/following-sibling::td[8]")).Text);
        }

        [Test]
        public void testlogout()
        {

            startPage = homePage.LogoutCheck();            
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [TearDown]
        public void cleanup()
        {
            driver.Close();
            driver.Quit();

        }
    }
}