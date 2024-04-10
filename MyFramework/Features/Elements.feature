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

Scenario: Web Tables
And the user clicks on the Web Tables field
When the user clicks on the Add button
Then the user completes the form

Scenario: Buttons
And the user clicks on the Buttons field
When the user clicks on the Click Me button
Then the gets a text success

Scenario: Links
And the user clicks on the Links field
When the user clicks on the Home link
Then the user gets navigated to the Home page

Scenario: Broken Links - Images
And the user clicks on the Broken Link - Images field
When the user clicks on the Broken link
Then the user gets navigated to a broken page

Scenario: Upload
And the user clicks on the Upload and Download field
When the user chooses a file
Then the user gets a filepath response

Scenario: Download
And the user clicks on the UploadDownload button
When the user clicks on the download button
Then the user gets a file downloaded

Scenario: Dynamics Properties
And the user clicks on the Dynamics Properties field
When the user is met with a Will enable 5 seconds button
Then the user can see a new button appear


