using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyTagHelpers
{

  [HtmlTargetElement("td",Attributes = ForAttributeName)]
  public class TdTagHelper: TagHelper
  {
    private const string ForAttributeName = "asp-for";

    public TdTagHelper(IMyHtmlGenerator generator)
    {
      Generator = generator;
    }

    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext ViewContext { get; set; }

    protected IMyHtmlGenerator Generator { get; }

    [HtmlAttributeName(ForAttributeName)]
    public ModelExpression For { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      if (context == null)
      {
        throw new ArgumentNullException(nameof(context));
      }

      if (output == null)
      {
        throw new ArgumentNullException(nameof(output));
      }

      var tagBuilder = Generator.GenerateTd(ViewContext, For.ModelExplorer, For.Model, For.Metadata.DisplayFormatString, htmlAttributes: null );

      base.Process(context, output);
    }
  }
}
