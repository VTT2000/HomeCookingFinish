#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd258a7adbc2e25036a7a14d8d61451a94b6ac7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_KhoBep), @"mvc.1.0.view", @"/Views/Account/KhoBep.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd258a7adbc2e25036a7a14d8d61451a94b6ac7b", @"/Views/Account/KhoBep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_KhoBep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeCooking.Models.ChiTietKhoBep>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 652, "\"", 689, 1);
#nullable restore
#line 16 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 659, Url.Action("Index","Account"), 659, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Th??ng tin c?? nh??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 815, 1);
#nullable restore
#line 17 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 783, Url.Action("Invoice","Account"), 783, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">????n h??ng c???a t??i </a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 902, "\"", 946, 1);
#nullable restore
#line 18 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 909, Url.Action("FollowedFood","Account"), 909, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Th???c ph???m ???? theo d??i</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1081, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 1044, Url.Action("DangCongThuc","Account"), 1044, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">????ng c??ng th???c n???u ??n</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1210, 1);
#nullable restore
#line 20 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 1179, Url.Action("KhoBep","Account"), 1179, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__linklist-item link text--strong"">Kho b???p c???a t??i</a>
                            <a href=""#"" class=""card__linklist-item link"" data-no-instant="""" onclick=""logOutTK()"">????ng xu???t</a>
                          </div>
                        </div>
                    </div>
                </div>
                <!--layout t??c v??? -->
                <div class=""layout__section"">
                    <div class=""card"">
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1"">Kho b???p online </h1>
                        </div>
                        <div class=""card__section"">
                           <table class=""line-item-table table table--loose"">
                            <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 2003, "\"", 2011, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <tr>
                                    <th>
                                        T??n th???c ph???m
                                    </th>

                                    <th class=""table__cell--center"">
                                      Ng??y s???n xu???t
                                    </th>
                                    <th  class=""table__cell--center"">
                                      Ng??y h???t h???n
                                    </th>
                                    <th  class=""table__cell--center"">
                                        S??? l?????ng hi???n t???i/????n v??? t??nh
                                    </th>
                                    <th  class=""table__cell--center"">
                                        Tr???ng th??i
                                    </th>
                                    <th class=""table__cell--center"">
                                        Thao t??c
                                    </th>
                ");
            WriteLiteral("                </tr>\n                              </thead>\n                            <tbody>\n");
#nullable restore
#line 58 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                               foreach (var item in Model)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                              <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3326, "\"", 3515, 1);
#nullable restore
#line 62 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 3333, Url.Action("Index","Food", new { id = item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.IdFood }), 3333, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                  ");
#nullable restore
#line 63 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                             Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.NameFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                </a>\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                ");
#nullable restore
#line 68 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.NgaySanXuat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                ");
#nullable restore
#line 71 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.NgayHetHan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                ");
#nullable restore
#line 74 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SoLuongTrongChiTietHoDonKhachHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 74 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.IdInvoiceNavigation.ChiTietHoaDonKhachHangs.FirstOrDefault(p => p.IdLoHang == item.IdLoHang).IdLoHangNavigation.IdFoodNavigation.DonViTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                              </td>\n                              <td class=\"line-item__line-price table__cell--center hidden-phone\">\n");
#nullable restore
#line 77 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                 if (item.Status != "???? h???ng")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>C??n h???n</span> ");
#nullable restore
#line 79 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                                 }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color:red;\">H???t h???n</span>");
#nullable restore
#line 82 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                              </td>

                              <td class=""line-item__line-price table__cell--right hidden-phone"">
                                <button class=""product-form__add-button button button--primary"" onclick=""XacNhanXoaTP(this.getAttribute('address-href'));""");
            BeginWriteAttribute("address-href", " address-href=\"", 5547, "\"", 5687, 1);
#nullable restore
#line 87 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 5562, Url.Action("DeleteKhoBep","Account", new { IdKhoBep = item.IdKhoBep, IdInvoice = item.IdInvoice, IdLoHang = item.IdLoHang }), 5562, 125, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">X??a th???c ph???m</button>
                                <script>
                                  function XacNhanXoaTP(diachihref) {
                                    if (confirm(""B???n ch???c ch???n mu???n x??a th???c ph???m n??y ra kh???i kho b???p ?"")) {
                                      location.href = ""https://"" + location.host + diachihref;
                                    }
                                  }
                                </script>
                              </td>
                            </tr>");
#nullable restore
#line 96 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            </table>
                        </div>
                        <div class=""card__section card__section--tight"">
                            <h1 class=""heading h1"">C??c m??n ??n g???i ?? ph?? h???p v???i c??c nguy??n li???u hi???n t???i </h1>
                        </div>
                        <div class=""card__section"">
                          <table class=""line-item-table table table--loose"">
                            <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 6718, "\"", 6726, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                              <tr>
                                <th>
                                H??nh ???nh
                                </th>
                                <th>
                                  T??n c??ng th???c
                                </th>
                                <th class=""table__cell--center"">
                                  M?? t??? m??n ??n
                                </th>
                                <th  class=""table__cell--right"">
                                  Thao t??c
                                </th>
                              </tr>
                            <tbody>
");
#nullable restore
#line 121 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                               foreach (CongThucNauAn item in ViewBag.ListAvailable)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              <tr class=""line-item line-item--stack"">
                                
                                <td class=""line-item__product-info"">
                                  <div class=""line-item__product-info-wrapper"">
                                    <div class=""line-item__image-wrapper"">
                                      <div class=""aspect-ratio"" style=""padding-bottom: 100.0%"">
                                      
                                          <img");
            BeginWriteAttribute("src", " src=\"", 7996, "\"", 8019, 1);
#nullable restore
#line 130 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 8002, item.LinkHinhAnh, 8002, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
     
                                      </div>
                                    </div>
                                    
                                  </div>                                          
</td>
                                <td>
                                    <div class=""line-item__meta"">
                                        <a href=""#"" class=""line-item__title link text--strong"">");
#nullable restore
#line 139 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                                                                                          Write(item.TenCongThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </div>\n                                </td>\n\n                                <td class=\"line-item__line-price table__cell--center hidden-phone\">\n                                  ");
#nullable restore
#line 144 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
                             Write(item.MoTaMonAn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"line-item__line-price table__cell--right hidden-phone\">\n                                  <a");
            BeginWriteAttribute("href", " href=\"", 8869, "\"", 8949, 1);
#nullable restore
#line 147 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
WriteAttributeValue("", 8876, Url.Action("Index","ChiTietCongThucNauAn", new { id = item.IdCongThuc }), 8876, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem chi ti???t</a>\n                                </td>\n                              </tr>\n");
#nullable restore
#line 150 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\KhoBep.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                          </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </section>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeCooking.Models.ChiTietKhoBep>> Html { get; private set; }
    }
}
#pragma warning restore 1591
