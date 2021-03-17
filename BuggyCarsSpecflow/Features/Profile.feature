Feature: Profile

Background: 
	Given Launch to the Home page
	And I have logged in
	And I click on the Profile
 
@Profile @Positive
Scenario: Navigate to Profile page
	Then I should be navigate to the Profile page

@Profile @Positive
Scenario: Save with enter valid data
	When I input '<Gender>','<Age>','<Address>','<Phone>' and'<Hobby>'
	And I click on Save button
	Then The '<Successful Message>' on profile displayed
	Examples: 
	| Gender | Age | Address | Phone   | Hobby   | Successful Message                    |
	| F      | 20  | city    | 1111111 | Drawing | The profile has been saved successful |

@Profile @Positive
Scenario: Cancel on the Profile page
	When I click on Cancel button
	Then I should be navigate to Home page


	


