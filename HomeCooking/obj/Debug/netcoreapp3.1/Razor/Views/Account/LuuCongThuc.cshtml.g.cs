#pragma checksum "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d3cebb107240cb3d09982a641d7ee1a6052cd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LuuCongThuc), @"mvc.1.0.view", @"/Views/Account/LuuCongThuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d3cebb107240cb3d09982a641d7ee1a6052cd4", @"/Views/Account/LuuCongThuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab5b78951083fa90d4060226d3c0cd3e61d794", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LuuCongThuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFollowedFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
  
    ViewData["Title"] = "LuuCongThuc";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>LuuCongThuc</h1>

<main id=""main"" role=""main"">
  <section data-section-id=""account"" data-section-type=""account"">
    <div class=""container container--flush"">
      <div class=""layout"">
        <!--list tác vụ-->
        <div class=""layout__section layout__section--secondary"">
          <div class=""card card--sticky hidden-pocket"">
            <div class=""card__section card__section--tight"">

              <div class=""card__linklist"">
                <a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 607, 1);
#nullable restore
#line 19 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
WriteAttributeValue("", 577, Url.Action("Index","Account"), 577, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Thông tin cá nhân</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 723, 1);
#nullable restore
#line 20 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
WriteAttributeValue("", 691, Url.Action("Invoice","Account"), 691, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link \">Đơn hàng của tôi </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 844, 1);
#nullable restore
#line 21 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
WriteAttributeValue("", 807, Url.Action("FollowedFood","Account"), 807, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Thực phẩm đã theo dõi</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 967, 1);
#nullable restore
#line 22 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
WriteAttributeValue("", 930, Url.Action("DangCongThuc","Account"), 930, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__linklist-item link\">Đăng công thức nấu ăn</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1085, 1);
#nullable restore
#line 23 "C:\Users\DELL\Downloads\HomeCooking-finish\HomeCooking-finish\HomeCooking-main\HomeCooking-main\HomeCooking-main\HomeCooking\Views\Account\LuuCongThuc.cshtml"
WriteAttributeValue("", 1054, Url.Action("KhoBep","Account"), 1054, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__linklist-item link"">Kho bếp của tôi</a>                
                <a href=""#"" class=""card__linklist-item link"" data-no-instant="""" onclick=""logOutTK()"">Đăng xuất</a>
              </div>
            </div>
          </div>
        </div>
        <!--layout tác vụ -->
        <div class=""layout__section"">
          <div class=""card"">
            <div class=""card__section card__section--tight"">
              <h1 class=""heading h1""> Các thực phẩm đã theo dõi </h1>
            </div>
            <div class=""table-wrapper"">
              <table class=""line-item-table table table--loose"">
                <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 1752, "\"", 1760, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                  <tr>
                    <th>
                      Id  công thức
                    </th>
                    <th class=""table__cell--center"">
                      Tên công thức
                    </th>
                    <th class=""table__cell--center"">
                      Mô tả
                    </th>
                    <th class=""table__cell--right"">
                      tác vụ
                    </th>
                  </tr>
                </thead>
                <tbody>

                  <tr>
                    <td>
                      id
                    </td>
                    <td class=""line-item__line-price table__cell--center hidden-phone"">
                      <a href=""#"">
                        tên
                      </a>
                    </td>
                    <td class=""line-item__line-price table__cell--center hidden-phone"">
                      mô tả
                    </td>
                    <td class=""lin");
            WriteLiteral("e-item__line-price table__cell--right hidden-phone\">\r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d3cebb107240cb3d09982a641d7ee1a6052cd49387", async() => {
                WriteLiteral("Bỏ theo dõi");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>
                  </tr>}
                </tbody>
              </table>
            </div>
            <div class=""card__section card__section--tight"">
              <h1 class=""heading h1""> Các công thức của tôi </h1>
              <div class=""table-wrapper"">
                <table class=""line-item-table table table--loose"">
                  <thead class=""hidden-phone""");
            BeginWriteAttribute("style", " style=\"", 3337, "\"", 3345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <tr>
                      <th>
                        Id  công thức
                      </th>
                      <th class=""table__cell--center"">
                        Tên công thức
                      </th>
                      <th class=""table__cell--center"">
                        Mô tả
                      </th>
                      <th class=""table__cell--right"">
                        tác vụ
                      </th>
                    </tr>
                  </thead>
                  <tbody>

                    <tr>
                      <td>
                        id
                      </td>
                      <td class=""line-item__line-price table__cell--center hidden-phone"">
                        <a href=""#"">
                          tên
                        </a>
                      </td>
                      <td class=""line-item__line-price table__cell--center hidden-phone"">
                        mô tả
       ");
            WriteLiteral("               </td>\r\n                      <td class=\"line-item__line-price table__cell--right hidden-phone\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d3cebb107240cb3d09982a641d7ee1a6052cd412826", async() => {
                WriteLiteral("xoá");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                      </td>
                    </tr>}
                  </tbody>
                </table>
                <!-- nếu chưa đăng  thì xài
                <h3 class=""heading h3"">Hãy đăng công thức</h3>
               <a class=""product-form__add-button button button--primary"" href=""#"">đăng</a>
              -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591