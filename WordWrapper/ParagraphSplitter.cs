using System;
using System.Collections.Generic;

namespace WordWrapper
{
    public class ParagraphSplitter
    {
        private const string PARAGRAPH_SEPARATOR = "\r\n\r\n";
        private const string LINE_SEPARATOR = "\r\n";
        private const string WORD_SEPARATOR = " ";


        public IList<IList<string>> SplitParagraphsIntoWords(IList<string> paragraphs)
        {
            var splittedParagraphs = new List<IList<string>>();
            foreach (string paragraph in paragraphs)
            {
                splittedParagraphs.Add(SplitParagraphIntoWords(paragraph));
            }
            return splittedParagraphs;
        }

        public IList<string> SplitTextIntoParagraphs(string text) => text.Split(PARAGRAPH_SEPARATOR);

        public IList<string> SplitParagraphIntoWords(string text) => text.Split(new string[] { LINE_SEPARATOR, WORD_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

        public string JoinParagraphs(IList<IList<string>> paragraphs)
        {
            var joinedParagraphs = new List<string>();

            foreach (var lines in paragraphs)
            {
                joinedParagraphs.Add(string.Join(LINE_SEPARATOR, lines));
            }

            return string.Join(PARAGRAPH_SEPARATOR, joinedParagraphs);
        }
    }
}
