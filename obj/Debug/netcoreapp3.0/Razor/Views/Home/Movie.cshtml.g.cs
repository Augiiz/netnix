#pragma checksum "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e02b62ca345ffdc5d1bfa1cbba9232d0edfac0f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Movie), @"mvc.1.0.view", @"/Views/Home/Movie.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\_ViewImports.cshtml"
using netnix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\_ViewImports.cshtml"
using netnix.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02b62ca345ffdc5d1bfa1cbba9232d0edfac0f0", @"/Views/Home/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ce1fde4e922ddcc3a68254042a2c4b6ba882d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-left\">\r\n\r\n    <div>\r\n        <h4>");
#nullable restore
#line 8 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <div><b>Release date: </b>");
#nullable restore
#line 9 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml"
                             Write(Model.releaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div><b>Director: </b>");
#nullable restore
#line 10 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml"
                         Write(Model.director.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div><b>Description: </b><br />");
#nullable restore
#line 11 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml"
                                  Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div><img");
            BeginWriteAttribute("src", " src=\"", 291, "\"", 309, 1);
#nullable restore
#line 12 "C:\Users\Augiz\Downloads\json2\call-json-api-master\Views\Home\Movie.cshtml"
WriteAttributeValue("", 297, Model.image, 297, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\r\n        <hr />\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
