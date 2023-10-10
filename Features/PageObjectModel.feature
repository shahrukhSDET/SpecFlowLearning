Feature: PageObjectModel

Browsing SBI Website for Agricultural Related Vehicle Loan

@01_Vehicle_loan
Scenario: Apply for Tractor Loan
	Given Input URL of sbi web application
	When Hovering on SBI Loans
	And clicking on Vehicle loan
	Then Routing on Agricultural & Rural page
