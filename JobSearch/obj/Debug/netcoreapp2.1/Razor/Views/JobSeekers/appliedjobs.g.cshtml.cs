#pragma checksum "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb8af5eebb4a62a6a2db27062aa009263ab96c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobSeekers_appliedjobs), @"mvc.1.0.view", @"/Views/JobSeekers/appliedjobs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobSeekers/appliedjobs.cshtml", typeof(AspNetCore.Views_JobSeekers_appliedjobs))]
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
#line 1 "D:\Projects\JobSearch\Views\_ViewImports.cshtml"
using JobSearch;

#line default
#line hidden
#line 2 "D:\Projects\JobSearch\Views\_ViewImports.cshtml"
using JobSearch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb8af5eebb4a62a6a2db27062aa009263ab96c3", @"/Views/JobSeekers/appliedjobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf5bc95cb5e82e85e2334780f4af49ff03ee4a8", @"/Views/_ViewImports.cshtml")]
    public class Views_JobSeekers_appliedjobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppliedJobDetails>
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
#line 2 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
  
    ViewData["Title"] = "appliedjobs";
    Layout = "~/Views/Shared/_mstLayout.cshtml";

#line default
#line hidden
            BeginContext(123, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(127, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daeb3128fe846558dbeb95f37a2d90e", async() => {
                BeginContext(133, 227, true);
                WriteLiteral("\r\n        <style>\r\n\r\n\r\n\r\n\r\n            table {\r\n                -webkit-box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n                box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n            }\r\n        </style>\r\n\r\n\r\n\r\n    ");
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
            BeginContext(367, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(375, 1079, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9944e41137dd4123b22541e79cee702a", async() => {
                BeginContext(381, 313, true);
                WriteLiteral(@"
        <div style=""margin-top:140px;"">
            <h1 style=""font-size:35px;font-family:'Century Gothic';margin-left:450px;color:White"">Applied Job details</h1>
        </div>
        <font size=""5px"" style=""font-family:Calibri"">
            <div style=""margin-top:12px;margin-left:150px;""  id=""card"">

");
                EndContext();
#line 29 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
                 foreach (var item in Model.details)
                {

#line default
#line hidden
                BeginContext(767, 202, true);
                WriteLiteral("                    <table style=\"margin-top:15px;width:100%;background-color:white;\">\r\n                        <tr>\r\n                            <td>Company Name:</td>\r\n                            <td>");
                EndContext();
                BeginContext(970, 17, false);
#line 34 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
                           Write(item.ComapanyName);

#line default
#line hidden
                EndContext();
                BeginContext(987, 149, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Job Title:</td>\r\n                            <td>");
                EndContext();
                BeginContext(1137, 14, false);
#line 38 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
                           Write(item.Job_Title);

#line default
#line hidden
                EndContext();
                BeginContext(1151, 150, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Applied On:</td>\r\n                            <td>");
                EndContext();
                BeginContext(1302, 13, false);
#line 42 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
                           Write(item.Ent_date);

#line default
#line hidden
                EndContext();
                BeginContext(1315, 70, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </table>\r\n");
                EndContext();
#line 46 "D:\Projects\JobSearch\Views\JobSeekers\appliedjobs.cshtml"
                }

#line default
#line hidden
                BeginContext(1404, 43, true);
                WriteLiteral("\r\n            </div>\r\n        </font>\r\n    ");
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
            BeginContext(1454, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppliedJobDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
