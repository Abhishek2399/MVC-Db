#pragma checksum "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40eae3cbea53995692f09b0eb9b47e872a08f0e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_ShowAllEmployers), @"mvc.1.0.view", @"/Views/Employer/ShowAllEmployers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40eae3cbea53995692f09b0eb9b47e872a08f0e6", @"/Views/Employer/ShowAllEmployers.cshtml")]
    public class Views_Employer_ShowAllEmployers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DALPro.Models.Employer>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40eae3cbea53995692f09b0eb9b47e872a08f0e63066", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowAllEmployers</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40eae3cbea53995692f09b0eb9b47e872a08f0e64136", async() => {
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerPwd));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerInfo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerClients));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerPwd));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerInfo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerClients));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 65 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 66 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "D:\capgemini\training\technical\ASP-MVC-Db\MVCWithDb\MVCWithDb\Views\Employer\ShowAllEmployers.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DALPro.Models.Employer>> Html { get; private set; }
    }
}
#pragma warning restore 1591