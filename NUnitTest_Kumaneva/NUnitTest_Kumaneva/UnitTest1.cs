using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace NUnitTest_Kumaneva
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [SetUp]
        public void Start()
        {
            driver.FindElement(By.XPath("//input[@id=\"Name\"]")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id=\"Password\"]")).SendKeys("user");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@type=\"submit\"]")).Click();
        }
        [Test]
        public void TestLogin()
        {
            
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
           
        }

        [Test]
        public void TestCreateProduct()
        {
            driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]")).Click();
            driver.FindElement(By.XPath("//a[@class=\"btn btn-default\"]")).Click();
            //заполнение полей нового продукта
            driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]")).SendKeys("Kukuruku");
            driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]/option[@value=\"3\"]")).Click();
            driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]/option[@value=\"26\"]")).Click();
            driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] ")).SendKeys("123");
            driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] ")).SendKeys("5-10");
            driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] ")).SendKeys("6");
            driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] ")).SendKeys("2");
            driver.FindElement(By.XPath("//input[contains(@id,\"ReorderLevel\")] ")).SendKeys("10");
            driver.FindElement(By.XPath("//input[contains(@id,\"Discontinued\")] ")).Click();
            driver.FindElement(By.XPath("//input[@type=\"submit\"]")).Click();
            Thread.Sleep(2000);
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
        public void TestLogout()
        {
            driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
                                
        }
    }
}