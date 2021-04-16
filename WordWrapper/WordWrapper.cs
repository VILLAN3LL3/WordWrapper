using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrapper
{
    public class WordWrapper
    {
        public IList<string> WrapParagraphs(IList<string> paragraphs, int width)
        {
            var wrappedParagraphs = new List<string>();

            foreach (string paragraph in paragraphs)
            {
                IList<string> splittedParagraph = SplitParagraphIntoWords(paragraph);
                var wrappedParagraph = WrapParagraph(splittedParagraph, width);
                wrappedParagraphs.Add(JoinLines(wrappedParagraph));
            }
            return wrappedParagraphs;
        }

        public string JoinLines(IList<string> lines) => string.Join(Constants.LINE_SEPARATOR, lines);

        public IList<string> SplitParagraphIntoWords(string text) => text.Split(
            new string[] { Constants.LINE_SEPARATOR, Constants.WORD_SEPARATOR },
            StringSplitOptions.RemoveEmptyEntries);

        public IList<string> WrapParagraph(IList<string> paragraph, int width)
        {
            var lines = new List<string>();

            var line = new StringBuilder();
            for (int i = 0; i < paragraph.Count; i++)
            {
                int lengthOfNextWord = paragraph[i].Length;
                if (line.Length + lengthOfNextWord > width - 1 && line.Length > 0)
                {
                    lines.Add(line.ToString());
                    line.Clear();
                }
                if (line.Length > 0)
                {
                    line.Append(' ');
                }
                line.Append(paragraph[i]);
            }

            lines.Add(line.ToString());
            return lines;
        }
    }
}
