#pragma checksum "D:\PrivetProjects\CafeTap\CafeTap\Areas\Identity\Views\Register\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154875647c802fe13345f2830185b7b182e9b133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Register_Register), @"mvc.1.0.view", @"/Areas/Identity/Views/Register/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154875647c802fe13345f2830185b7b182e9b133", @"/Areas/Identity/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c993bbd582f4f9be86ee142d8a0bf10b568f55cf", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Identity\Views\Register\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154875647c802fe13345f2830185b7b182e9b1334188", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Limitless - Responsive Web Application Kit by Eugene Kopyov</title>

    <!-- Global stylesheets -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900"" rel=""stylesheet"" type=""text/css"">
    <link href=""../../../../global_assets/css/icons/icomoon/styles.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/bootstrap_limitless.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/layout.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/components.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/colors.min.css"" rel=""stylesheet"" type=""text/css"">
    <!-- /global stylesheets -->
    <!-- Core JS files -->
    <script src=""../..");
                WriteLiteral(@"/../../global_assets/js/main/jquery.min.js""></script>
    <script src=""../../../../global_assets/js/main/bootstrap.bundle.min.js""></script>
    <script src=""../../../../global_assets/js/plugins/loaders/blockui.min.js""></script>
    <!-- /core JS files -->
    <!-- Theme JS files -->
    <script src=""../../../../global_assets/js/plugins/forms/validation/validate.min.js""></script>
    <script src=""../../../../global_assets/js/plugins/forms/styling/uniform.min.js""></script>

    <script src=""assets/js/app.js""></script>
    <script src=""../../../../global_assets/js/demo_pages/login_validation.js""></script>
    <!-- /theme JS files -->

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154875647c802fe13345f2830185b7b182e9b1336933", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"modal-dialog modal-sm\">\r\n        <div class=\"modal-content\">\r\n\r\n            <!-- Form -->\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154875647c802fe13345f2830185b7b182e9b1337334", async() => {
                    WriteLiteral(@"
                <div class=""text-center mb-3"">
                    <i class=""icon-plus3 icon-2x text-success border-success border-3 rounded-round p-3 mb-3 mt-1""></i>
                    <h5 class=""mb-0"">Create account</h5>
                    <span class=""d-block text-muted"">All fields are required</span>
                </div>

                <div class=""form-group text-center text-muted content-divider"">
                    <span class=""px-2"">Your credentials</span>
                </div>

                <div class=""form-group form-group-feedback form-group-feedback-left"">
                    <input type=""text"" class=""form-control"" placeholder=""Username"">
                    <div class=""form-control-feedback"">
                        <i class=""icon-user-check text-muted""></i>
                    </div>
                    <span class=""form-text text-danger""><i class=""icon-cancel-circle2 mr-2""></i> This username is already taken</span>
                </div>

                <div class");
                    WriteLiteral(@"=""form-group form-group-feedback form-group-feedback-left"">
                    <input type=""password"" class=""form-control"" placeholder=""Password"">
                    <div class=""form-control-feedback"">
                        <i class=""icon-user-lock text-muted""></i>
                    </div>
                </div>

                <div class=""form-group text-center text-muted content-divider"">
                    <span class=""px-2"">Your contacts</span>
                </div>

                <div class=""form-group form-group-feedback form-group-feedback-left"">
                    <input type=""password"" class=""form-control"" placeholder=""Your email"">
                    <div class=""form-control-feedback"">
                        <i class=""icon-mention text-muted""></i>
                    </div>
                </div>

                <div class=""form-group form-group-feedback form-group-feedback-left"">
                    <input type=""password"" class=""form-control"" placeholder=""Repeat ema");
                    WriteLiteral(@"il"">
                    <div class=""form-control-feedback"">
                        <i class=""icon-mention text-muted""></i>
                    </div>
                </div>

                <div class=""form-group text-center text-muted content-divider"">
                    <span class=""px-2"">Additions</span>
                </div>

                <div class=""form-group"">
                    <div class=""form-check"">
                        <label class=""form-check-label"">
                            <input type=""checkbox"" name=""remember"" class=""form-input-styled"" checked data-fouc>
                            Send me <a href=""#"">test account settings</a>
                        </label>
                    </div>

                    <div class=""form-check"">
                        <label class=""form-check-label"">
                            <input type=""checkbox"" name=""remember"" class=""form-input-styled"" checked data-fouc>
                            Subscribe to monthly newsletter
  ");
                    WriteLiteral(@"                      </label>
                    </div>

                    <div class=""form-check"">
                        <label class=""form-check-label"">
                            <input type=""checkbox"" name=""remember"" class=""form-input-styled"" data-fouc>
                            Accept <a href=""#"">terms of service</a>
                        </label>
                    </div>
                </div>

                <button type=""submit"" class=""btn bg-teal-400 btn-block"">Register <i class=""icon-circle-right2 ml-2""></i></button>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <!-- /form -->\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591