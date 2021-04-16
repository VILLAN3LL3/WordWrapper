using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace WordWrapper.Tests
{
    [TestFixture]
    public class InteractorTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private Interactor CreateInteractor()
        {
            return new Interactor();
        }

        [Test]
        public void WrapWords_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var interactor = this.CreateInteractor();
            string text = File.ReadAllText("text.txt");
            string expectedText = File.ReadAllText("expected_result.txt");
            int width = 40;

            // Act
            var result = interactor.WrapWords(
                text,
                width);

            // Assert
            result.Should().Be(expectedText);
        }
    }
}
