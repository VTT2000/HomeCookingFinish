#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d41e1b26002034a5eeee48d0ef95c73fec0126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
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
#line 106 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d41e1b26002034a5eeee48d0ef95c73fec0126", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.GioHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-recap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-item-count", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

    KhachHang a = ViewBag.KhachHang as KhachHang;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" role=""main"">
    <div id=""shopify-section-cart-template"" class=""shopify-section"">
        <section data-section-id=""cart-template"" data-section-type=""cart"" data-section-settings="""">
            <div class=""container"">
                <header class=""page__header page__header--stack"">
                    <h1 class=""page__title heading h1"">Giỏ hàng</h1>
                </header>
            </div>
            <div class=""cart-wrapper"" style=""min-height: 358px;"">
                <div class=""cart-wrapper__inner"">
                    <div class=""cart-wrapper__inner-inner"">
                        <div class=""container container--flush"">
                            <div class=""card"">
                                <div class=""table-wrapper"">
                                    <table class=""line-item-table table table--loose"">
                                        <thead class=""hidden-phone"">
                                            <tr>
                                                <th>Sản p");
            WriteLiteral(@"hẩm</th>
                                                <th class=""table__cell--center"">Số lượng</th>
                                                <th class=""table__cell--center"">Tổng</th>
                                                 <th class=""table__cell--right"">Tác vụ</th>
                                              </tr>
                                        </thead>
                                        <!-- đồ trong giỏ hàng-->
                                        <tbody>
");
#nullable restore
#line 33 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                          <tr class=""line-item line-item--stack"">
                                            <td class=""line-item__product-info"">
                                              <div class=""line-item__product-info-wrapper"">
                                                <div class=""line-item__image-wrapper"">
                                                  <div class=""aspect-ratio"" style=""padding-bottom: 100.0%"">
                                                    <img");
            BeginWriteAttribute("src", " src=\"", 2334, "\"", 2358, 1);
#nullable restore
#line 40 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2340, item.zLinkHinhAnh, 2340, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2359, "\"", 2365, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                                  </div>\n                                                </div>\n                                                <div class=\"line-item__meta\">\n                                                  <a");
            BeginWriteAttribute("href", " href=\"", 2610, "\"", 2671, 1);
#nullable restore
#line 44 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2617, Url.Action("Index","Food", new { id = item.zIdFood }), 2617, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"line-item__title link text--strong\">");
#nullable restore
#line 44 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                                                                                                                                         Write(item.zNameFood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><div class=\"line-item__price-list\"><span class=\"line-item__price\">");
#nullable restore
#line 44 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                                                                                                                                                                                                                              Write(item.zDonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₫</span></div>
                                                  <!--meobiet-->
                                                </div>
                                              </div>
                                            </td>
                                            <td class=""line-item__quantity table__cell--center hidden-phone"">
                                              <div class=""quantity-selector"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 3290, "\"", 3360, 1);
#nullable restore
#line 51 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 3297, Url.Action("GiamMot","GioHang", new { IdFood = item.zIdFood }), 3297, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""quantity-selector__button"" aria-label=""Giảm số lượng xuống 1"" title=""Giảm số lượng xuống 1"">
                                                  <svg focusable=""false"" class=""icon icon--minus"" viewBox=""0 0 10 2"" role=""presentation"">
                                                    <path d=""M10 0v2H0V0z"" fill=""currentColor""></path>
                                                  </svg>
                                                </a>
                                                <input");
            BeginWriteAttribute("id", " id=\"", 3881, "\"", 3899, 1);
#nullable restore
#line 56 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 3886, item.zIdFood, 3886, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onchange=\"thayDoiSL(this.getAttribute(\'id\'));\" aria-label=\"Số lượng\" class=\"quantity-selector__value\" inputmode=\"numeric\"");
            BeginWriteAttribute("value", " value=\"", 4022, "\"", 4044, 1);
#nullable restore
#line 56 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 4030, item.zSoLuong, 4030, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" size=""2"">
                                                <script>
                                                  function thayDoiSL(id) {
                                                    var x = document.getElementById(id);
                                                    if (x.value.length == 0) {
                                                      x.value = ""1"";
                                                    }
                                                    else {
                                                      if (parseInt(x.value, 0) > 10) {
                                                        x.value = ""10"";

                                                      }
                                                      if (parseInt(x.value, 0) < 1) {
                                                        x.value = ""1"";
                                                      }
                                                    }
                                                ");
            WriteLiteral(@"    location.href = ""https://"" + location.host + ""/GioHang/CapNhatGioHang?IdFood="" + id + ""&soLuong="" + x.value;
                                                  }
                                                </script>
                                                <button");
            BeginWriteAttribute("dc-href", " dc-href=\"", 5347, "\"", 5420, 1);
#nullable restore
#line 75 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 5357, Url.Action("ThemMot","GioHang", new { IdFood = item.zIdFood }), 5357, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""location.href = this.getAttribute('dc-href');"" type=""button"" class=""quantity-selector__button"" aria-label=""Tăng số lượng lên 1"" title=""Tăng số lượng lên 1"">
                                                  <svg focusable=""false"" class=""icon icon--plus"" viewBox=""0 0 10 10"" role=""presentation"">
                                                    <path d=""M6 4h4v2H6v4H4V6H0V4h4V0h2v4z"" fill=""currentColor"" fill-rule=""evenodd""></path>
                                                  </svg>
                                                </button>
                                              </div>

                                            </td>
                                            <td class=""line-item__line-price table__cell--center hidden-phone""><span>");
#nullable restore
#line 83 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                                                                                                Write(item.zThanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>đ</td>\n               \n                                            <td class=\"line-item__line-price table__cell--right hidden-phone\">  <a");
            BeginWriteAttribute("href", " href=\"", 6362, "\"", 6429, 1);
#nullable restore
#line 85 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 6369, Url.Action("DeleteGH","GioHang", new { id = item.zIdFood }), 6369, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Loại bỏ</a></td>\n                                                  </tr>\n");
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \n                                        </tbody>\n                                    </table>\n                                </div>\n                            </div>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6d41e1b26002034a5eeee48d0ef95c73fec012616814", async() => {
                WriteLiteral(@"
                                <div class=""cart-recap__scroller"">
                                    <div class=""card"">
                                        <div class=""card__section"">
                                            <div class=""cart-recap__price-line text--pull"">
                                                <span class=""cart-recap__price-line-label"">Tổng cộng</span>
                                                <span style=""display: block; text-align: right;"" class=""saw-extra-note""></span><span class=""saw-cart-original-total""><span class=""cart-recap__price-line-price"">");
#nullable restore
#line 99 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                                                                                                                                                                                           Write(ViewBag.Tongtien);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"₫</span></span><br><span class=""saw-cart-total""></span>
                                            </div>
                                            <div class=""cart-recap__notices rte"">
                                                <p>
                                                    Phí vận chuyển tính tại bước thanh toán
                                                </p>
                                            </div>
");
                WriteLiteral("                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8141, "\"", 8216, 1);
#nullable restore
#line 108 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 8149, HttpContextAccessor.HttpContext.Session.GetString("KhachHangIdKH"), 8149, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"IDKHDN\" />\n                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8297, "\"", 8326, 1);
#nullable restore
#line 109 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 8305, Model.ToList().Count, 8305, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"SLGH\" />\n");
#nullable restore
#line 110 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
                                             if(a != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8474, "\"", 8491, 1);
#nullable restore
#line 112 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 8482, a.DiaChi, 8482, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"DiaChiKH\" />\n");
#nullable restore
#line 113 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8615, "\"", 8623, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"DiaChiKH\" />\n");
#nullable restore
#line 117 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\GioHang\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            

                                            <button onclick=""thanhToan();"" class=""cart-recap__checkout button button--primary button--full button--large"">Thanh toán</button>
                                            <script>
                                                function thanhToan() {
                                                    var z = document.getElementById(""IDKHDN"");
                                                    if (z.value == null || z.value.length == 0) {
                                                        alert(""Bạn hãy đăng nhập để thanh toán"");
                                                        return;
                                                    }
                                                    else {
                                                        var c = document.getElementById(""SLGH"");
                                                        if (parseInt(c.value, 0) == 0) {
                          ");
                WriteLiteral(@"                                  alert(""Giỏ hàng bạn đang trống"");
                                                            return;
                                                        }
                                                        var n = document.getElementById(""DiaChiKH"");
                                                        if (n.value.length == 0) {
                                                            alert(""Bạn hãy điền địa chỉ trong thông tin cá nhân để thanh toán"");
                                                            return;
                                                        }
                                                        else {
                                                            location.href = ""https://"" + location.host + ""/ThanhToan/Index"";
                                                            alert(""Bắt đầu chuyển hướng sang trang thanh toán"");
                                                            return;
                      ");
                WriteLiteral(@"                                  }
                                                    }
                                                    
                                                }
                                                
                                            </script>
                                        </div>
                                    </div>
                                    <div class=""cart-recap__secure-payment"">
                                        <p class=""cart-recap__secure-payment-title"">
                                            <svg focusable=""false"" class=""icon icon--lock-2"" viewBox=""0 0 12 15"" role=""presentation"">
                                                <g stroke=""currentColor"" stroke-width=""2"" fill=""none"" fill-rule=""evenodd"" stroke-linecap=""square"">
                                                    <path d=""M6 1C4.32 1 3 2.375 3 4.125V6h6V4.125C9 2.375 7.68 1 6 1zM1 6h10v8H1z""></path>
                                                </g>
  ");
                WriteLiteral(@"                                          </svg> 100% Bảo mật thanh toán
                                        </p>
                                        <div class=""cart-recap__secure-payment-list payment-list payment-list--centered"">
                                        </div>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </section>\n    </div>\n</main>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.GioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
