#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec8b88cf4877771f552cc17a4e007a1ac1fc22b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CongThucNauAn_Index), @"mvc.1.0.view", @"/Views/CongThucNauAn/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec8b88cf4877771f552cc17a4e007a1ac1fc22b", @"/Views/CongThucNauAn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_CongThucNauAn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.CongThucNauAn>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
  
    ViewBag.Title = "M??n ??n";
    Layout = "_Layout";
    List<CongThucNauAn> list0 = ViewBag.CongThucNauAns as List<CongThucNauAn>;
    List<ChiTietChuDeCongThuc> list1 = ViewBag.ChiTietChuDeCongThucs as List<ChiTietChuDeCongThuc>;
    List<ChuDeCongThuc> list2 = ViewBag.ChuDeCongThucs as List<ChuDeCongThuc>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <main id=""main"" role=""main"">
    <div id=""shopify-section-collection-template"" class=""shopify-section"">
      <section data-section-id=""collection-template"" data-section-type=""collection"">
        <div class=""container container--flush"">
          <div class=""page__sub-header"">
            <nav aria-label=""??i???u h?????ng"" class=""breadcrumb"">
              <ol class=""breadcrumb__list"" role=""list"">
                <li class=""breadcrumb__item"">
                  <a class=""breadcrumb__link link"" href=""/"">Trang ch???</a><svg focusable=""false"" class=""icon icon--arrow-right"" viewBox=""0 0 8 12"" role=""presentation"">
                    <path stroke=""currentColor"" stroke-width=""2"" d=""M2 2l4 4-4 4"" fill=""none"" stroke-linecap=""square""></path>
                  </svg>
                </li>
                <li class=""breadcrumb__item""><span class=""breadcrumb__link"" aria-current=""page"">C??ng th???c</span></li>
              </ol>
            </nav>
          </div>
          <div class=""layout"">
            <div");
            WriteLiteral(@" class=""layout__section layout__section--secondary hidden-pocket"">
              <div class=""card"">
                <div class=""card__section card__section--tight"">
                  <p class=""card__title--small heading"">Ch??? ????? c??ng th???c</p>
                  <div class=""collection__filter-group"">
                    <ul class=""collection__filter-checkbox-list"" role=""list"">
");
#nullable restore
#line 33 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                       foreach (var i in list2)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"collection__filter-checkbox\">\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 1953, "\"", 2021, 1);
#nullable restore
#line 36 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
WriteAttributeValue("", 1960, Url.Action("Index", "CongThucNauAn", new { id = i.IdChuDe }), 1960, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2022, "\"", 2043, 1);
#nullable restore
#line 36 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
WriteAttributeValue("  ", 2030, i.TenChuDe, 2032, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 36 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                                                                                                                    Write(i.TenChuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 38 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                  </div>
                </div>
              </div>
            </div>

            <div class=""layout__section"">
              <div class=""collection"">
                <div class=""card "">

                  <div class=""collection__dynamic-part"">
                    <header class=""card__header card__header--tight"">
                      <div class=""collection__header "">
                        <div class=""collection__header-inner"">
                          <div class=""collection__description "">
                            <div class=""rte"" id=""bigpen"">
                              T???t c??? c??ng th???c
                            </div>
                          </div>
                        </div>
                      </div>
                    </header>
                    <div class=""collection__toolbar collection__toolbar--bordered"">
                      <div class=""collection__toolbar-item collection__toolbar-item--sort"">
                  ");
            WriteLiteral(@"      <div class=""value-picker-wrapper"">
                          <!-- n??t ???n ????? s???p x???p theo ng??y ????ng-->
                          <button class=""value-picker-button"" type=""button"">
                            <span>S???p x???p</span>
                          </button>
                        </div>

                      </div>
                    </div>

                    <div class=""product-list product-list--collection product-list--with-sidebar"">

");
#nullable restore
#line 75 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                       foreach (var item in Model.ToList())
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-item product-item--vertical  1/3--tablet-and-up 1/4--desk\">\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 3833, "\"", 3914, 1);
#nullable restore
#line 78 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
WriteAttributeValue("", 3840, Url.Action("Index", "ChiTietCongThucNauAn", new { id = item.IdCongThuc }), 3840, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""product-item__image-wrapper product-item__image-wrapper--with-secondary"">
                            <div class=""aspect-ratio "" style=""height:230px; width:230px; padding-bottom: 100.0%"">
                              <img class=""product-item__primary-image image--fade-in lazyautosizes lazyloaded""");
            BeginWriteAttribute("src", " src=\"", 4223, "\"", 4246, 1);
#nullable restore
#line 80 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
WriteAttributeValue("", 4229, item.LinkHinhAnh, 4229, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                            </div>\r\n                          </a>\r\n                          <div class=\"product-item__info\">\r\n                            <div class=\"product-item__info-inner\">\r\n                              <a");
            BeginWriteAttribute("href", " href=\"", 4482, "\"", 4563, 1);
#nullable restore
#line 86 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
WriteAttributeValue("", 4489, Url.Action("Index", "ChiTietCongThucNauAn", new { id = item.IdCongThuc }), 4489, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item__title text--strong link\">");
#nullable restore
#line 86 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                                                                                                                                                            Write(item.TenCongThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                              <div class=\"product-item__price-list price-list\">\r\n                                <span class=\"price\" style=\"font-size:12px\">\r\n                                  <span>Ng?????i ????ng: ");
#nullable restore
#line 89 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                                               Write(item.TacGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><!--ch??? n??y d??? ng ????ng nh?? admin hay user-->\r\n                                </span>\r\n                              </div>\r\n                            </div>\r\n                          </div>\r\n\r\n                        </div>");
#nullable restore
#line 95 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\CongThucNauAn\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n</section>\n   </div>\r\n\r\n\r\n  </main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.CongThucNauAn>> Html { get; private set; }
    }
}
#pragma warning restore 1591
