Feature: OverallPage

Background: 
	Given Launch to the Home page
	And Navigate to the Overall Rating page
@OverallPage
Scenario: Navigate to the last page
	When click next page button to the last page
	Then Next page button should be disabled in the last page

@OverallPage
Scenario: Navigate to the car details page on the list
	When click the last one car in the list
	Then Navigate to the car details page