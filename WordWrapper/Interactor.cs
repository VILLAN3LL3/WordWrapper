using System.Collections.Generic;

namespace WordWrapper
{
    public class Interactor
    {
        private readonly ParagraphSplitter _paragraphSplitter;
        private readonly WordWrapper _wordWrapper;

        public Interactor()
        {
            _paragraphSplitter = new ParagraphSplitter();
            _wordWrapper = new WordWrapper();
        }
        public string WrapText(string text, int width)
        {
            IList<string> paragraphs = _paragraphSplitter.SplitTextIntoParagraphs(text);

            IList<string> wrappedParagraphs = _wordWrapper.WrapParagraphs(paragraphs, width);

            return _paragraphSplitter.JoinParagraphs(wrappedParagraphs);
        }
    }
}
