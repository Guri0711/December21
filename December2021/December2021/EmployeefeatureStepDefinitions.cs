using System;
using TechTalk.SpecFlow;

namespace December2021
{
    [Binding]
    public class EmployeefeatureStepDefinitions
    {
        [Given(@"I logged successfully")]
        public void GivenILoggedSuccessfully()
        {
           
        }

        [Given(@"I naviagte to the Employee")]
        public void GivenINaviagteToTheEmployee()
        {
           
        }

        [When(@"I create new record of employee")]
        public void WhenICreateNewRecordOfEmployee()
        {
           
        }

        [Then(@"New employee record created successfully")]
        public void ThenNewEmployeeRecordCreatedSuccessfully()
        {
            
        }

        [When(@"I edit existed record of employee")]
        public void WhenIEditExistedRecordOfEmployee()
        {
           
        }

        [Then(@"employee record edited successfully")]
        public void ThenEmployeeRecordEditedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I delete existed record of employee")]
        public void WhenIDeleteExistedRecordOfEmployee()
        {
            
        }

        [Then(@"employee record deleted successfully")]
        public void ThenEmployeeRecordDeletedSuccessfully()
        {
            
        }
    }
}
