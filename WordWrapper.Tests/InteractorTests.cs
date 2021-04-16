using System;
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
            string text = "Curabitur, scelerisque magnis porttitor condimentum vestibulum sapien scelerisque malesuada natoque ultrices per, ante" +
                Environment.NewLine +
                "interdum conubia phasellus eget. Eleifend dignissim." +
                Environment.NewLine +
                Environment.NewLine +
                "Dignissim facilisis quam taciti fusce metus amet litora quisque turpis blandit sed. Suspendisse natoque proin nunc primis fusce." +
                Environment.NewLine +
                Environment.NewLine +
                "Molestie. Duis pede senectus nunc integer sed Porttitor lectus dapibus vivamus id dolor" +
                Environment.NewLine +
                "sollicitudin nascetur, facilisi gravida non habitant tristique velit." +
                Environment.NewLine +
                Environment.NewLine +
                "Magnis. Suspendisse, rutrum sit Justo nisl nisi malesuada aenean aptent sed primis. Tempor fames erat tortor." +
                Environment.NewLine +
                Environment.NewLine +
                "Lobortis potenti curabitur, tellus habitant, hymenaeos rutrum erat nunc sodales natoque conubia" +
                Environment.NewLine +
                "hendrerit quam aptent mollis sit aenean enim vivamus felis, feugiat massa duis ullamcorper bibendum." +
                Environment.NewLine +
                Environment.NewLine +
                "Lobortispotenticurabiturtellushabitanthymenaeosrutrumerat";
            string expectedText = "Curabitur, scelerisque magnis porttitor" +
                Environment.NewLine +
                "condimentum vestibulum sapien" +
                Environment.NewLine +
                "scelerisque malesuada natoque ultrices" +
                Environment.NewLine +
                "per, ante interdum conubia phasellus" +
                Environment.NewLine +
                "eget. Eleifend dignissim." +
                Environment.NewLine +
                Environment.NewLine +
                "Dignissim facilisis quam taciti fusce" +
                Environment.NewLine +
                "metus amet litora quisque turpis blandit" +
                Environment.NewLine +
                "sed. Suspendisse natoque proin nunc" +
                Environment.NewLine +
                "primis fusce." +
                Environment.NewLine +
                Environment.NewLine +
                "Molestie. Duis pede senectus nunc" +
                Environment.NewLine +
                "integer sed Porttitor lectus dapibus" +
                Environment.NewLine +
                "vivamus id dolor sollicitudin nascetur," +
                Environment.NewLine +
                "facilisi gravida non habitant tristique" +
                Environment.NewLine +
                "velit." +
                Environment.NewLine +
                Environment.NewLine +
                "Magnis. Suspendisse, rutrum sit Justo" +
                Environment.NewLine +
                "nisl nisi malesuada aenean aptent sed" +
                Environment.NewLine +
                "primis. Tempor fames erat tortor." +
                Environment.NewLine +
                Environment.NewLine +
                "Lobortis potenti curabitur, tellus" +
                Environment.NewLine +
                "habitant, hymenaeos rutrum erat nunc" +
                Environment.NewLine +
                "sodales natoque conubia hendrerit quam" +
                Environment.NewLine +
                "aptent mollis sit aenean enim vivamus" +
                Environment.NewLine +
                "felis, feugiat massa duis ullamcorper" +
                Environment.NewLine +
                "bibendum." +
                Environment.NewLine +
                Environment.NewLine +
                "Lobortispotenticurabiturtellushabitanthymenaeosrutrumerat";
            const int width = 40;

            string result = interactor.WrapText(
                text,
                width);

            result.Should().Be(expectedText);
        }
    }
}
