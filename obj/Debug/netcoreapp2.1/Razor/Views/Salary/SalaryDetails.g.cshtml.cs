#pragma checksum "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5865c1a7cd7adfa1b44422d9aef9af0660f339e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salary_SalaryDetails), @"mvc.1.0.view", @"/Views/Salary/SalaryDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Salary/SalaryDetails.cshtml", typeof(AspNetCore.Views_Salary_SalaryDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5865c1a7cd7adfa1b44422d9aef9af0660f339e3", @"/Views/Salary/SalaryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6336d2600d2279f0ff88a92ba239b0240b9cfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_SalaryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayRollV1.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
  
    ViewData["Title"] = "Salary details";

#line default
#line hidden
            BeginContext(88, 21, true);
            WriteLiteral("\r\n<style>\r\n</style>\r\n");
            EndContext();
            BeginContext(172, 29, true);
            WriteLiteral("<h2>SALARY DETAILS</h2>\r\n\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
     if (Model.Basic_pay == 0)
    {


        

#line default
#line hidden
            BeginContext(253, 67, false);
#line 18 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
   Write(Html.ActionLink("AddSalary", "AddSalary", new { id = Model.EmpID }));

#line default
#line hidden
            EndContext();
#line 18 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
                                                                            
    }
    else
    {


#line default
#line hidden
            BeginContext(348, 449, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                Employee Name
            </th>

            <th>
                Basic Salary
            </th>
            <th>
                HRA
            </th>
            <th>
                TA
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
        
        
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(798, 40, false);
#line 48 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(838, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(906, 45, false);
#line 51 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Basic_pay));

#line default
#line hidden
            EndContext();
            BeginContext(951, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1019, 39, false);
#line 54 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
               Write(Html.DisplayFor(modelItem => Model.HRA));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1126, 38, false);
#line 57 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
               Write(Html.DisplayFor(modelItem => Model.TA));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 73, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(1238, 70, false);
#line 63 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
               Write(Html.ActionLink("Edit Salary", "SalaryEdit", new { id = Model.EmpID }));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 27, true);
            WriteLiteral("\r\n                    <div>");
            EndContext();
            BeginContext(1336, 47, false);
#line 64 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
                    Write(Html.ActionLink("Back to List", "Index","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 86, true);
            WriteLiteral("</div>\r\n\r\n                </td>\r\n            </tr>\r\n        \r\n    </tbody>\r\n</table>\r\n");
            EndContext();
#line 71 "C:\Users\Administrator\source\repos\PayRollV1\PayRollV1\Views\Salary\SalaryDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(1487, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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