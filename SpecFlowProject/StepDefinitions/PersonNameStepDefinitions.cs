using SpecFlowProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class PersonNameStepDefinitions
    {
        private readonly PersonPage _personPage;

        public PersonNameStepDefinitions(PersonPage personPage) =>
            _personPage = personPage;

        [Given(@"A person context")]
        public void GivenAPersonContext()
        {
            
        }

        [When(@"I change their name")]
        public void WhenIChangeTheirName()
        {
            _personPage.ChangeName();
        }

        [Then(@"the person name changes")]
        public void ThenThePersonNameChanges()
        {
            
        }
    }
}
