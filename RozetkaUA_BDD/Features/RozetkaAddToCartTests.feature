Feature: RozetkaAddToCartTests
	In order to easily add product to the cart 
	As a rozetka user 
	I want to be able to search through field search

@smoke
Scenario: Entering the name of the product in Search Field from the Main Page should open with Products Page then choose anything product add to cart
	Given I open official Rozetka web site
	When I entered name of product from the Home Page
	When I buy Product from the Search Page
	When I click on Cart
	Then I verify the item is in a cart from Cart Page
