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
| Login                   | First Name | Last Name | Password  | Confirm Password | Error Message            |
|                         | NoLogin    | World     | 1122qqWW~ | 1122qqWW~        | Login is required        |
| No Firstname            |            | World     | 1122qqWW~ | 1122qqWW~        | Login is required        |
| No Lastname             | Hello      |           | 1122qqWW~ | 1122qqWW~        | Login is required        |
| NoPassword              | Hello      | World     |           |                  | Login is required        |
| NoUpperletterInPassword | Hello      | World     | 1122qqqq  | 1122qqqq~        | Login is required        |
| NoLowerletterInPassword | Hello      | World     | 1122WWWW  | 1122WWWW~        | Login is required        |
| NoNumericInPassword     | Hello      | World     | qqqqqqWW  | qqqqqqWW         | Login is required        |
| PasswordLenthWrong      | Hello      | World     | 1122qq    | 1122qq           | Password not long enough |
| PasswordDonotMatch      | Hello      | World     | 1122qqWW~ | 1122qqWW         | Login is required        |

@Register @Negative
Scenario: Not able to register with already registered data
	And I enter valid data '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	When I click on the Register below
	Then I register successfully
Examples: 
| Login      | First Name | Last Name | Password  | Confirm Password |
| HelloWorld | Hello      | World     | 1122qqWW~ | 1122qqWW~        |