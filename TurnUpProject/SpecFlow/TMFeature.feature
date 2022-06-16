Feature: TMFeature

As a TurnUp Portal Admin
I would like to Create,Edit,Delete Time and Material Records
So that i can manage employees Time and Material Page Successfully

@smoke
Scenario:1 Create Time and Material record with valid Credentials
	Given I logged in TurnUp Portal Successfully
	When I Navigate to Time and Material Page
	When I Create Time and Material Record
	Then Time and Naterial Record Created Successfully
