#pragma checksum "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a28407d72188b48f399c584b947602b1e3937dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Child_Index), @"mvc.1.0.view", @"/Views/Child/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a28407d72188b48f399c584b947602b1e3937dc", @"/Views/Child/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bc5e3bf62c71b394e1c396677d0725c51ab875", @"/Views/_ViewImports.cshtml")]
    public class Views_Child_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KidActivityManagement.Models.Child>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Child", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Children List</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No child yet.</p>\r\n");
#nullable restore
#line 14 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
}
else
{
    foreach (var child in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <Div>\r\n            <p style=\"font-size:40px; text-indent: 50px; font-weight: bold\">");
#nullable restore
#line 20 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
                                                                       Write(child.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p style=\"text-indent: 50px\">Gender: ");
#nullable restore
#line 21 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
                                            Write(child.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p style=\"text-indent: 50px\">Date of Birth: ");
#nullable restore
#line 22 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
                                                   Write(child.DOB.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n        </Div>\r\n");
#nullable restore
#line 25 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a28407d72188b48f399c584b947602b1e3937dc6076", async() => {
                WriteLiteral("Add a Child");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a28407d72188b48f399c584b947602b1e3937dc7698", async() => {
                WriteLiteral("Delete a Child");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\zhaoy\codecamp2020\KidActivityMangamentProject\KidActivityManagement\Views\Child\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KidActivityManagement.Models.Child>> Html { get; private set; }
    }
}
#pragma warning restore 1591