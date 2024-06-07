namespace Learn_Prototype.TemplateHtml
{
    public class TemplateMain 
    {
        public string Run()
        {
            var defaultTemplate = new DefaultTemplate();

            var customTemplate = (DefaultTemplate)defaultTemplate.Clone();

            var customTemplateLtr = (DefaultTemplate)defaultTemplate.Clone();


            customTemplate.FillContent("Custom Content");

            customTemplateLtr.FillContent("Custom Content LTR For English Language");


            return customTemplateLtr.GetHtml();
        }
    }
}
