Feature: APIApplication


@mytag
Scenario: Get API response using given endpoint
	Given I have a endpoint /endpoint/
	#And I have base url https://www.google.com        //?
	When I call get method of api
	Then I get API response in json format

	#http://mydomain.com/userinformation/userid
	Scenario Outline: Get user informaion using userid
	Given I have a endpoint /userInformation/
	When I call get method to get user information using <userid>
	Then I will get user information

	Examples: User Info
	| userid    |
	| user10001 |

	#http://mydomain.com/userinformation/userid/AccountInformation?account={accountNumber}
	Scenario Outline: Get user account information using userid and accountnumber
	Given I have a endpoint /userInformation/
	When I call get method to get user account information using <userid> and <accountNumber>
	Then I will get user account information

	Examples: User Info
	| userid    | accountNumber |
	| user10001 | 123456789     |