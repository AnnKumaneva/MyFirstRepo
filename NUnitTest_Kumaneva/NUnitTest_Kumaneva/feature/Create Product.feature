Feature: Create New Product
	As a user
	I want to open the app
	So i can view the list of products and create a new one

Scenario: Create New Product

	Given I open this url "http://localhost:5000/"
	When I enter "user" in Name field
	And I enter "user" in Password field
	And I click on Send-button
	And I click on the AllProducts-button
	And I click on the CreateNew-button
	And I enter the product data in the field: NameProduct "Kukuruku", UnitPrice "123", QuantityPerUnit "5-10", UnitInStock "6", UnitsOnOrder "2", ReorderLevel "10"
	And I select category "3" and supplier "26" in fields
	When I click on the CreateProduct-button
	Then I see product "Kukuruku" in the table All Product