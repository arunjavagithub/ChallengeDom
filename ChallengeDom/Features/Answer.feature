Feature: Answer Feature File

A short summary of the feature

@tag1

Scenario: Check the answer for every refresh
	Given get the 'oldanswer' from the landing page
	When refresh the page 'newanswer' is displayed
	Then validate the old answer and new answer
