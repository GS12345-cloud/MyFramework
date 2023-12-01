using TechTalk.SpecFlow;


namespace MyFramework
{
    [Binding]
    public class TestRunner
    {
        // This method runs before each scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Add setup logic here
            Console.WriteLine("Before Scenario: Performing setup");
        }

        // This method runs after each scenario
        [AfterScenario]
        public void AfterScenario()
        {
            // Add teardown logic here
            Console.WriteLine("After Scenario: Performing teardown");
        }

        // This method runs after all scenarios in the feature
        [AfterFeature]
        public static void AfterFeature()
        {
            // Add feature-level teardown logic here
            Console.WriteLine("After Feature: Performing feature-level teardown");
        }

        // This method runs after all scenarios in the test run
        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Add test run-level teardown logic here
            Console.WriteLine("After Test Run: Performing test run-level teardown");
        }
    }
}