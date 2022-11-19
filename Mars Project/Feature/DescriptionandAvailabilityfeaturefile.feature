Feature: DescriptionandAvailabilityfeaturefile

A short summary of the feature

@tag1

Scenario:(01) Add description in profile page
	Given I signed into local host website successfully
	When I add '<Description>' in profile page
	Then '<Description>' should be add successfully

	Examples: 
	| Description  |
	| Data Analyst |
	| Developer    |

Scenario:(02) Add availability in profile page
	Given I signed into local host website successfully
	When I added '<Availability>' in profile page
	Then '<Availability>' should be added successfully

	Examples: 
	| Availability |
	| Full Time    |
	| Part Time    |