using MyFramework.Hooks;
using System;
using TechTalk.SpecFlow;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class FormsStepDefinitions
    {
        Person person = new Person(forename: "Alice",
    surname: "Johnson",
    address: "123 Main Street, Cityville",
    emailAddress: "alice.johnson@email.com",
    gender: "Female",
    mobile: "+1 555-1234",
    dateOfBirth: "1990-05-15",
    subjects: "Computer Science",
    hobbies: "Reading, Hiking",
    picture: "alice_profile_picture.jpg",
    currentAddress: "456 Oak Avenue, Townsville");

        [Given(@"the user is on the forms page")]
        public void GivenTheUserIsOnTheFormsPage()
        {
            // url check
        }

        [When(@"the user completes the student registeration form")]
        public void WhenTheUserCompletesTheStudentRegisterationForm()
        {

        }

        [Then(@"the user submits their details")]
        public void ThenTheUserSubmitsTheirDetails()
        {
            throw new PendingStepException();
        }
    }
}
