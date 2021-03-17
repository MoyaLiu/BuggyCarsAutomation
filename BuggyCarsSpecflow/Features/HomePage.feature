Feature: HomePage

Background: 
	Given Launch to the Home page

@HomePage @Posivite
Scenario: Navigate to the Register page
	When I click on the Register
	Then I should be navigate to Register page

@HomePage @Posivite
Scenario: Navigate to the Popular Make page
	When I click on the Popular Make
	Then I should be navigate to Popular Make page

@HomePage @Posivite
Scenario: Navigate to the Popular Model page
	When I click on the Popular Model
	Then I should be navigate to Popular Model page

@HomePage @Posivite
Scenario: Navigate to the Overall Rating page
	When I click on the Overall Rating
	Then I should be navigate to Overall Rating page
