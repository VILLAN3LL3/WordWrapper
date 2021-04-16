using System.Collections.Generic;

namespace WordWrapper
{
    public class ParagraphSplitter
    {
        public IList<string> SplitTextIntoParagraphs(string text) => text.Split(Constants.PARAGRAPH_SEPARATOR);

        public string JoinParagraphs(IList<string> paragraphs) => string.Join(Constants.PARAGRAPH_SEPARATOR, paragraphs);
    }
}
