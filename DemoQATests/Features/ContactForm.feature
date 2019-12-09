Feature: ContactForm

Scenario: Contact form load
	Given the user navigates to the DemoQA site
	And navigates to 'contact form'
	And the contact form is completed
		| FirstName | LastName | Country | Subject                                  |
		| Man       | Like     | Road    | Filling the subject field with this text |
	When the form is submitted
	Then the error 'Oops! That page can’t be found.' is displayed