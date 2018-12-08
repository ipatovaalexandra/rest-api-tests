Feature: APIApplication


@mytag
Scenario: Get API response using given endpoint
	Given I have a endpoint /endpoint/
	#And I have base url https://www.google.com        //?
	When I call get method of api
	Then I get API response in json format

	Scenario Outline: Get user informaion using userid
	Given I have a endpoint / userInformation/
	When I call get method to get user information using <userid>
	Then I will get user information

	Examples: User Info
	| userid    |
	| user10001 |