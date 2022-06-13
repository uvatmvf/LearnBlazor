using SpecFlowProject.PageObjects;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class TestExecutionHooks
    {
        [BeforeScenario]
        public void BeforeScenario(PersonPage personPage)
        {
            personPage.Goto();
        }
    }
}
