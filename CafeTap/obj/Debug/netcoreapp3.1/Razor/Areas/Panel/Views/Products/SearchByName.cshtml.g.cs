#pragma checksum "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_Products_SearchByName), @"mvc.1.0.view", @"/Areas/Panel/Views/Products/SearchByName.cshtml")]
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
#line 4 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Infrastructure.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer.Localisation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec", @"/Areas/Panel/Views/Products/SearchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec660172a495f6b0e945585a2f1953fdc4cd613", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_Products_SearchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Pagination.PaginatedList<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Product list";
    ViewData["MainTitle"] = "Products";
    ViewData["SubTitle"] = "List";
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    int counter = 1;
    int modalCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"mb-3\">Website search results</h5>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec7997", async() => {
                WriteLiteral(@"
            <div class=""input-group mb-3"">
                <div class=""form-group-feedback form-group-feedback-left"">
                    <input type=""text"" name=""name"" class=""form-control form-control-lg"" placeholder=""Search"">
                    <div class=""form-control-feedback form-control-feedback-lg"">
                        <i class=""icon-search4 text-muted""></i>
                    </div>
                </div>

                <div class=""input-group-append"">
                    <button type=""submit"" class=""btn btn-primary btn-lg"">Search</button>
                </div>
            </div>

            <div class=""d-md-flex align-items-md-center flex-md-wrap text-center text-md-left"">
                <ul class=""list-inline list-inline-condensed mb-0"">
                    <li class=""list-inline-item dropdown"">
                        <a href=""#"" class=""btn btn-link text-default dropdown-toggle"" data-toggle=""dropdown"">
                            <i class=""icon-stack2 mr-2""></i>
     ");
                WriteLiteral("                       Actions\r\n                        </a>\r\n\r\n                        <div class=\"dropdown-menu\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec9502", async() => {
                    WriteLiteral("<i class=\"icon-add\"></i> Add Restaurant");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <a href=""#"" class=""dropdown-item""><i class=""icon-accessibility""></i> Registration</a>
                            <a href=""#"" class=""dropdown-item""><i class=""icon-reading""></i> General info</a>
                            <a href=""#"" class=""dropdown-item""><i class=""icon-gear""></i> Your settings</a>
                            <a href=""#"" class=""dropdown-item""><i class=""icon-graduation""></i> Copyrights</a>
                            <div class=""dropdown-divider""></div>
                            <a href=""#"" class=""dropdown-item""><i class=""icon-mail-read""></i> Contacting authors</a>
                        </div>
                    </li>
                    <li class=""list-inline-item""><a href=""#"" class=""btn btn-link text-default""><i class=""icon-reload-alt mr-2""></i> Refine your search</a></li>
                </ul>

                <ul class=""list-inline mb-0 ml-md-auto"">
                    <li class=""list-inline-item""><a href=""#"" class=""btn btn-link text-default"">");
                WriteLiteral(@"<i class=""icon-make-group mr-2""></i> Browse articles</a></li>
                    <li class=""list-inline-item""><a href=""#"" class=""btn btn-link text-default""><i class=""icon-menu7 mr-2""></i> Advanced search</a></li>
                </ul>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<!-- /search field -->
<!-- Bordered table -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Bordered table</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
    </div>

    <div class=""card-body"">
        The <code>DataTables</code> is a highly flexible tool, based upon the foundations of progressive enhancement, and will add advanced interaction controls to any HTML table. DataTables has most features enabled by default, so all you need to do to use it with your own tables is to call the construction function. Searching, ordering, paging etc goodness will be immediately added to the table, as shown in this example. <strong>Datatables support all a");
            WriteLiteral(@"vailable table styling.</strong>
    </div>

    <table class=""table datatable-basic table-bordered"">
        <thead>
            <tr>
                <th>No</th>
                <th>Name</th>
                <th>Monthly</th>
                <th>Yearly</th>
                <th>Contract Count</th>
                <th class=""text-center"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 92 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                 if (Model.Count != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 99 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 100 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 101 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                           Write(Model[i].MonthlyPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 102 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                           Write(Model[i].YearlyPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 103 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                           Write(Model[i].Contracts.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <div class=""list-icons"">
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                            <i class=""icon-menu9""></i>
                                        </a>

                                        <div class=""dropdown-menu dropdown-menu-right"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec18985", async() => {
                WriteLiteral("<i class=\"icon-pencil\"></i>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                                                               WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <a data-toggle=\"modal\" data-target=\"#modal_theme_danger-");
#nullable restore
#line 113 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                                                               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""dropdown-item""><i class=""icon-eraser3""></i>Delete</a>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 119 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<!-- /bordered table -->\r\n\r\n\r\n\r\n");
#nullable restore
#line 130 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 6342, "\"", 6379, 2);
            WriteAttributeValue("", 6347, "modal_theme_danger-", 6347, 19, true);
#nullable restore
#line 132 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
WriteAttributeValue("", 6366, modalCounter, 6366, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade\" tabindex=\"-1\">\r\n");
#nullable restore
#line 133 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
          
            modalCounter += 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header bg-danger\">\r\n                    <h6 class=\"modal-title\">Deleting position ");
#nullable restore
#line 139 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                         Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>

                <div class=""modal-body"">
                    <h6 class=""font-weight-semibold"">Important Note!!!</h6>
                    <p>You are about to delete role : ");
#nullable restore
#line 145 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@". You can not delete this position as long as you have users who posses this role. If you want to delete this role you have to remove all users from this role first. </p>

                    <hr>

                    <h6 class=""font-weight-semibold"">Related data information</h6>
                    <p>Will add related data to this part later</p>
                </div>

                <div class=""modal-footer"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcda4d1c62c87ed5a186f01f505cc8aeeed4c1ec25379", async() => {
                WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-link\" data-dismiss=\"modal\">Close</button>\r\n                        <button type=\"submit\" class=\"btn bg-danger\">Delete</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                                                           WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 162 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<ul class=\"pagination align-self-end\">\r\n    <li");
            BeginWriteAttribute("class", " class=\"", 7892, "\"", 7923, 2);
            WriteAttributeValue("", 7900, "page-item", 7900, 9, true);
#nullable restore
#line 166 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
WriteAttributeValue(" ", 7909, prevDisabled, 7910, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\" class=\"page-link\">&larr; &nbsp; Prev</a></li>\r\n");
#nullable restore
#line 167 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
     for (int i = 1; i <= Model.TotalPages; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n");
#nullable restore
#line 170 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
             if (i != Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\"><a href=\"#\" class=\"page-link\">");
#nullable restore
#line 172 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 173 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\"><a href=\"#\" class=\"page-link\">");
#nullable restore
#line 176 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 177 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n");
#nullable restore
#line 179 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 8364, "\"", 8395, 2);
            WriteAttributeValue("", 8372, "page-item", 8372, 9, true);
#nullable restore
#line 180 "D:\PrivetProjects\CafeTap\CafeTap\Areas\Panel\Views\Products\SearchByName.cshtml"
WriteAttributeValue(" ", 8381, nextDisabled, 8382, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\" class=\"page-link\">Next &nbsp; &rarr;</a></li>\r\n</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AzCultureInfo AzCulture { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Pagination.PaginatedList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591