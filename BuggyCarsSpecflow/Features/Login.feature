Feature: Login/Logout

Background: 
Given Launch to the Home page

@Login @Positive
Scenario: Login with valid data
	And I enter '<Login Name>' and '<Password>'
	When I click Login button
	Then I login successfully

	Examples: 
	| Login Name | Password  |
	| moya       | 1122qqWW~ |

@Login @Negative
Scenario Outline: Not able to login with invalid data
	And I enter '<Login Name>' and '<Password>'
	When I click Login button
	Then I login failed

	Examples: 
	| Login Name | Password |
	|            | NoName   |
	| NoPassword |          |
	| NotMatch   | No       |

@Logout @Positive
Scenario: Logout with valid data
	And I enter '<Login Name>' and '<Password>'
	When I click Login button
	And I click Logout
	Then I logout successfully

	Examples: 
	| Login Name | Password  |
	| moya       | 1122qqWW~ |
