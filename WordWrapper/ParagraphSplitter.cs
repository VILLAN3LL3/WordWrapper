using System.Collections.Generic;

namespace WordWrapper
{
    public class ParagraphSplitter
    {
        public ICollection<string> SplitTextIntoParagraphs(string text)
        {
            return text.Split("\r\n\r\n");
        }
    }
}
