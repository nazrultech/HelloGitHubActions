using Xunit;
using HelloGitHubActions.App;

namespace HelloGitHubActions.Tests
{
    public class SampleTests
    {
        [Fact]
        public void AddNumbers_ShouldReturnSum()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
