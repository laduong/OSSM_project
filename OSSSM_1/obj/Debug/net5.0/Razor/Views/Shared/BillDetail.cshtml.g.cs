#pragma checksum "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238fd71a354ee509c0f88dc317b4e72821f70311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BillDetail), @"mvc.1.0.view", @"/Views/Shared/BillDetail.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\_ViewImports.cshtml"
using OSSSM_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\_ViewImports.cshtml"
using OSSSM_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238fd71a354ee509c0f88dc317b4e72821f70311", @"/Views/Shared/BillDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a502b138ce6b01a59ddd14173ae4f2ede3df2d12", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BillDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Bill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangetoChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/nhanSu&DuAn.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Buttons", async() => {
                WriteLiteral("\r\n        <a class=\"header-item\"></a>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f703117704", async() => {
                    WriteLiteral("Tổng quan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f703119021", async() => {
                    WriteLiteral("Sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031110337", async() => {
                    WriteLiteral("Kho hàng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031111654", async() => {
                    WriteLiteral("Hóa đơn");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031112970", async() => {
                    WriteLiteral("Chi phí");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            DefineSection("Login", async() => {
                WriteLiteral("\r\n        <li class=\"user-info-item\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031114454", async() => {
                    WriteLiteral("Đổi mật khẩu");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </li>\r\n        <li class=\"user-info-item\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031115964", async() => {
                    WriteLiteral("Đăng xuất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </li>\r\n    ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031117511", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "238fd71a354ee509c0f88dc317b4e72821f7031117953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"//cdnjs.cloudflare.com/ajax/libs/jodit/3.20.2/jodit.min.css\" />\r\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/jodit/3.20.2/jodit.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031120034", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"wrap-back\" style=\"display:flex;\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031120362", async() => {
                    WriteLiteral("<h2 class=\"backMainPage\"> Trang Chủ</h2>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <p>/</p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031121646", async() => {
                    WriteLiteral("<h2 style=\"padding-left: 10px;\" class=\"backMainPage\">Kho hàng</h2>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <p>/</p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238fd71a354ee509c0f88dc317b4e72821f7031122960", async() => {
                    WriteLiteral("<h2 style=\"padding-left: 10px;\" class=\"backMainPage\"> Nhập lô hàng mới</h2>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div></div>\r\n\r\n    <div class=\"product-details\" style=\"width:65vw; margin:auto\">\r\n        <div style=\"margin: 16px 10px; justify-content: left; width: 50%\">\r\n            <div>\r\n                <p>Mã đơn hàng: ");
#nullable restore
#line 47 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                           Write(Model.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>


            </div>
        </div>
        <div style=""margin: 16px 10px; justify-content: left; width: 50%"">
            <div>
                <p>Tên đơn hàng: </p>
                <input style="" height: 25px; margin-top: -5px; width: 80%; padding: 16px"" id=""name-input"" type=""text"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 2091, "\"", 2110, 1);
#nullable restore
#line 55 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 2099, Model.Name, 2099, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

            </div>
        </div>
        <div style=""margin: 16px 10px; justify-content: left; width: 50%"">
            <div>
                <p>Tên đơn hàng: </p>
                <input style="" height: 25px; margin-top: -5px; width: 80%; padding: 16px"" id=""name-input"" type=""text"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 2413, "\"", 2435, 1);
#nullable restore
#line 62 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 2421, Model.Address, 2421, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            </div>\r\n        </div>\r\n        <div style=\"width: 50%\">\r\n            <p>Ngày nhập hàng: ");
#nullable restore
#line 67 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                          Write(Model.BuyDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <input type=\"datetime-local\" id=\"birthdaytime\" name=\"buytime\" style=\"width: 80%; padding: 16px\" ,");
                BeginWriteAttribute("value", " value=\"", 2671, "\"", 2693, 1);
#nullable restore
#line 68 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 2679, Model.BuyDate, 2679, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>


    </div>


    <div class=""container mt-2"" style=""width: 85vw; margin: auto;"">
        <table class=""table-quyTrinh"" style=""width: 85vw"">
            <tr>
                <th>
                    ID

                </th>
                <th>
                    Tên sản phẩm

                </th>
                <th>
                    Giá bán

                </th>

                <th>
                    Số lượng
                </th>

                <th style=""text-align: center; width: 5%;"">
                    Chức năng
                </th>
            </tr>

");
#nullable restore
#line 100 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
             foreach (var item in Model.Item_List)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr id=\"0\" style=\"user-select: auto;\">\r\n                    <td style=\"user-select: auto; text-align: center;\"> ");
#nullable restore
#line 103 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                                                                   Write(item.Item.Product_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"user-select: auto;\"> ");
#nullable restore
#line 104 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                                               Write(item.Item.Product_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"user-select: auto;\"> ");
#nullable restore
#line 105 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                                               Write(item.Item.Product_Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td style=\"user-select: auto; text-align: center;\"> ");
#nullable restore
#line 106 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                                                                   Write(item.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td style=\"user-select: auto; text-align: center;\">\r\n                        <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3922, "\"", 4020, 3);
                WriteAttributeValue("", 3932, "location.href=\'", 3932, 15, true);
#nullable restore
#line 109 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 3947, Url.Action("ProductDetail", new { product_id = @item.Item.Product_ID }), 3947, 72, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4019, "\'", 4019, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i class=\"fa fa-info-circle\"></i>\r\n                        </button>\r\n                        <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4167, "\"", 4214, 3);
                WriteAttributeValue("", 4177, "confirm_detele(", 4177, 15, true);
#nullable restore
#line 112 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 4192, item.Item.Product_ID, 4192, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4213, ")", 4213, 1, true);
                EndWriteAttribute();
                WriteLiteral(" id=\"deleteMember\"");
                BeginWriteAttribute("value", " value=\"", 4233, "\"", 4262, 1);
#nullable restore
#line 112 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 4241, item.Item.Product_ID, 4241, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i class=\"fa-solid fa-trash-can\"></i>\r\n                        </button>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 118 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 124 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
     foreach (var item in Model.Item_List)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div style=\"display: none; min-width: 40%; height: 30%; left: 30%; top: 30%; z-index: 1;\" class=\"form-frame delete-form\"");
                BeginWriteAttribute("id", " id=\"", 4650, "\"", 4676, 1);
#nullable restore
#line 126 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 4655, item.Item.Product_ID, 4655, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <a style=\"text-align: center; color: #000;\"> Bạn có chắc chắn muốn xóa thông báo có ID = ");
#nullable restore
#line 127 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
                                                                                                Write(item.Item.Product_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" không? </a>\r\n            <div>\r\n                <button class=\"button\" style=\"color:#000; border: 1px #edcd1f solid;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4920, "\"", 5043, 3);
                WriteAttributeValue("", 4930, "location.href=\'", 4930, 15, true);
#nullable restore
#line 129 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
WriteAttributeValue("", 4945, Url.Action("DeleteItemFromBill", new { product_id = item.Item.Product_ID , bill_id = Model.ID }), 4945, 97, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5042, "\'", 5042, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"Có\">Có</button>\r\n                <button class=\"button\" onclick=\"confirm_delete_disabled()\" style=\"margin-top: 15px; color:#000; border: 1px #edcd1f solid;\">Không</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 133 "C:\Users\Admin\source\repos\OSSSM_1\OSSSM_1\Views\Shared\BillDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"




    <style>

        .product-details {
            display: flex;
            justify-content: space-between;
            padding: 20px;
            margin-top: 5%;
        }

        .left-column,
        .right-column {
            flex: 1;
        }

        .left-column {
            width: 50%;
            float: left;
        }

        .product-info {
            margin-bottom: 2%;
        }

        .product-image {
            margin-top: 5%;
            width: 70%;
            height: 40%;
            margin-bottom: 2%;
        }

        .action-button {
            background-color: #FFD700;
            color: #000;
            font-size: 16px;
            margin-top: 20px;
            margin-right: 100%;
            margin-left: 20px;
            width: 35%;
            height: 5%;
            border: none;
            border-radius: 10px;
            cursor: pointer;
        }

        .right-column {
            width: 50%;
            fl");
                WriteLiteral(@"oat: left;
            position: relative;
        }

        .left-column .product-info > * {
            margin-bottom: 25px; /* Điều chỉnh giá trị này để thay đổi khoảng cách giữa các thẻ con */
        }

        .right-column .product-info > * {
            margin-bottom: 25px; /* Điều chỉnh giá trị này để thay đổi khoảng cách giữa các thẻ con */
        }

        .right-column .product-info {
            margin-bottom: 30px;
        }

        .right-column .image-container {
            position: relative;
        }

        .right-column img {
            width: 80%;
            height: 20%;
            margin-bottom: 2%;
        }

        /* Nút ""Lưu"" ở dưới hình ảnh ở cột phải */
        .right-column .save-button {
            background-color: #FFD700;
            color: #000;
            font-size: 16px;
            margin-top: 10px;
            margin-left: 55%;
            margin-right: 100%;
            width: 25%;
            height: 5%;
            borde");
                WriteLiteral(@"r: none;
            border-radius: 10px;
            cursor: pointer;
        }
    </style>

    </div>


    <script src=""./js/dataNhanSu.js""></script>
    <script src=""./js/dataDuAn.js""></script>
    <script>
        const editor = Jodit.make('#notification_content');
    </script>
    <script>

        function confirm_detele(id) {
            var subScene = document.getElementsByClassName(""delete-form"");
            for (let i = 0; i < subScene.length; i++) {
                subScene[i].style.display = ""none"";
                if (subScene[i].id == id) {
                    subScene[i].style.display = ""block"";
                }
            }
        }


        function confirm_delete_disabled() {
            var subScene = document.getElementsByClassName(""delete-form"");
            for (let i = 0; i < subScene.length; i++) {
                subScene[i].style.display = ""none"";
            }
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
