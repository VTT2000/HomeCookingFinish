#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40dfeca351a04482b759c2c483149b0011a67e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListFood_FoodDuocKM), @"mvc.1.0.view", @"/Views/ListFood/FoodDuocKM.cshtml")]
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
#nullable restore
#line 143 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40dfeca351a04482b759c2c483149b0011a67e02", @"/Views/ListFood/FoodDuocKM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_ListFood_FoodDuocKM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ThucPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/GioHang/ThemGioHang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("product_form_id_6806124495026_1624509122e13fa354"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-item__action-list button-stack"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
  
    ViewData["Title"] = "FoodDuocKM";
    Layout = "~/Views/Shared/_Layout.cshtml";


    List<NhaSanXuat> listnsx = ViewBag.NhaSanXuats as List<NhaSanXuat>;
    List<LoaiThucPham> listltp = ViewBag.LoaiThucPhams as List<LoaiThucPham>;

    List<LoHang> list0 = ViewBag.LoHangs as List<LoHang>;
    List<KhuyenMai> list1 = ViewBag.KhuyenMais as List<KhuyenMai>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"" role=""main"">
    <div id=""shopify-section-collection-template"" class=""shopify-section"">
        <section data-section-id=""collection-template"" data-section-type=""collection"">
            <div class=""container container--flush"">
                <div class=""page__sub-header"">
                    <nav aria-label=""Điều hướng"" class=""breadcrumb"">
                      <ol class=""breadcrumb__list"" role=""list"">
                        <li class=""breadcrumb__item"">
                          <a class=""breadcrumb__link link"" href=""/"">Trang chủ</a><svg focusable=""false"" class=""icon icon--arrow-right"" viewBox=""0 0 8 12"" role=""presentation"">
                            <path stroke=""currentColor"" stroke-width=""2"" d=""M2 2l4 4-4 4"" fill=""none"" stroke-linecap=""square""></path>
                          </svg>
                        </li>
                        <li class=""breadcrumb__item"">
                          <a class=""breadcrumb__link link""");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1444, 1);
#nullable restore
#line 28 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 1413, Url.Action("Index","ListFood"), 1413, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Thực phẩm</a><svg focusable=""false"" class=""icon icon--arrow-right"" viewBox=""0 0 8 12"" role=""presentation"">
                            <path stroke=""currentColor"" stroke-width=""2"" d=""M2 2l4 4-4 4"" fill=""none"" stroke-linecap=""square""></path>
                          </svg>
                        </li>
                        <li class=""breadcrumb__item""><span class=""breadcrumb__link"" aria-current=""page"">Khuyến mãi</span></li>
                      </ol>
                    </nav>
                </div>
                <div class=""layout"">
                    <div class=""layout__section layout__section--secondary hidden-pocket"">
                        <div class=""card"">
                            <div class=""card__section card__section--tight"">
                                <p class=""card__title--small heading"">Nhà cung cấp</p>
                                <div class=""collection__filter-group"">
                                    <ul class=""collection__filter-checkbox-list"" role=""list"">");
            WriteLiteral("\n");
#nullable restore
#line 43 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                         foreach (NhaSanXuat i in listnsx)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"collection__filter-checkbox\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2725, "\"", 2791, 1);
#nullable restore
#line 46 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 2732, Url.Action("FoodTheoNCC","ListFood", new { id = i.IdNsx }), 2732, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2792, "\"", 2800, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                                          Write(i.NameNsx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 48 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""card__section card__section--tight"">
                                <p class=""card__title--small heading"">Loại</p>
                                <div class=""collection__filter-group"">
                                    <ul class=""collection__filter-checkbox-list"" role=""list"">
");
#nullable restore
#line 56 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                         foreach (LoaiThucPham j in listltp)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"collection__filter-checkbox\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3613, "\"", 3681, 1);
#nullable restore
#line 59 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 3620, Url.Action("FoodTheoLoai","ListFood", new { id = j.IdLoai }), 3620, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3682, "\"", 3690, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                                            Write(j.TenLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                            </div>

                            <div class=""card__section card__section--tight"">
                                <p class=""card__title--small heading"">Khuyến mãi</p>
                                <div class=""collection__filter-group"">
                                    <ul class=""collection__filter-checkbox-list"" role=""list"">

                                        <li class=""collection__filter-checkbox"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4386, "\"", 4429, 1);
#nullable restore
#line 73 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 4393, Url.Action("FoodDuocKM","ListFood"), 4393, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4430, "\"", 4438, 0);
            EndWriteAttribute();
            WriteLiteral(@">Các sản phẩm khuyến mãi</a>
                                        </li>


                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""layout__section"">
                        <div class=""collection"">
                            <div class=""card "">
                                <header class=""card__header card__header--tight"">
                                    <div class=""collection__header "">
                                        <div class=""collection__header-inner"">
                                            <div class=""collection__description "">
                                                <div class=""rte"" id=""bigpen"">
                                                    Khuyến mãi
                                                </div>
                                            </div>
                                        </d");
            WriteLiteral(@"iv>
                                    </div>
                                </header>
                                <div class=""collection__dynamic-part"">
                                    <div class=""collection__toolbar collection__toolbar--bordered"">
                                        <div class=""collection__toolbar-item collection__toolbar-item--sort"">
                                            <div class=""value-picker-wrapper"">
                                                <!-- nút ấn đễ sắp xếp theo giá-->
                                                <button");
            BeginWriteAttribute("href1", " href1=\"", 6058, "\"", 6122, 1);
#nullable restore
#line 102 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 6066, Url.Action("FoodDuocKM","ListFood", new { sapxep = 1 }), 6066, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""location.href = this.getAttribute('href1');""  class=""value-picker-button"" type=""button"">
                                                    <span>Sắp xếp</span>
                                                </button>
                                            </div>

                                        </div>
                                    </div>

                                    <div class=""product-list product-list--collection product-list--with-sidebar"">
");
#nullable restore
#line 111 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                         foreach (ThucPham item in Model.ToList())
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"product-item product-item--vertical  1/3--tablet-and-up 1/4--desk\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6922, "\"", 6981, 1);
#nullable restore
#line 114 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 6929, Url.Action("Index","Food",new { id = item.IdFood }), 6929, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""product-item__image-wrapper product-item__image-wrapper--with-secondary"">
                                                    <div class=""aspect-ratio "" style=""height:230px; width:230px; padding-bottom: 100.0%"">
                                                        <img class=""product-item__primary-image image--fade-in lazyautosizes lazyloaded""");
            BeginWriteAttribute("src", " src=\"", 7340, "\"", 7363, 1);
#nullable restore
#line 116 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 7346, item.LinkHinhAnh, 7346, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

                                                    </div>
                                                </a>
                                                <div class=""product-item__info"">
                                                    <div class=""product-item__info-inner"">
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7717, "\"", 7776, 1);
#nullable restore
#line 122 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 7724, Url.Action("Index","Food",new { id = item.IdFood }), 7724, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item__title text--strong link\">");
#nullable restore
#line 122 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                                                                                Write(item.NameFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        <div class=\"product-item__price-list price-list\">\r\n");
#nullable restore
#line 124 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                             if (list1.FirstOrDefault(p => p.IdKhuyenMai == item.IdKhuyenMai) != null)
                                                            {
                                                                var sale = item.Price * (100 - list1.FirstOrDefault(p => p.IdKhuyenMai == item.IdKhuyenMai).PhanTramKhuyenMai) / 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"price price--highlight\">\r\n                                                                    <span class=\"visually-hidden\">Giá sale</span>");
#nullable restore
#line 128 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                            Write(sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₫
                                                                </span>
                                                                <span class=""price price--compare"">
                                                                    <span class=""visually-hidden"">Giá gốc</span>");
#nullable restore
#line 131 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫\r\n                                                                </span> ");
#nullable restore
#line 132 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                        }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"price price--highlight\">\r\n                                                                    <span class=\"visually-hidden\">Giá gốc</span>");
#nullable restore
#line 136 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₫\r\n                                                                </span>");
#nullable restore
#line 137 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </div>\r\n\r\n");
#nullable restore
#line 141 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                         if (list0.FindAll(p => p.IdFood == item.IdFood).FirstOrDefault(p => p.SoLuong > 0) != null)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40dfeca351a04482b759c2c483149b0011a67e0225008", async() => {
                WriteLiteral("\r\n                                                                <input type=\"hidden\" name=\"IdFood\"");
                BeginWriteAttribute("value", " value=\"", 10111, "\"", 10131, 1);
#nullable restore
#line 145 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 10119, item.IdFood, 10119, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                <input type=\"hidden\" name=\"strURL\"");
                BeginWriteAttribute("value", " value=\"", 10233, "\"", 10273, 1);
#nullable restore
#line 146 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
WriteAttributeValue("", 10241, Context.Request.GetDisplayUrl(), 10241, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                                <button type=""submit"" class=""product-item__action-button button button--small button--primary"" data-action=""add-to-cart"">Thêm vào giỏ</button>
                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 148 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                    }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40dfeca351a04482b759c2c483149b0011a67e0229091", async() => {
                WriteLiteral("\r\n                                                                <button class=\"product-item__action-button button button--small button--disabled\"");
                BeginWriteAttribute("disabled", " disabled=\"", 11003, "\"", 11014, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"cursor: not-allowed;\">Hết hàng</button>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 153 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </div>\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 158 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\ListFood\FoodDuocKM.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>


</main>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ThucPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
