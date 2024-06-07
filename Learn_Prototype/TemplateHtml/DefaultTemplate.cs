namespace Learn_Prototype.TemplateHtml
{
    public class DefaultTemplate : ITemplate
    {
        private string _content;

        public ITemplate Clone()
        {
            return new DefaultTemplate();
        }

        public void FillContent(string content)
        {
            _content = content;
        }

        public string GetHtml()
        {
            // Generate HTML based on the content
            return $"<div>{_content}</div>";
        }
    }
}
