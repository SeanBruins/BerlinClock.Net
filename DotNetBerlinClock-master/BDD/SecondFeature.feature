Feature: Seconds
	In order for the light to display correctly 
		the round yellow light on top blinks on and off (Y/O)
		I want to denote even numbers - (when lit) 
		or odd-numbered (when unlit) in seconds.

Scenario Outline: Seconds Indicator
Given this is the top second indicator
When this second is <currentSecond>
Then this top second lamp should be <expectedTopSecondIndicatorOutput>

Examples: 
| currentSecond | expectedTopSecondIndicatorOutput|
| 0				| Y	|
| 1				| O	|
| 2				| Y	|
| 3				| O	|
| 4				| Y	|
