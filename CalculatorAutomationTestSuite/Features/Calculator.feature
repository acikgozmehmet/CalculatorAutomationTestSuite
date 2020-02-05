Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of several math operations on two numbers


@addition
Scenario: Add two numbers
	Given I have the calculator
	When I enter 50 into the calculator
    And I press addition sign
	And I enter 70 into the calculator
	And I press Equals sign
	Then the result should be 120 on the screen


@subtraction
Scenario: Subtract two numbers
	Given I have the calculator
	When I enter 50 into the calculator
    And I press subtraction sign
	And I enter 70 into the calculator
	And I press Equals sign
	Then the result should be -20 on the screen


@multiplication
Scenario: Multiply two numbers
	Given I have the calculator
	When I enter 50 into the calculator
    And I press multiplication sign
	And I enter 70 into the calculator
	And I press Equals sign
	Then the result should be 3500 on the screen

@division
Scenario: Divide two numbers
	Given I have the calculator
	When I enter 50 into the calculator
    And I press division sign
	And I enter 5 into the calculator
	And I press Equals sign
	Then the result should be 10 on the screen
