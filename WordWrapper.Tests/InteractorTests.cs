using FluentAssertions;
using NUnit.Framework;

namespace WordWrapper.Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private Interactor CreateInteractor() => new Interactor();

        [Test]
        public void WrapWords_StateUnderTest_ExpectedBehavior()
        {
            Interactor interactor = CreateInteractor();
            const string text = "Curabitur, scelerisque magnis porttitor condimentum vestibulum sapien scelerisque malesuada natoque ultrices per, ante\r\n" +
                "interdum conubia phasellus eget. Eleifend dignissim.\r\n" +
                "\r\n" +
                "Dignissim facilisis quam taciti fusce metus amet litora quisque turpis blandit sed. Suspendisse natoque proin nunc primis fusce.\r\n" +
                "\r\n" +
                "Molestie. Duis pede senectus nunc integer sed Porttitor lectus dapibus vivamus id dolor\r\n" +
                "sollicitudin nascetur, facilisi gravida non habitant tristique velit.\r\n" +
                "\r\n" +
                "Magnis. Suspendisse, rutrum sit Justo nisl nisi malesuada aenean aptent sed primis. Tempor fames erat tortor.\r\n" +
                "\r\n" +
                "Lobortis potenti curabitur, tellus habitant, hymenaeos rutrum erat nunc sodales natoque conubia\r\n" +
                "hendrerit quam aptent mollis sit aenean enim vivamus felis, feugiat massa duis ullamcorper bibendum.\r\n" +
                "\r\n" +
                "Lobortispotenticurabiturtellushabitanthymenaeosrutrumerat";
            const string expectedText = "Curabitur, scelerisque magnis porttitor\r\n" +
                "condimentum vestibulum sapien\r\n" +
                "scelerisque malesuada natoque ultrices\r\n" +
                "per, ante interdum conubia phasellus\r\n" +
                "eget. Eleifend dignissim.\r\n" +
                "\r\n" +
                "Dignissim facilisis quam taciti fusce\r\n" +
                "metus amet litora quisque turpis blandit\r\n" +
                "sed. Suspendisse natoque proin nunc\r\n" +
                "primis fusce.\r\n" +
                "\r\n" +
                "Molestie. Duis pede senectus nunc\r\n" +
                "integer sed Porttitor lectus dapibus\r\n" +
                "vivamus id dolor sollicitudin nascetur,\r\n" +
                "facilisi gravida non habitant tristique\r\n" +
                "velit.\r\n" +
                "\r\n" +
                "Magnis. Suspendisse, rutrum sit Justo\r\n" +
                "nisl nisi malesuada aenean aptent sed\r\n" +
                "primis. Tempor fames erat tortor.\r\n" +
                "\r\n" +
                "Lobortis potenti curabitur, tellus\r\n" +
                "habitant, hymenaeos rutrum erat nunc\r\n" +
                "sodales natoque conubia hendrerit quam\r\n" +
                "aptent mollis sit aenean enim vivamus\r\n" +
                "felis, feugiat massa duis ullamcorper\r\n" +
                "bibendum.\r\n" +
                "\r\n" +
                "Lobortispotenticurabiturtellushabitanthymenaeosrutrumerat";
            const int width = 40;

            string result = interactor.WrapText(
                text,
                width);

            result.Should().Be(expectedText);
        }
    }
}
