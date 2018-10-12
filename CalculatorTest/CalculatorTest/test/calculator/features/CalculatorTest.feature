Feature: Calculator
      
@CalculatorTests
Scenario: Add two numbers
	Given The calculator has opened in Standard view
	When I enter number 12
	When I press operators button Plus
	When I enter number 999
	When I press operators button Result
	When I press function button SaveToMemory
	When I enter number 19
	When I press operators button Plus
	When I press function button UseMemory
	When I press operators button Result
	When I press function button MemoryClear
	Then The result of operation should be 1030

	Given The calculator has opened in Scientific view
	When I enter number 12
	When I press operators button Plus
	When I enter number 999
	When I press operators button Result
	When I press function button SaveToMemory
	When I enter number 19
	When I press operators button Plus
	When I press function button UseMemory
	When I press operators button Result
	When I press function button MemoryClear
	Then The result of operation should be 1030


