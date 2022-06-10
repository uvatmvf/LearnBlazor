using Bunit;
using MvcWebApp.Components;

namespace BlazorComponent.Tests
{
    public class PersonComponentTests
    {
        [Fact]
        public void ComponentRendersAsExpected()
        {
            using var context = new TestContext();
            var classUnderTest = context.RenderComponent<PersonComponent>();

            Assert.NotEmpty(classUnderTest.Markup);
        }
    }
}