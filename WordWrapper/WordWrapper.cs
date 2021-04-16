using System.Collections.Generic;
using System.Text;

namespace WordWrapper
{
    public class WordWrapper
    {
        public IList<IList<string>> WrapParagraphs(IList<IList<string>> paragraphs, int width)
        {
            var wrappedParagraphs = new List<IList<string>>();

            foreach (IList<string> paragraph in paragraphs)
            {
                wrappedParagraphs.Add(WrapParagraph(paragraph, width));
            }
            return wrappedParagraphs;
        }

        public IList<string> WrapParagraph(IList<string> paragraph, int width)
        {
            var lines = new List<string>();

            var line = new StringBuilder();
            for (int i = 0; i < paragraph.Count; i++)
            {
                int lengthOfNextWord = paragraph[i].Length;
                if (line.Length + lengthOfNextWord > width - 1)
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
