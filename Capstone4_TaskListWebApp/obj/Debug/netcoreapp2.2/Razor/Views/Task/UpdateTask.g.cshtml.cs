#pragma checksum "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8b40e079c803541294ce90e451e476ec86e099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_UpdateTask), @"mvc.1.0.view", @"/Views/Task/UpdateTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/UpdateTask.cshtml", typeof(AspNetCore.Views_Task_UpdateTask))]
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
#line 1 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\_ViewImports.cshtml"
using Capstone4_TaskListWebApp;

#line default
#line hidden
#line 2 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\_ViewImports.cshtml"
using Capstone4_TaskListWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8b40e079c803541294ce90e451e476ec86e099", @"/Views/Task/UpdateTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166523a09510f905fd26384437c16348e1904756", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_UpdateTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone4_TaskListWebApp.Models.Tasks>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Yes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "No", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Task/UpdateTask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
  
    ViewData["Title"] = "UpdateTask";

#line default
#line hidden
            BeginContext(48, 24, true);
            WriteLiteral("\r\n<h1>Update Task</h1>\r\n");
            EndContext();
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(120, 625, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b40e079c803541294ce90e451e476ec86e0995345", async() => {
                BeginContext(166, 42, true);
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 208, "\"", 229, 1);
#line 11 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 216, Model.UserId, 216, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(230, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"TaskId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 273, "\"", 294, 1);
#line 12 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 281, Model.TaskId, 281, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(295, 48, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Description\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 343, "\"", 369, 1);
#line 13 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 351, Model.Description, 351, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(370, 44, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"DueDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 414, "\"", 436, 1);
#line 14 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 422, Model.DueDate, 422, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(437, 22, true);
                WriteLiteral(" />\r\n\r\n\r\n    <p>Task: ");
                EndContext();
                BeginContext(460, 17, false);
#line 17 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
        Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(477, 22, true);
                WriteLiteral("  </p> \r\n    <p>Task: ");
                EndContext();
                BeginContext(500, 33, false);
#line 18 "C:\Users\Deno\Documents\Grand Circus\capstone\Capstone4_TaskListWebApp\Capstone4_TaskListWebApp\Views\Task\UpdateTask.cshtml"
        Write(Model.DueDate.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(533, 53, true);
                WriteLiteral("  </p> \r\n\r\n    <select name=\"Complete\">\r\n            ");
                EndContext();
                BeginContext(586, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b40e079c803541294ce90e451e476ec86e0998679", async() => {
                    BeginContext(606, 3, true);
                    WriteLiteral("Yes");
                    EndContext();
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
                EndContext();
                BeginContext(618, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(632, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8b40e079c803541294ce90e451e476ec86e09910150", async() => {
                    BeginContext(651, 2, true);
                    WriteLiteral("No");
                    EndContext();
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
                EndContext();
                BeginContext(662, 76, true);
                WriteLiteral("\r\n        </select>\r\n\r\n\r\n\r\n    <input type=\"submit\" value=\"Update Task\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(745, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone4_TaskListWebApp.Models.Tasks> Html { get; private set; }
    }
}
#pragma warning restore 1591