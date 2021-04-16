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

        private Interactor CreateInteractor() => new Interactor();

        [Test]
        public void WrapWords_StateUnderTest_ExpectedBehavior()
        {
            Interactor interactor = CreateInteractor();
            string text = File.ReadAllText("text.txt");
            string expectedText = File.ReadAllText("expected_result.txt");
            int width = 40;

            string result = interactor.WrapText(
                text,
                width);

            result.Should().Be(expectedText);
        }
    }
}
