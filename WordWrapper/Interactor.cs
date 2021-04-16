namespace WordWrapper
{
    public class Interactor
    {
        private readonly ParagraphSplitter _paragraphSplitter;

        public Interactor()
        {
            _paragraphSplitter = new ParagraphSplitter();
        }
        public string WrapText(string text, int width)
        {
            var paragraphs = _paragraphSplitter.SplitTextIntoParagraphs(text);
            return text;
        }
    }
}
