Feature: Login to App
	As a user
	I want to log in to the app
	So i can view the list of products

Scenario: Login to App

	Given I open "http://localhost:5000/" url
	When I enter "user" in the Name-field
	And I enter "user" in the Password-field
	And I click on the Send-button
	Then Home page should be open
