#pragma checksum "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748725049a87b00681347b0c94f8c312bb05c6c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchResult), @"mvc.1.0.view", @"/Views/Search/SearchResult.cshtml")]
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
#line 1 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\_ViewImports.cshtml"
using KidActivityManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\_ViewImports.cshtml"
using KidActivityManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748725049a87b00681347b0c94f8c312bb05c6c2", @"/Views/Search/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bc5e3bf62c71b394e1c396677d0725c51ab875", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KidActivityManagement.ViewModels.SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ChildId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "StartTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "IsOnline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Activity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Search Result: </h1>\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c26402", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
     if (Model.ChildIds != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         for (int i = 0; i < Model.ChildIds.Length; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(Html.HiddenFor(model => Model.ChildIds[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
                                                       
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
     if (Model.StatusList != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         for (int i = 0; i < Model.StatusList.Length; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(Html.HiddenFor(model => Model.StatusList[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
                                                         
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 27 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
Write(Html.HiddenFor(model => Model.StartTimeChoice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
Write(Html.HiddenFor(model => Model.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
Write(Html.HiddenFor(model => Model.EndTimeChoice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
Write(Html.HiddenFor(model => Model.EndTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
Write(Html.HiddenFor(model => Model.Online));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>\r\n        <label for=\"SortItem\">Sort by: </label>\r\n        <select name=\"SortItem\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c210729", async() => {
                    WriteLiteral("Child");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c211964", async() => {
                    WriteLiteral("Time");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c213198", async() => {
                    WriteLiteral("Virtual?");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c214436", async() => {
                    WriteLiteral("Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n    </div>\r\n    <br />\r\n    <input type=\"submit\" value=\"Sort\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n\r\n");
#nullable restore
#line 49 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
 if (Model.ChildActivities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No result founded.</p>\r\n");
#nullable restore
#line 52 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <th>Child</th>
            <th>Activity</th>
            <th>Start Time</th>
            <th>End Time</th>
            <th>Virual?</th>
            <th>Status</th>
            <th>Detail</th>
        </tr>
");
#nullable restore
#line 65 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         foreach (var ca in Model.ChildActivities)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 68 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(ca.Child.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 69 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(ca.Activity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 70 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(ca.Activity.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 71 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
       Write(ca.Activity.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 73 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         if (@ca.Activity.IsOnline == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Yes</td>\r\n");
#nullable restore
#line 76 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }
        else if (@ca.Activity.IsOnline == false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>No</td>\r\n");
#nullable restore
#line 80 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
         if (@ca.Status == "toDo")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>To Do</td>\r\n");
#nullable restore
#line 85 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }
        else if (@ca.Status == "inProgress")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>In Progress</td>\r\n");
#nullable restore
#line 89 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }
        else if (@ca.Status == "done")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Done</td>\r\n");
#nullable restore
#line 93 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748725049a87b00681347b0c94f8c312bb05c6c221637", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
                                                               WriteLiteral(ca.Activity.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 98 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 101 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Search\SearchResult.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KidActivityManagement.ViewModels.SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591