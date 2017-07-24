Feature: Minutes
The third row consists of eleven yellow-and-red fields, which denote five 
full minutes each (the red ones also denoting 15, 30 and 45 minutes past), 
and the bottom row has another four yellow fields, which mark one full minute each. 
In order to test the minutes we need to make sure the these scenarios pass
1.1) BottomFirstRow - In order to display to correct minute after being adjusted 
	the minutes first row indicator must be displayed correctly
2.1) BottomSecondRow - In order to display to correct minute after being adjusted 
	the minutes second row indicator must be displayed correctly
	
	#Background: 
	#Given this is a Berlin Uhr Clock
	
# 1.1)
Scenario Outline: Minutes first row indicator
Given this is the minutes first row
When the current minute is <currentMinute>
Then the expected minutes first row output should be <expectedMinutesFirstRowOutput>

Examples: 
| currentMinute	| expectedMinutesFirstRowOutput |
| 0				| OOOOOOOOOOO					|
| 17			| YYROOOOOOOO					|
| 59			| YYRYYRYYRYY					|

# 2.1)
Scenario Outline: Minutes second row indicator
Given this is the minutes second row
When the current minute is <currentMinute>
And a minute adjustment of <adjustment> is made
Then the expected minute second row output should be <theExpectedMinuteSecondRowOutput>

Examples: 
| currentMinute	| adjustment	| theExpectedMinuteSecondRowOutput	|
| 0				| 0				| OOOO								|
| 17			| 15			| YYOO								|
| 59			| 55			| YYYY								|