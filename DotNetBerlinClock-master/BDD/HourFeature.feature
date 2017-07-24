Feature: Hours
	In order to test the hours we need to make sure the these scenarios pass
	1.1) Hours first row indicator - In order to display to correct zero hour the top first row with 
	four red lights must be displayed correctly
	2.1) Hours second row indicator - In order to display to correct hour after being adjusted 
	the top second row with four red lights must be displayed correctly

	#Background: 
	#Given this is a Berlin Uhr Clock
	
# 1.1)
Scenario Outline: Hours first row indicator
Given this is the hours first row
When the current hour is <currentHour>
Then the expected hour first row output should be <theExpectedHourFirstRowOutput>

Examples: 
| currentHour	| theExpectedHourFirstRowOutput |
| 0				| OOOO	|
| 1				| OOOO	|
| 2				| OOOO	|
| 3				| OOOO	|
| 4				| OOOO	|
| 5				| ROOO	|
| 6				| ROOO	|
| 7				| ROOO	|
| 8				| ROOO	|
| 9				| ROOO	|
| 10			| RROO	|
| 11			| RROO	|
| 12			| RROO	|
| 13			| RROO	|
| 14			| RROO	|
| 15			| RRRO	|
| 16			| RRRO	|
| 17			| RRRO	|
| 18			| RRRO	|
| 19			| RRRO	|
| 20			| RRRR	|
| 21			| RRRR	|
| 22			| RRRR	|
| 23			| RRRR	|
| 24			| RRRR	|

# 2.1)
Scenario Outline: Hours second row indicator
Given this is the hours second row
When the current hour is <currentHour>
And an hour adjustment of <adjustment> is made
Then the expected hour second row output should be <theExpectedHourSecondRowOutput>

Examples: 
| currentHour	| adjustment  | theExpectedHourSecondRowOutput |
| 24			| 20		  | RRRR	|
| 13			| 10		  | RRRO	|
| 0				| 0			  | OOOO	|