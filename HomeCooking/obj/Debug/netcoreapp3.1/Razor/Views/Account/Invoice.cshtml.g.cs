#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd72460d83ec6e9fc12916fd9e6ce55fc38920c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Invoice), @"mvc.1.0.view", @"/Views/Account/Invoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd72460d83ec6e9fc12916fd9e6ce55fc38920c", @"/Views/Account/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.HoaDonKhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
  
    ViewData["Title"] = "Account";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"" role=""main"">
    <section data-section-id=""account"" data-section-type=""account"">
        <div class=""container container--flush"">
            <div class=""layout"">
                <!--list t??c v???-->
                <div class=""layout__section layout__section--secondary"">
                    <div class=""card card--sticky hidden-pocket"">
                        <div class=""card__section card__section--tight"">

                          <div class=""card__linklist"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 690, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
WriteAttributeValue("", 660, Url.Action("Index","Account"), 660, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Th??ng tin c?? nh??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 778, "\"", 817, 1);
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
WriteAttributeValue("", 785, Url.Action("Invoice","Account"), 785, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link text--strong\">????n h??ng c???a t??i </a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 917, "\"", 961, 1);
#nullable restore
#line 18 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
WriteAttributeValue("", 924, Url.Action("FollowedFood","Account"), 924, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Th???c ph???m ???? theo d??i</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1052, "\"", 1096, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
WriteAttributeValue("", 1059, Url.Action("DangCongThuc","Account"), 1059, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">????ng c??ng th???c n???u ??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1225, 1);
#nullable restore
#line 20 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
WriteAttributeValue("", 1194, Url.Action("KhoBep","Account"), 1194, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__linklist-item link"">Kho b???p c???a t??i</a>
                            <a href=""#"" class=""card__linklist-item link"" data-no-instant="""" onclick=""logOutTK()"">????ng xu???t</a>
                          </div>
                        </div>
                    </div>
                </div>
                <!--layout t??c v??? -->
                <div class=""layout__section"">
                    <div class=""card"">
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1""> C??c ????n h??ng  </h1>
                        </div>
                        <div class=""card__section"">
                          <div class=""table-wrapper"">
                            <table class=""line-item-table table table--loose"">
                              <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 2062, "\"", 2070, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <tr>
                                  <th>
                                    Id h??a ????n
                                  </th>
                                  <th class=""table__cell--center"">
                                    Ng??y ?????t
                                  </th>
                                  <th class=""table__cell--center"">
                                    Ng??y nh???n
                                  </th>
                                  <th class=""table__cell--center"">
                                    T???ng gi?? tr???
                                  </th>
                                  <th class=""table__cell--center"">
                                    Ph????ng th???c thanh to??n
                                  </th>
                                  <th class=""table__cell--center"">
                                    T??nh tr???ng
                                  </th>
                                  <th class=""table__cell--right"">
            ");
            WriteLiteral("                        Thao t??c\n                                  </th>\n                                </tr>\n                                </thead>\n                              <tbody>\n\n");
#nullable restore
#line 62 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <tr>\n                                <td>\n                                  ");
#nullable restore
#line 66 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.IdInvoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 69 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 72 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 75 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("??\n                                </td>\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 78 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.PhuongThucThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 81 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--right hidden-phone\">\n                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd72460d83ec6e9fc12916fd9e6ce55fc38920c13066", async() => {
                WriteLiteral("Xem chi ti???t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
                                                                  WriteLiteral(item.IdInvoice);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                              </tr>\n");
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\Invoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                              </tbody>\n                            </table>\n                          </div>\n                        </div>\n                </div>\n            </div>\n                </div>\n        </div>\n    </section>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.HoaDonKhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
