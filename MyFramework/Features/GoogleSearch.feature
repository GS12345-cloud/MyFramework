Feature: Google Search
    In order to find information
    As a user
    I want to be able to search on Google

Scenario: Search for a term on Google
    Given I am on the Google homepage
    When I search for "SpecFlow and Selenium"
    Then I should see search results related to "SpecFlow and Selenium" 