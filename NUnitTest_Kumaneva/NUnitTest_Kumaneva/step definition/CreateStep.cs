using NUnit.Framework;
using NUnitTest_Kumaneva.business_object;
using NUnitTest_Kumaneva.service.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTest_Kumaneva.step_definition
{
    [Binding]
    public sealed class CreateStep
    {
        private IWebDriver driver;

        [Given(@"I open this url ""(.*)""")]
        public void GivenIOpenThisURL(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;

        }

        [When(@"I enter ""(.*)"" in Name field")]
        public void WhenIenterUserInTheNameField(string name)
        {
            new StartPage(driver).NameLoginInput(name);
        }

        [When(@"I enter ""(.*)"" in Password field")]
        public void WhenIenterUserInThePasswordField(string password)
        {
            new StartPage(driver).LoginPaswordInput(password);
        }

        [When(@"I click on Send-button")]
        public void WhenIClickOnSendButton()
        {
            new StartPage(driver).SendButtonClick();
        }

        [When(@"I click on the AllProducts-button")]
        public void WhenIClickOnTheAllProductButton()
        {     
            new HomePage(driver).AllProductView();
        }

        [When(@"I click on the CreateNew-button")]
        public void WhenIClickOnTheCreateNewButton()
        {            
            new AllProductsPage(driver).createButtonClick();
        }

        [When(@"I enter the product data in the field: NameProduct ""(.*)"", UnitPrice ""(.*)"", QuantityPerUnit ""(.*)"", UnitInStock ""(.*)"", UnitsOnOrder ""(.*)"", ReorderLevel ""(.*)""")]
        public void WhenIEnterTheProductDataInTheField(string nameProduct, string costUnitPrice, string numberQuantityPerUnit, string numberUnitsInStock, string numberUnitsOnOrder, string numberReorderLevel)
        {
            CreateProductPage createProductPage = new CreateProductPage(driver);
            createProductPage = createProductPage.InputProduct(new Products(nameProduct, costUnitPrice, numberQuantityPerUnit, numberUnitsInStock, numberUnitsOnOrder, numberReorderLevel));          
            
          
        }

        [When(@"I select category ""(.*)"" and supplier ""(.*)"" in fields")]
        public void WhenISelectTCategoryAndSupplierInFields(int numberCategory, int numberSupplier)
        {
            new CreateProductPage(driver).CategorySupplierClick(numberCategory, numberSupplier);
        }

        [When(@"I click on the CreateProduct-button")]
        public void WhenIClickOnTheCreateProductButton()
        {
            new CreateProductPage(driver).ClickCreateButton();
        }
        [Then(@"I see product ""(.*)"" in the table All Product")]
        public void ThenIseeTheCreatedProductInTheTable(string nameProduct)
        {
            AllProductsPage allProductsPage = new AllProductsPage(driver);            

            Assert.AreEqual("Kukuruku", allProductsPage.GetNameProductText(nameProduct));
            
        }






    }
}
