Feature: TMFeatureSteps

As a TurnUp Portal admin
I want to Create, Edit and Delete Time and Material data
so that I can manage employee's Time and Material page

@mytag
Scenario: [Create new record in Time and Material page]
	Given I logged successfully in TurnUp Portal
	And I navigate to Time and Material option
	When I create new record in Time and Material page
	Then Created new record succesfully



Scenario Outline: edit existing record in Time and Material page
	Given I logged successfully in TurnUp Portal
	And I navigate to Time and Material option
	When I update '<Description>' and '<Code>' existing record in Time and Material page
	Then The record should be updated '<Description>' and '<Code>'

	Examples: 
	| Description | Code     |
	| Time        | TypeCode |
	| Material    | Code     |


