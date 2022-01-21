Feature: Employeefeature

As a TurnUp Portal admin
I want to create, edit and delete employee record
so that I can manage emplyoee's record

@mytag
Scenario: Create new record of Employee
	Given I logged successfully
	And I naviagte to the Employee
	When I create new record of employee
	Then New employee record created successfully

Scenario: Edit existed record of Employee
	Given I logged successfully
	And I naviagte to the Employee
	When I edit existed record of employee
	Then employee record edited successfully

Scenario: Delete existed record of Employee
	Given I logged successfully
	And I naviagte to the Employee
	When I delete existed record of employee
	Then  employee record deleted successfully
