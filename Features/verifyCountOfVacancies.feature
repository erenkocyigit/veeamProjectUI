Feature: Veeam UI test case


Scenario: Compare number of jobs found and value of expected result
Given user is on careers page
When user selects Research & Development in All Departments dropdown
And user selects English language in All Languages list
Then assert that number of jobs found will match expected result

