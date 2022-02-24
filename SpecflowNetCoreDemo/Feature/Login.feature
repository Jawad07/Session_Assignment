Feature: Login
	Login to EA application


@smoke
Scenario: Perform Login 
	Given I launch the application
	Then  I click login link
	Then  I enter the following details
		  | UserName | Password |
		  | admin    | password |
    Then  I click login button
	Then I should see Employee details link