Feature: Register

Background: 
Given Launch to the Home page
And I click on the Register
	
@Register @Positive
Scenario: Cancel Register
	When I click on the Cancel button
	Then I should be navigate to Home page

@Register @Positive
Scenario: Register with valid data
	And I enter data '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	When I click on the Register below
	Then I should be navigate to Home page
	And The '<Successful Message>' is displayed
Examples: 
| Login      | First Name | Last Name | Password  | Confirm Password | Successful Message         |
| HelloWorld | Hello      | World     | 1122qqWW~ | 1122qqWW~        | Registration is successful |



@Register @Negative
Scenario Outline: Not able to register with invalid data
	And I enter data '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	When I click on the Register below
	Then The '<Error Message>' displayed
Examples: 
| Login              | First Name | Last Name | Password | Confirm Password | Error Message            |
| PasswordLenthWrong | Hello      | World     | 1122qq   | 1122qq           | Password not long enough |