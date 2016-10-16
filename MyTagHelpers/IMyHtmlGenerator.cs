using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTagHelpers
{
  public interface IMyHtmlGenerator : IHtmlGenerator
  {
    TagBuilder GenerateTd(
       ViewContext viewContext,
            ModelExplorer modelExplorer,
            object value,
            string format,
            object htmlAttributes);
 }

}
