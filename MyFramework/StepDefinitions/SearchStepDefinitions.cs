using System;
using TechTalk.SpecFlow;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        [Given(@"the user needs search for a site")]
        public void GivenTheUserNeedsSearchForASite()
        {
            throw new PendingStepException();
        }

        [When(@"the user enters text into the field")]
        public void WhenTheUserEntersTextIntoTheField()
        {
            throw new PendingStepException();
        }

        [Then(@"the user clicks the search to find the site")]
        public void ThenTheUserClicksTheSearchToFindTheSite()
        {
            throw new PendingStepException();
        }
    }
}
