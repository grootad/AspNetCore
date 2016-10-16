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

    public TdTagHelper(IHtmlGenerator generator)
    {
      Generator = generator;
    }

    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext Viewcontext { get; set; }

    protected IHtmlGenerator Generator { get; }

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

      //var tagBuilder = Generator.Gena

      base.Process(context, output);
    }
  }
}
