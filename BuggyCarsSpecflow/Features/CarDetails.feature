Feature: CarDetails
	Navigate to the car page, display the details and vote

Background: 
	Given I have logged in and on the Cardetail page

@CarDetails
Scenario: Vote the car
	When I enter the Comment 'Cool'
	And I click the Vote button
	Then the car is voted