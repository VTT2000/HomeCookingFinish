#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Shared\Components\ViewLoaiThucPham\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08c7b3b1a6a4a73fbd3f6e4df688894e86588da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ViewLoaiThucPham_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ViewLoaiThucPham/Default.cshtml")]
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
#line 1 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\_ViewImports.cshtml"
using HomeCooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\_ViewImports.cshtml"
using HomeCooking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08c7b3b1a6a4a73fbd3f6e4df688894e86588da", @"/Views/Shared/Components/ViewLoaiThucPham/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ViewLoaiThucPham_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.LoaiThucPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<li class=""nav-bar__item dropdown"">
    <a href=""#"" class=""nav-bar__link link"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
        LOẠI SẢN PHẨM
        <svg focusable=""false"" class=""icon icon--arrow-bottom"" viewBox=""0 0 12 8"" role=""presentation"">
            <path stroke=""currentColor"" stroke-width=""2"" d=""M10 2L6 6 2 2"" fill=""none"" stroke-linecap=""square""></path>
        </svg>
    </a>
    <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
");
#nullable restore
#line 14 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Shared\Components\ViewLoaiThucPham\Default.cshtml"
         foreach (LoaiThucPham item in Model.ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 718, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Shared\Components\ViewLoaiThucPham\Default.cshtml"
WriteAttributeValue("", 654, Url.Action("FoodTheoLoai","ListFood", new { id = item.IdLoai }), 654, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Shared\Components\ViewLoaiThucPham\Default.cshtml"
                                                                                                Write(item.TenLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Shared\Components\ViewLoaiThucPham\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.LoaiThucPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
