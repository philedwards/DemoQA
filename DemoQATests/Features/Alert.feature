Feature: Alert

Scenario: Alert
	Given the user navigates to the DemoQA site
	And submits the contact form with the below values
		| FirstName | LastName | Country | Subject                                  | Error                           |
		| Man       | Like     | Road    | Filling the subject field with this text | Oops! That page can’t be found. |
	And searches for 'ra'
	And navigates to 'Automation Practice Switch Windows'
	When Alert Box is clicked
	Then the alert is displayed
		| AlertText                                                                                                               |
		| Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization. |	