Feature: Login functionality
  As a registered user
  I want to login to the application
  So that I can access my account

  Scenario: Successful login with valid credentials
    Given I navigate to the login page
    When I enter username "testUser" and password "password123"
    And I click the login button
    Then I should be logged in successfully

  Scenario: Failed login with invalid credentials
    Given I navigate to the login page
    When I enter username "testUser" and password "wrongpass"
    And I click the login button
    Then I should see an error message
