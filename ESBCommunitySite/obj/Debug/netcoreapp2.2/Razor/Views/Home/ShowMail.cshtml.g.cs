#pragma checksum "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "784b57fa750b9ea6adf7326bbb6af60dbc62b5b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowMail), @"mvc.1.0.view", @"/Views/Home/ShowMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowMail.cshtml", typeof(AspNetCore.Views_Home_ShowMail))]
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
#line 1 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/_ViewImports.cshtml"
using ESBCommunitySite;

#line default
#line hidden
#line 2 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/_ViewImports.cshtml"
using ESBCommunitySite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784b57fa750b9ea6adf7326bbb6af60dbc62b5b1", @"/Views/Home/ShowMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed60a2e532aef52573d7ccb64d093e975eeef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ESBCommunitySite.Models.ContactInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(81, 25, true);
            WriteLiteral("<! DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(106, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784b57fa750b9ea6adf7326bbb6af60dbc62b5b14549", async() => {
                BeginContext(112, 90, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>MailBox</title>\n    ");
                EndContext();
                BeginContext(202, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "784b57fa750b9ea6adf7326bbb6af60dbc62b5b15019", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(273, 1, true);
                WriteLiteral("\n");
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
            BeginContext(281, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(282, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784b57fa750b9ea6adf7326bbb6af60dbc62b5b17109", async() => {
                BeginContext(288, 292, true);
                WriteLiteral(@"
    <div class=""panel-body"">
        <h2>Mailbox</h2>
        <table class=""table table-lg table-striped table-bordered"">
            <thead>
                <tr>Recipient</tr>
                <tr>Message Content</tr>
                <tr>Sender</tr>
            </thead>
            <tbody>
");
                EndContext();
#line 24 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
                 foreach (ESBCommunitySite.Models.ContactInfo r in Model)
                {

#line default
#line hidden
                BeginContext(672, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(726, 11, false);
#line 27 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
                       Write(r.Recipient);

#line default
#line hidden
                EndContext();
                BeginContext(737, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(772, 13, false);
#line 28 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
                       Write(r.MessageText);

#line default
#line hidden
                EndContext();
                BeginContext(785, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(820, 8, false);
#line 29 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
                       Write(r.Sender);

#line default
#line hidden
                EndContext();
                BeginContext(828, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 31 "/Users/amylese/Documents/ASP.NET/ESBCommunitySiteLab2A/ESBCommunitySite/Views/Home/ShowMail.cshtml"
                }

#line default
#line hidden
                BeginContext(878, 49, true);
                WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
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
            BeginContext(934, 10, true);
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ESBCommunitySite.Models.ContactInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
