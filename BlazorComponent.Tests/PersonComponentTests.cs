using Bunit;
using MvcWebApp.Components;

namespace BlazorComponent.Tests
{
    public class PersonComponentTests
    {
        [Fact]
        public void ComponentRendersAsExpected()
        {
            using var context = new BunitContext();
            var classUnderTest = context.Render<PersonComponent>();

            Assert.NotEmpty(classUnderTest.Markup);
        }
    }
}