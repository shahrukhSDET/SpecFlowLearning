Feature: PageObjectModel

Browsing SBI Website for Agricultural Related Vehicle Loan

@01_Vehicle_loan
Scenario: Apply for Tractor Loan
	Given Input URL of sbi web application
	When Hovering on SBI Loans
	Then Clicking on Agri_Rural link from AutoLoans page

@02_Clicking_on_login_button 
Scenario: Open the login page
	Given Type in end point of Application
	Then Click on the Login button
