#pragma checksum "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82796a837b08d965cfd4a8fc1391f705d19e7e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using Pesten;

#line default
#line hidden
#line 2 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using Pesten.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82796a837b08d965cfd4a8fc1391f705d19e7e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe2d60c9d0a71d5fbb19d94626b88ba5dc6fd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dealer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 258, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6 table-bordered"" style=""padding-top: 5px; padding-bottom: 5px"">
        <div class=""row"" style=""padding-bottom: 5px;"">
            <div >
                <div class=""col-lg-2""><button type=""button"" name=""Reset""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 318, "\"", 372, 3);
            WriteAttributeValue("", 328, "location.href=\'", 328, 15, true);
#line 10 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 343, Url.Action("Reset", "Home"), 343, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 371, "\'", 371, 1, true);
            EndWriteAttribute();
            BeginContext(373, 79, true);
            WriteLiteral(">Reset</button></div>\r\n                <div class=\"col-lg-3\"><b>Deck size:</b> ");
            EndContext();
            BeginContext(453, 30, false);
#line 11 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                   Write(Model.GetDeckSize().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(483, 68, true);
            WriteLiteral("</div>\r\n                <div class=\"col-lg-7\"><b>Deck top card:</b> ");
            EndContext();
            BeginContext(552, 29, false);
#line 12 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                       Write(Model.GetDeckTop().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(581, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(584, 34, false);
#line 12 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                       Write(Model.GetDeckTop().ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(618, 163, true);
            WriteLiteral(")</div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div >\r\n                <div class=\"col-lg-2\"><button type=\"button\" name=\"Next\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 781, "\"", 834, 3);
            WriteAttributeValue("", 791, "location.href=\'", 791, 15, true);
#line 17 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 806, Url.Action("Next", "Home"), 806, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 833, "\'", 833, 1, true);
            EndWriteAttribute();
            BeginContext(835, 81, true);
            WriteLiteral(">Next</button></div>\r\n                <div class=\"col-lg-3\"><b>Discard size:</b> ");
            EndContext();
            BeginContext(917, 33, false);
#line 18 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                      Write(Model.GetDiscardSize().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(950, 71, true);
            WriteLiteral("</div>\r\n                <div class=\"col-lg-7\"><b>Discard top card:</b> ");
            EndContext();
            BeginContext(1022, 29, false);
#line 19 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                          Write(Model.GetTopCard().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1051, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1054, 34, false);
#line 19 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                          Write(Model.GetTopCard().ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(1088, 218, true);
            WriteLiteral(")</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-5 col-lg-offset-1 table-bordered\" style=\"padding-top: 5px; padding-bottom: 5px; height: 20em;\">\r\n        <b>Log:</b><br />\r\n        <ul>\r\n");
            EndContext();
#line 26 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
             foreach (var s in Model.GetLog())
            {

#line default
#line hidden
            BeginContext(1369, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1390, 1, false);
#line 28 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
               Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 29 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1413, 129, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\"><br /></div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1542, "\"", 1619, 3);
            WriteAttributeValue("", 1550, "row", 1550, 3, true);
            WriteAttributeValue(" ", 1553, "table-bordered", 1554, 15, true);
#line 38 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1568, Model.GetCurrentTurn() == 0 ? "bg-primary" : "", 1569, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1620, 25, true);
            WriteLiteral(" style=\"padding: 5px\"><b>");
            EndContext();
            BeginContext(1646, 31, false);
#line 38 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                                              Write(Model.GetPlayers()[0].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(1677, 79, true);
            WriteLiteral("\'s hand</b></div>\r\n        <div class=\"row table-bordered\">\r\n            <ul>\r\n");
            EndContext();
#line 41 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                 foreach (var card in Model.GetPlayers()[0].GetHand())
                {

#line default
#line hidden
            BeginContext(1847, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1872, 15, false);
#line 43 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(card.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1887, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1890, 20, false);
#line 43 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                     Write(card.ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(1910, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 44 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1937, 121, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2\"></div>\r\n    <div class=\"col-lg-5\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2058, "\"", 2135, 3);
            WriteAttributeValue("", 2066, "row", 2066, 3, true);
            WriteAttributeValue(" ", 2069, "table-bordered", 2070, 15, true);
#line 50 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2084, Model.GetCurrentTurn() == 1 ? "bg-primary" : "", 2085, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 25, true);
            WriteLiteral(" style=\"padding: 5px\"><b>");
            EndContext();
            BeginContext(2162, 31, false);
#line 50 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                                              Write(Model.GetPlayers()[1].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(2193, 79, true);
            WriteLiteral("\'s hand</b></div>\r\n        <div class=\"row table-bordered\">\r\n            <ul>\r\n");
            EndContext();
#line 53 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                 foreach (var card in Model.GetPlayers()[1].GetHand())
                {

#line default
#line hidden
            BeginContext(2363, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(2388, 15, false);
#line 55 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(card.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2403, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2406, 20, false);
#line 55 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                     Write(card.ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(2426, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 56 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2453, 149, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\"><br /></div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2602, "\"", 2679, 3);
            WriteAttributeValue("", 2610, "row", 2610, 3, true);
            WriteAttributeValue(" ", 2613, "table-bordered", 2614, 15, true);
#line 66 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2628, Model.GetCurrentTurn() == 2 ? "bg-primary" : "", 2629, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2680, 25, true);
            WriteLiteral(" style=\"padding: 5px\"><b>");
            EndContext();
            BeginContext(2706, 31, false);
#line 66 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                                              Write(Model.GetPlayers()[2].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(2737, 79, true);
            WriteLiteral("\'s hand</b></div>\r\n        <div class=\"row table-bordered\">\r\n            <ul>\r\n");
            EndContext();
#line 69 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                 foreach (var card in Model.GetPlayers()[2].GetHand())
                {

#line default
#line hidden
            BeginContext(2907, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(2932, 15, false);
#line 71 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(card.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2947, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2950, 20, false);
#line 71 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                     Write(card.ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(2970, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 72 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2997, 121, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2\"></div>\r\n    <div class=\"col-lg-5\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3118, "\"", 3195, 3);
            WriteAttributeValue("", 3126, "row", 3126, 3, true);
            WriteAttributeValue(" ", 3129, "table-bordered", 3130, 15, true);
#line 78 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3144, Model.GetCurrentTurn() == 3 ? "bg-primary" : "", 3145, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3196, 25, true);
            WriteLiteral(" style=\"padding: 5px\"><b>");
            EndContext();
            BeginContext(3222, 31, false);
#line 78 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                                              Write(Model.GetPlayers()[3].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(3253, 79, true);
            WriteLiteral("\'s hand</b></div>\r\n        <div class=\"row table-bordered\">\r\n            <ul>\r\n");
            EndContext();
#line 81 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                 foreach (var card in Model.GetPlayers()[3].GetHand())
                {

#line default
#line hidden
            BeginContext(3423, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(3448, 15, false);
#line 83 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(card.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3463, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(3466, 20, false);
#line 83 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                     Write(card.ToShortString());

#line default
#line hidden
            EndContext();
            BeginContext(3486, 8, true);
            WriteLiteral(")</li>\r\n");
            EndContext();
#line 84 "C:\Users\Lars\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3513, 55, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dealer> Html { get; private set; }
    }
}
#pragma warning restore 1591
