Feature: User creation functionality
  As an admin
  I want to create a new user
  So that they can access the system

  Scenario: Create a new user successfully
    Given I navigate to the user creation page
    When I enter name "Alice"
    And I enter age "28"
    And I enter mailID "alice@example.com"
    And I enter occupation "Engineer"
    And I select gender "Female"
    And I click the create button
    Then the user should be created successfully
