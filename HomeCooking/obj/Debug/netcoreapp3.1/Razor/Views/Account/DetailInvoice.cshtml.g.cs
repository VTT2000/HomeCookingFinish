#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84efdb33c110e3b85d65a90109004925db28b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_DetailInvoice), @"mvc.1.0.view", @"/Views/Account/DetailInvoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84efdb33c110e3b85d65a90109004925db28b5b", @"/Views/Account/DetailInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_DetailInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ChiTietHoaDonKhachHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 660, "\"", 697, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 667, Url.Action("Index","Account"), 667, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Th??ng tin c?? nh??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 824, 1);
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 792, Url.Action("Invoice","Account"), 792, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link text--strong\">????n h??ng c???a t??i </a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 924, "\"", 968, 1);
#nullable restore
#line 18 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 931, Url.Action("FollowedFood","Account"), 931, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Th???c ph???m ???? theo d??i</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1103, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 1066, Url.Action("DangCongThuc","Account"), 1066, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">????ng c??ng th???c n???u ??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1232, 1);
#nullable restore
#line 20 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 1201, Url.Action("KhoBep","Account"), 1201, 31, false);

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
                          <table class=""line-item-table table table--loose"">
                            <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 2011, "\"", 2019, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                              <tr>
                                  <th >
                                    T??n th???c ph???m
                                  </th>
                                  <th class=""table__cell--center"">
                                    Thu???c l?? h??ng
                                  </th class=""table__cell--center""> 
                                  <th class=""table__cell--center"">
                                    S??? l?????ng
                                  </th>
                                  <th  class=""table__cell--right"">
                                    Gi?? tr???
                                  </th>
                              </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 51 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
                               foreach (var item in Model)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n\n                              <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2979, "\"", 3056, 1);
#nullable restore
#line 56 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 2986, Url.Action("Index","Food", new { id=item.IdLoHangNavigation.IdFood }), 2986, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                  ");
#nullable restore
#line 57 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
                             Write(Html.DisplayFor(modelItem => item.IdLoHangNavigation.IdFoodNavigation.NameFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </a>\n\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                ");
#nullable restore
#line 63 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdLoHangNavigation.IdLoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                ");
#nullable restore
#line 66 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                              </td>\n                              <td class=\"line-item__line-price table__cell--right hidden-phone\">\n                                ");
#nullable restore
#line 69 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("??\n                              </td>\n\n                            </tr>\n");
#nullable restore
#line 73 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                          </table>\n                          <a class=\"fa fa-angle-double-left product-form__add-button button button--primary\"");
            BeginWriteAttribute("href", " href=\"", 4116, "\"", 4155, 1);
#nullable restore
#line 76 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\DetailInvoice.cshtml"
WriteAttributeValue("", 4123, Url.Action("Invoice","Account"), 4123, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tr??? v???</a>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </section>\n</main>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ChiTietHoaDonKhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
