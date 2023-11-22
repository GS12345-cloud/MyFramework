using NUnit.Framework;

namespace MyFramework
{
    [TestFixture]
    public class GoogleSearchTests
    {
        [Test]
        public void RunGoogleSearchScenario()
        {
            // Use the SpecFlow test runner to execute scenarios
            TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart();
            TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd();

            // Alternatively, you can use your test runner to execute scenarios
            // For example, using NUnit Console Runner: nunit3-console.exe YourAssembly.dll
        }
    }
}