Feature: ButtonElement

A short summary of the feature

@ButtonOne
Scenario: Check the Button Element
	Given check whether landing page is loaded properly
	When the button element is clicked
	Then alert button should be displayed

	@ButtonAlert
Scenario: Check the Button Alert Element
	Given check whether landing page is loaded properly
	When the alert button element is clicked
	Then success button is displayed

	@ButtonOne
Scenario: Check the Button Success Element
	Given check whether landing page is loaded properly
	When the success button element is clicked
	Then button element is displayed