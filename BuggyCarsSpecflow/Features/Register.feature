Feature: Register

Background: 
Given Launch to the Home page
And I click on the Register

@Register @Positive
Scenario: Click Register
	Then I should be navigate to 'Register' page
	
@Register @Positive
Scenario: Cancel Register
	When I click on the Cancel
	Then I should be navigate to 'Home' page

@Register @Positive
Scenario: Register with valid data
	And I enter valid data '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	When I click on the Register below
	Then I register successfully
Examples: 
| Login      | First Name | Last Name | Password  | Confirm Password |
| HelloWorld | Hello      | World     | 1122qqWW~ | 1122qqWW~        |



@Register @Negative
Scenario Outline: Register with invalid data
	And I enter valid data <Login>,<First Name>,<Last Name>, <Password> and <Confirm Password>
	When I click on the Register below
	Then The wrong message displayed
| Login                   | First Name | Last Name | Password  | Confirm Password |
|                         | NoLogin    | World     | 1122qqWW~ | 1122qqWW~        |
| No Firstname            |            | World     | 1122qqWW~ | 1122qqWW~        |
| No Lastname             | Hello      |           | 1122qqWW~ | 1122qqWW~        |
| NoPassword              | Hello      | World     |           |                  |
| NoUpperletterInPassword | Hello      | World     | 1122qqqq  | 1122qqqq~        |
| NoLowerletterInPassword | Hello      | World     | 1122WWWW  | 1122WWWW~        |
| NoNumericInPassword     | Hello      | World     | qqqqqqWW  | qqqqqqWW         |
| PasswordLenthWrong      | Hello      | World     | 1122      | 1122             |
| PasswordDonotMatch      | Hello      | World     | 1122qqWW~ | 1122qqWW         |

@Register @Negative
Scenario: Register with already registered data
	And I enter valid data '<Login>','<First Name>','<Last Name>', '<Password>' and '<Confirm Password>'
	When I click on the Register below
	Then I register successfully
Examples: 
| Login      | First Name | Last Name | Password  | Confirm Password |
| HelloWorld | Hello      | World     | 1122qqWW~ | 1122qqWW~        |