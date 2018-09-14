Feature: Login 
	In order to get into the system
	as a valid user I need to log in to the system

Background: 
	Given User is on the Login Page

Scenario: Valid User can log in Succesfully
	And User is inserting ray in the username textbox
	And User is inserting 123123 in the password textbox
 When User is clicking the in the Login Button
 Then User should see the Dashboard Page



 Scenario: Invalid User cannot log in Succesfully
	And User is inserting prasanna in the username textbox
	And User is inserting 123456 in the password textbox
 When User is clicking the in the Login Button
 Then User should see the Login Page with Error