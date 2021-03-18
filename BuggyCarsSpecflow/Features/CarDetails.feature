Feature: CarDetails
	Navigate to the car page, display the details and vote

@CarDetails
Scenario: Vote the car
	Given I register a new account with '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	And I logged in with '<Login>','<Password>'and go to the Car detail page
	When I enter the Comment 'Cool'
	And I click the Vote button
	Then the car is voted
	Examples: 
	| Login      | First Name | Last Name | Password  | Confirm Password |
	| HelloWorld | Hello      | World     | 1122qqWW~ | 1122qqWW~        |