Feature: Elements

Background: 
Given the user is on the elements page

Scenario: Text Box
And the user clicks on the Text Box field
When the user enters their details
Then the user observes a new box appearing below the submit button

Scenario: Checkbox
And the user clicks on the Check Box field
When the user clicks on the Home checkbox
Then all the checkboxes change to ticked

Scenario: Radio Button
And the user clicks on the Radio Button field
When the user clicks on the Yes radio button
Then then the user is informed the Yes button has been selected