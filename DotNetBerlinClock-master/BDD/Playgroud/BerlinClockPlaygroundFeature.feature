Feature: BerlinClockPlayground
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time

	Background: 
	Given this is a Berlin Clock

Scenario: Strongly typed table data
When the clock has the following attributes strongly typed
|attributes		|value	|
|hour			|13		|
|minutes		|17		|
|seconds		|01		|
Then the display should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

#Scenario: Dynamic table data
#When the clock has the following attributes dynamic
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Multi-column table data
#When the clock has the following attributes muliti column
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Custom Data Conversion
#When the clock has the following attributes custom conversion
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Auto custom data conversion
#When the clock has the following attributes auto custom conversion
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Pass data between step definitions
#When the clock has the following attributes data between step definitions
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Context injection
#When the clock has the following attributes context injection
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Tags to execute substeps
#When the clock has the following attributes tags to execute substeps
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Restrict step execution
#When the clock has the following attributes restrict step execution
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Scope binding rules
#When the clock has the following attributes scope binding rules
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Scope binding rules team workflow
#When the clock has the following attributes scope binding rules team workflow
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Hooks
#When the clock has the following attributes hooks
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Using before and after
#When the clock has the following attributes using before and after
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Hook execution ordering
#When the clock has the following attributes hook execution ordering
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Scenario backgrounds and before scenario
#When the clock has the following attributes scenario backgrounds and before scenario
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""
#
#Scenario: Parallel test execution
#When the clock has the following attributes parallel test execution
#|attributes		|value	|
#|hour			|13		|
#|minutes		|17		|
#|seconds		|01		|
#Then the display should look like
#"""
#O
#RROO
#RRRO
#YYROOOOOOOO
#YYOO
#"""