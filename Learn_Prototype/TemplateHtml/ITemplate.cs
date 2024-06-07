using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Prototype.TemplateHtml
{
    public interface ITemplate
    {
        ITemplate Clone();
        void FillContent(string content);
        string GetHtml();
    }
}
