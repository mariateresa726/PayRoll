#pragma checksum "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499cb130fc0c1add898ab139cca0a929778e606b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayRoll_PayRollDetails), @"mvc.1.0.view", @"/Views/PayRoll/PayRollDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PayRoll/PayRollDetails.cshtml", typeof(AspNetCore.Views_PayRoll_PayRollDetails))]
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
#line 1 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\_ViewImports.cshtml"
using PayRollV1;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\_ViewImports.cshtml"
using PayRollV1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499cb130fc0c1add898ab139cca0a929778e606b", @"/Views/PayRoll/PayRollDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6336d2600d2279f0ff88a92ba239b0240b9cfa", @"/Views/_ViewImports.cshtml")]
    public class Views_PayRoll_PayRollDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayRollV1.Models.Employee>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
  
    ViewData["Title"] = "PAY ROLL DETAILS";

#line default
#line hidden
            BeginContext(88, 39, true);
            WriteLiteral("\r\n    <h2>PAY ROLL DETAILS</h2>\r\n\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
  

    Layout = null;


#line default
#line hidden
            BeginContext(158, 35, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(193, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4f58b56d924498bf579e1e4d392562", async() => {
                BeginContext(199, 93, true);
                WriteLiteral("\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n    <title>Index</title>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(299, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(303, 1262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ae63c8bb2d4238bb4be0cacde07815", async() => {
                BeginContext(309, 50, true);
                WriteLiteral("\r\n    <h3 onclick=\"window.print();\"> Print </h3>  ");
                EndContext();
                BeginContext(379, 93, true);
                WriteLiteral("\r\n\r\n<fieldset>\r\n\r\n    <legend>Details</legend>\r\n\r\n    <div class=\"display-label\">\r\n\r\n        ");
                EndContext();
                BeginContext(473, 40, false);
#line 40 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(513, 61, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"display-field\">\r\n\r\n        ");
                EndContext();
                BeginContext(575, 36, false);
#line 46 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(611, 65, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"display-label\">\r\n\r\n        ");
                EndContext();
                BeginContext(677, 44, false);
#line 54 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayNameFor(model => model.TotalSal));

#line default
#line hidden
                EndContext();
                BeginContext(721, 61, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"display-field\">\r\n\r\n        ");
                EndContext();
                BeginContext(783, 40, false);
#line 60 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayFor(model => model.TotalSal));

#line default
#line hidden
                EndContext();
                BeginContext(823, 61, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n\r\n        ");
                EndContext();
                BeginContext(885, 42, false);
#line 66 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayNameFor(model => model.Leaves));

#line default
#line hidden
                EndContext();
                BeginContext(927, 61, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"display-field\">\r\n\r\n        ");
                EndContext();
                BeginContext(989, 38, false);
#line 72 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayFor(model => model.Leaves));

#line default
#line hidden
                EndContext();
                BeginContext(1027, 59, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"display-label\">\r\n\r\n        ");
                EndContext();
                BeginContext(1087, 41, false);
#line 77 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayNameFor(model => model.Month));

#line default
#line hidden
                EndContext();
                BeginContext(1128, 59, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"display-field\">\r\n\r\n        ");
                EndContext();
                BeginContext(1188, 37, false);
#line 82 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayFor(model => model.Month));

#line default
#line hidden
                EndContext();
                BeginContext(1225, 59, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"display-label\">\r\n\r\n        ");
                EndContext();
                BeginContext(1285, 42, false);
#line 87 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(1327, 59, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"display-field\">\r\n\r\n        ");
                EndContext();
                BeginContext(1387, 38, false);
#line 92 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(1425, 69, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n\r\n</fieldset>\r\n\r\n    <p>\r\n\r\n        |\r\n\r\n        ");
                EndContext();
                BeginContext(1495, 47, false);
#line 104 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\PayRoll\PayRollDetails.cshtml"
   Write(Html.ActionLink("Back to List", "Index","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 16, true);
                WriteLiteral("\r\n\r\n    </p>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1565, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayRollV1.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
