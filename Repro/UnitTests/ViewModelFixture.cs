using Repro;
using Xunit;

namespace UnitTests
{
    public class ViewModelFixture
    {
        [Theory]
        [InlineData("Kent", "Boogaart", "Boogaart, Kent")]
        [InlineData("Geoffrey", "Huntley", "Huntley, Geoffrey")]
        public void name_reflects_first_and_last_names(string firstName, string lastName, string expectedName)
        {
            var sut = new ViewModel
            {
                FirstName = firstName,
                LastName = lastName
            };

            Assert.Equal(expectedName, sut.Name);
        }
    }
}