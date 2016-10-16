using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyTagHelpers
{
  public class MyHtmlGenerator : DefaultHtmlGenerator, IMyHtmlGenerator
  {
    public MyHtmlGenerator(IAntiforgery antiforgery, IOptions<MvcViewOptions> optionsAccessor, IModelMetadataProvider metadataProvider, IUrlHelperFactory urlHelperFactory, HtmlEncoder htmlEncoder, ClientValidatorCache clientValidatorCache) : base(antiforgery, optionsAccessor, metadataProvider, urlHelperFactory, htmlEncoder, clientValidatorCache)
    {
    }

    public TagBuilder GenerateTd(ViewContext viewContext, ModelExplorer modelExplorer,  object value, string format, object htmlAttributes)
    {
      if (viewContext == null)
      {
        throw new ArgumentNullException(nameof(viewContext));
      }

      if (modelExplorer == null)
      {
        throw new ArgumentNullException(nameof(modelExplorer));
      }

      var tagBuilder = new TagBuilder("Td");


      return tagBuilder;
    }
  }
}
