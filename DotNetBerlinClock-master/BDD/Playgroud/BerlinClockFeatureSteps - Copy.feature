
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario: Midnight 00:00
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""


Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Just before midnight
When the time is "23:59:59"
Then the clock should look like
"""
O
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight incorrect 24:00
When the time is "24:00:00"
Then the clock should not look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""

##*****************************************************END****************************************************##
	#In order for the light to display correctly 
	#the round yellow light on top blinks on and off (Y/O)
	#I want to denote even- (when lit) 
	#or odd-numbered (when unlit) in seconds.
######################################################

Scenario Outline: Single top yellow lamp
Given this is a yellow lamp
When this second is <currentSecond>
Then this lamp should be <expectedLamp>

Examples: 
| currentSecond | expectedLamp|
| 0				| Y	|
| 1				| O	|
| 2				| Y	|
| 3				| O	|
| 4				| Y	|

##*****************************************************END****************************************************##
	#In order to test the hours we need to make sure the these scenarios pass
	#1.1) TopFirstRow - In order to display to correct zero hour the top first row with 
	#four red lights must be displayed correctly
	#2.1) TopSecondRow - In order to display to correct hour after being adjusted 
	#the top second row with four red lights must be displayed correctly
######################################################
	#Background: 
	#Given this is a Berlin Uhr Clock
	
# 1.1)
Scenario Outline: Top first row with four red lamps display zero hour
Given the top first row consisting of four red lamps
When the current hour is <currentHour>
Then the expected first row result should be <expectedLampResult>

Examples: 
| currentHour	| expectedLampResult |
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
Scenario Outline: Top second row with four red lamps display correctly after adjustment
Given the top second row consisting of four red lamps
When the current hour is <currentHour>
And an adjustment of <adjustment> is made
Then the expected second row result should be <expectedLampResult>

Examples: 
| currentHour	| adjustment  | expectedLampResult |
| 24			| 20		  | RRRR	|
| 13			| 10		  | RRRO	|
| 0				| 0			  | OOOO	|
#################################################################################################################################

#################################################################################################################################

#################################################################################################################################

#################################################################################################################################