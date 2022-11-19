Feature: Skillsfeature

A short summary of the feature

Aa a seller I want the feature to manage my skill details.
So that I ama able to add, edit or delete my skill records.
@tag1


Scenario Outline:1-Add skills in profile page
	Given I logged into local host website successfully
	When I added '<Skill>' and '<SkillLevel>'in profile page
	Then The '<Skill>'  and '<SkillLevel>' should be added successfully

	Examples: 
	| Skill              | SkillLevel   |
	| C#                 | Beginner     |
	| Python             | Beginner     |
	| Selenium WebDriver | Intermediate |

Scenario Outline:2-Edit skills in profile page
	Given I logged into local host website successfully
	When I edited '<Skill>' and '<SkillLevel>' in profile page
	Then '<Skill>' and '<SkillLevel>' should be edited  successfully

	Examples: 
	| Skill | SkillLevel |
	| Java  | Beginner   |

Scenario Outline:3- Delete skills in profile page
	Given I logged into local host website successfully
	When I deleted '<Skill>' and '<SkillLevel>' in profile page
	Then '<Skill>' and '<SkillLevel>' should be  deleted successfully

	Examples: 
	| Skill | SkillLevel |
	| Java  | Beginner   |
