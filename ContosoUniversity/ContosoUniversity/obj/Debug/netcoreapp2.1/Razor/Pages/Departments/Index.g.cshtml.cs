#pragma checksum "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31120b3361c2547a47523d3ecee2d92bb300a303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Departments.Pages_Departments_Index), @"mvc.1.0.razor-page", @"/Pages/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Departments/Index.cshtml", typeof(ContosoUniversity.Pages.Departments.Pages_Departments_Index), null)]
namespace ContosoUniversity.Pages.Departments
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31120b3361c2547a47523d3ecee2d92bb300a303", @"/Pages/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3d676151f6d39034ea3a39737612183bc36e14", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Departments_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
  
    ViewData["Title"] = "Departments";

#line default
#line hidden
            BeginContext(105, 31, true);
            WriteLiteral("\n<h2>Departments</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(136, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4480b767f2884103aa2ff8e1becd830c", async() => {
                BeginContext(157, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(171, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(258, 54, false);
#line 17 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(365, 56, false);
#line 20 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Budget));

#line default
#line hidden
            EndContext();
            BeginContext(421, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(474, 59, false);
#line 23 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(533, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(586, 63, false);
#line 26 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department[0].Administrator));

#line default
#line hidden
            EndContext();
            BeginContext(649, 142, true);
            WriteLiteral("\n            </th>\n            <th>\n                RowVersion\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 35 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
         foreach (var item in Model.Department)
        {

#line default
#line hidden
            BeginContext(849, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(908, 39, false);
#line 39 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(947, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1012, 41, false);
#line 42 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1118, 44, false);
#line 45 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1227, 57, false);
#line 48 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Administrator.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1349, 18, false);
#line 51 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
               Write(item.RowVersion[7]);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1431, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65f137677f2f4fb69353e3607207d464", async() => {
                BeginContext(1486, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
                                           WriteLiteral(item.DepartmentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1494, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1517, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c5a75fb11a4a86a882a4fc1ffacf53", async() => {
                BeginContext(1575, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
                                              WriteLiteral(item.DepartmentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1586, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1609, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c15a0d7347442fe98b0c0e912077344", async() => {
                BeginContext(1666, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
                                             WriteLiteral(item.DepartmentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1676, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 59 "D:\university\Geri c#\ContosoUniversity-master\ContosoUniversity\ContosoUniversity\Pages\Departments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1727, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Pages.Departments.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Departments.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.Departments.IndexModel>)PageContext?.ViewData;
        public ContosoUniversity.Pages.Departments.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
