#pragma checksum "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed3d48441ba2480068ec0fb4652345542ed6618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recruiter_PostedJobs), @"mvc.1.0.view", @"/Views/Recruiter/PostedJobs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recruiter/PostedJobs.cshtml", typeof(AspNetCore.Views_Recruiter_PostedJobs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed3d48441ba2480068ec0fb4652345542ed6618", @"/Views/Recruiter/PostedJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf5bc95cb5e82e85e2334780f4af49ff03ee4a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Recruiter_PostedJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PostedJob>>
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
#line 3 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
  
    ViewData["Title"] = "PostedJob";
    Layout = "~/Views/Shared/_RLayout.cshtml";

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8cde0b933d04f5b8fa2ea4488e34ad1", async() => {
                BeginContext(128, 199, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n\r\n\r\n        table {\r\n            -webkit-box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n            box-shadow: 2px 5px 11px 2px rgba(0,0,0,0.75);\r\n        }\r\n    </style>\r\n\r\n\r\n\r\n");
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
            BeginContext(334, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(340, 1802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb8daaabfd54e47963160093143958a", async() => {
                BeginContext(346, 287, true);
                WriteLiteral(@"
    <div style=""margin-top:140px;"">
        <h1 style=""font-size:35px;font-family:Calibri;margin-left:450px;color:white"">Posted jobs</h1>
    </div>

    <div style=""margin-top:12px;width:60%;margin-left:250px;"" id=""card"">
        <font size=""5px"" style=""font-family:Calibri"">

");
                EndContext();
#line 33 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
             foreach (var postedJob in Model)
            {

         


#line default
#line hidden
                BeginContext(710, 233, true);
                WriteLiteral("            <table style=\"margin-top:15px;width:100%;background-color:white;\">\r\n                <tr style=\"padding-left:5px;background-color:antiquewhite; align-content:center;\">\r\n\r\n                    <td colspan=\"2\" align=\"center\">");
                EndContext();
                BeginContext(944, 15, false);
#line 41 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                              Write(postedJob.CName);

#line default
#line hidden
                EndContext();
                BeginContext(959, 212, true);
                WriteLiteral("</td>\r\n                    \r\n\r\n                </tr>\r\n                <tr>\r\n                    <td style=\"padding-left:5px\" width=\"175px\">Skill Required:</td>\r\n                    <td style=\"padding-left:20px;\">");
                EndContext();
                BeginContext(1172, 15, false);
#line 47 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                              Write(postedJob.Skill);

#line default
#line hidden
                EndContext();
                BeginContext(1187, 178, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n\r\n\r\n                <tr>\r\n                    <td style=\"padding-left:5px\">No Of Vacancy:</td>\r\n                    <td style=\"padding-left:20px\">");
                EndContext();
                BeginContext(1366, 17, false);
#line 54 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                             Write(postedJob.Vacancy);

#line default
#line hidden
                EndContext();
                BeginContext(1383, 170, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td style=\"padding-left:5px\">Job Title:</td>\r\n                    <td style=\"padding-left:20px\">");
                EndContext();
                BeginContext(1554, 17, false);
#line 59 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                             Write(postedJob.Job_Tit);

#line default
#line hidden
                EndContext();
                BeginContext(1571, 171, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td style=\"padding-left:5px\">Entry date:</td>\r\n                    <td style=\"padding-left:20px\">");
                EndContext();
                BeginContext(1743, 18, false);
#line 64 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                             Write(postedJob.Ent_date);

#line default
#line hidden
                EndContext();
                BeginContext(1761, 124, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n                \r\n\r\n                <tr>\r\n                    <td style=\"margin-left:100px\">");
                EndContext();
                BeginContext(1886, 128, false);
#line 70 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"
                                             Write(Html.ActionLink("Remove Post","removepost","Recruiter",routeValues:new PostedJob { JobId=postedJob.JobId,RecId=postedJob.RecId}));

#line default
#line hidden
                EndContext();
                BeginContext(2014, 60, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n\r\n\r\n\r\n            </table>\r\n");
                EndContext();
#line 77 "D:\Projects\JobSearch\Views\Recruiter\PostedJobs.cshtml"

             
            }

#line default
#line hidden
                BeginContext(2106, 29, true);
                WriteLiteral("        </font>\r\n    </div>\r\n");
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
            BeginContext(2142, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PostedJob>> Html { get; private set; }
    }
}
#pragma warning restore 1591
