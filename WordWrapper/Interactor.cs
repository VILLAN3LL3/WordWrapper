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
            IList<IList<string>> splittedParagraphs = _paragraphSplitter.SplitParagraphsIntoWords(paragraphs);
            IList<IList<string>> wrappedParagraphs = _wordWrapper.WrapParagraphs(splittedParagraphs, width);
            return _paragraphSplitter.JoinParagraphs(wrappedParagraphs);
        }
    }
}
