Feature: Xbox game search

Searching for xbox series -x product on the official website of Microsoft

@01_X-box_Gaming_Console_search
Scenario: Searching for xbox series-x product
	Given Open the browser		
	When Enter URL of Application
	Then Search for X-box product in Search field of Microsoft Official Website

@02_X-box_Gaming_Console_search
Scenario: Routing on main product page
	When Enter URL of Website
	Then Veiwing the product page

@03_Count_number_of_links_on_homePage
Scenario: Total links on Home Page
	When URL of Home Page
	Then Count the links on the main page




	