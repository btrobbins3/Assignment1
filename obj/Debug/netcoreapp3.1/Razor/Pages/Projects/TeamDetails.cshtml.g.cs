#pragma checksum "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99216f6884415f85b39c9e8ed4b52c8fd9ecca62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assignment1.Pages.Projects.Pages_Projects_TeamDetails), @"mvc.1.0.razor-page", @"/Pages/Projects/TeamDetails.cshtml")]
namespace Assignment1.Pages.Projects
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
#line 1 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99216f6884415f85b39c9e8ed4b52c8fd9ecca62", @"/Pages/Projects/TeamDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a41edb68da02e3c43cbae3bc7bdaadfced22b6d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects_TeamDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
  
    ViewData["Title"] = "Team Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Team Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Team.teamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
       Write(Html.DisplayFor(model => model.Team.teamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 19 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
         foreach(var m in Model.Team.Members)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Member\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
           Write(Html.DisplayFor(model => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 27 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
         foreach(var p in Model.Team.Projects)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Project\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
           Write(Html.DisplayFor(model => p.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 36 "C:\Users\brobbins\OneDrive - wtamu.edu\Documents\College\Fall 2020\CIDM-4390\Assignment 1\Assignment1\Pages\Projects\TeamDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99216f6884415f85b39c9e8ed4b52c8fd9ecca626559", async() => {
                WriteLiteral("Back to Teams");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment1.Pages.Projects.TeamDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment1.Pages.Projects.TeamDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment1.Pages.Projects.TeamDetailsModel>)PageContext?.ViewData;
        public Assignment1.Pages.Projects.TeamDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
