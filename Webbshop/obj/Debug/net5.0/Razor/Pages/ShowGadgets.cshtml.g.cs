#pragma checksum "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac26330a44c6aaf0d59868a2c48344e31f089e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ShowGadgets), @"mvc.1.0.razor-page", @"/Pages/ShowGadgets.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac26330a44c6aaf0d59868a2c48344e31f089e9d", @"/Pages/ShowGadgets.cshtml")]
    public class Pages_ShowGadgets : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
    <a class=""navbar-brand"" asp-page=""/ShowGames"">Games</a>
    <a class=""navbar-brand"" asp-page=""/ShowConsoles"">Consoles</a>
    <a class=""navbar-brand"" asp-page=""/ShowGadgets"">Gadgets</a>   
    <a class=""navbar-brand"" asp-page=""/Cart"">Cart</a>
    <a class=""navbar-brand navbar-nav ml-auto"" asp-page=""/AdminAddGame"">Admin</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
</nav>

<h3 class=""textcenter"">Different Gadgets for Consoles</h3>

<div class=""dropdown"">
    <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        Sortera Efter:
    </button>
    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuB");
            WriteLiteral(@"utton"">
        <a class=""dropdown-item"" href=""ShowGadgets?Sort=Price"">Price</a>
        <a class=""dropdown-item"" href=""ShowGadgets?Sort=A2Z"">Bokstavsordning A - Z</a>
        <a class=""dropdown-item"" href=""ShowGadgets?Sort=Z2A"">Bokstavsordning Z - A</a>
    </div>
</div>



<form method=""post"">
");
#nullable restore
#line 33 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
       int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
     foreach (var gadget in Model.gadgets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mx-auto row\" style=\"width: 18rem;\">\r\n            <img class=\"card-img-top img-thumbnail \"");
            BeginWriteAttribute("src", " src=\"", 1570, "\"", 1592, 1);
#nullable restore
#line 37 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
WriteAttributeValue("", 1576, gadget.ImageURL, 1576, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title \">");
#nullable restore
#line 39 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                                   Write(gadget.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>\r\n                    <a class=\"btn btn-light\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 1801, "\"", 1827, 2);
            WriteAttributeValue("", 1808, "#collapseExample_", 1808, 17, true);
#nullable restore
#line 41 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
WriteAttributeValue("", 1825, i, 1825, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                       role=\"button\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1887, "\"", 1921, 2);
            WriteAttributeValue("", 1903, "collapseExample_", 1903, 16, true);
#nullable restore
#line 42 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
WriteAttributeValue("", 1919, i, 1919, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        Description\r\n                    </a>\r\n                </p>\r\n                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 2047, "\"", 2070, 2);
            WriteAttributeValue("", 2052, "collapseExample_", 2052, 16, true);
#nullable restore
#line 46 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
WriteAttributeValue("", 2068, i, 2068, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card card-body\">\r\n                        <p>");
#nullable restore
#line 48 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                      Write(gadget.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Platforms: ");
#nullable restore
#line 49 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                                 Write(gadget.GadgetPlatform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <h6> Quantity: ");
#nullable restore
#line 52 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                          Write(gadget.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                <h6> Article Number: ");
#nullable restore
#line 53 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                                Write(gadget.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h5> Pris: ");
#nullable restore
#line 54 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
                      Write(gadget.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kr</h5>\r\n\r\n                <button");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2475, "\"", 2500, 1);
#nullable restore
#line 56 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
WriteAttributeValue("", 2490, gadget.Id, 2490, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\">Add to Cart</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\gumsa\OneDrive\Skrivbord\BigProject\Webbshop\Webbshop\Pages\ShowGadgets.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</form>\r\n \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webbshop.Pages.ShowGadgetsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshop.Pages.ShowGadgetsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Webbshop.Pages.ShowGadgetsModel>)PageContext?.ViewData;
        public Webbshop.Pages.ShowGadgetsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
