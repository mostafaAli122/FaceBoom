#pragma checksum "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea67f016308c0c6ee869f02b5228b6be96d0f1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_Posted), @"mvc.1.0.view", @"/Views/HomePage/Posted.cshtml")]
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
#line 1 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\_ViewImports.cshtml"
using MiniFacebook.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea67f016308c0c6ee869f02b5228b6be96d0f1fb", @"/Views/HomePage/Posted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a2df16fbc5366d82a51025a405f15a86c2fc5", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_Posted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/download.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle img-fluid float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container mar-btm \">\r\n        <div class=\"row\">\r\n            <div class=\"card btm border-rad col-12 col-lg-8 offset-lg-2 shadows\">\r\n                <div class=\"card-header\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea67f016308c0c6ee869f02b5228b6be96d0f1fb6110", async() => {
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
            WriteLiteral("\r\n                    <div class=\"row d-inline-block\" style=\"margin-left:2px ;float:left;\">\r\n                        <a href=\"#\" class=\"usr-name\"><h6 class=\"col-12\">");
#nullable restore
#line 18 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                                                                   Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                                                                                        Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></a>\r\n                        <p class=\"col-12 \">");
#nullable restore
#line 19 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                                      Write(item.PostDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 21 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                      
                        if (item.UserID == (string)ViewData["UID"])
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-inline-block float-right\">\r\n                                <button");
            BeginWriteAttribute("id", " id=\"", 1014, "\"", 1038, 2);
            WriteAttributeValue("", 1019, "update_", 1019, 7, true);
#nullable restore
#line 25 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 1026, item.PostID, 1026, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"showupdatePost(this.id)\" class=\"btn btn-icon\"><i class=\"fa fa-edit\"></i></button>\r\n                                <button class=\"btn btn-icon\"");
            BeginWriteAttribute("id", " id=\"", 1192, "\"", 1216, 2);
            WriteAttributeValue("", 1197, "delete_", 1197, 7, true);
#nullable restore
#line 26 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 1204, item.PostID, 1204, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"deletePost(this.id)\"><i class=\"fa fa-window-close\"></i></button>\r\n                            </div>\r\n");
#nullable restore
#line 28 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"card-body\" style=\"border-bottom:1px lightgray solid\">\r\n                    <p class=\"card-text\"");
            BeginWriteAttribute("id", " id=\"", 1530, "\"", 1555, 2);
            WriteAttributeValue("", 1535, "content_", 1535, 8, true);
#nullable restore
#line 34 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 1543, item.PostID, 1543, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                                                              Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 35 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                      
                        if (@item.PostPhoto != null)    
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea67f016308c0c6ee869f02b5228b6be96d0f1fb11615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1723, "~/Images/", 1723, 9, true);
#nullable restore
#line 38 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
AddHtmlAttributeValue("", 1732, item.PostPhoto, 1732, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1778, "img_", 1778, 4, true);
#nullable restore
#line 38 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
AddHtmlAttributeValue("", 1782, item.PostID, 1782, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea67f016308c0c6ee869f02b5228b6be96d0f1fb14171", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1922, "~/Images/", 1922, 9, true);
#nullable restore
#line 42 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
AddHtmlAttributeValue("", 1931, item.PostPhoto, 1931, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1977, "img_", 1977, 4, true);
#nullable restore
#line 42 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
AddHtmlAttributeValue("", 1981, item.PostID, 1981, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <div>\r\n");
#nullable restore
#line 48 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                          
                            int flag = item.PostLikes.Where(p => p.UserID == (string)ViewData["UID"]).ToList().Count;

                            if (flag == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-light\"");
            BeginWriteAttribute("id", " id=\"", 2411, "\"", 2436, 2);
            WriteAttributeValue("", 2416, "Likebtn", 2416, 7, true);
#nullable restore
#line 53 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue(" ", 2423, item.PostID, 2424, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"Liked(this.id)\"><i class=\"fa fa-thumbs-up \"></i> Like</button>\r\n");
#nullable restore
#line 54 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-primary \"");
            BeginWriteAttribute("id", " id=\"", 2671, "\"", 2696, 2);
            WriteAttributeValue("", 2676, "Likebtn", 2676, 7, true);
#nullable restore
#line 57 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue(" ", 2683, item.PostID, 2684, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"Liked(this.id)\"><i class=\"fa fa-thumbs-up \"></i> Like</button>\r\n");
#nullable restore
#line 58 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-light\"");
            BeginWriteAttribute("id", " id=\"", 2882, "\"", 2912, 2);
            WriteAttributeValue("", 2887, "showComments_", 2887, 13, true);
#nullable restore
#line 60 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 2900, item.PostID, 2900, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"showComments(this.id)\"><i class=\"fa fa-comments\"></i> Comments</button>\r\n                        <button class=\"btn btn-icon \" style=\"float:right\"");
            BeginWriteAttribute("id", " id=\"", 3069, "\"", 3093, 2);
            WriteAttributeValue("", 3074, "nolike_", 3074, 7, true);
#nullable restore
#line 61 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 3081, item.PostID, 3081, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3094, "\"", 3127, 3);
            WriteAttributeValue("", 3104, "showLikes(", 3104, 10, true);
#nullable restore
#line 61 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 3114, item.PostID, 3114, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3126, ")", 3126, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
                                                                                                                                Write(item.PostLikes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Likes</button>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-body dis-none\"");
            BeginWriteAttribute("id", " id=\"", 3266, "\"", 3292, 2);
            WriteAttributeValue("", 3271, "comments_", 3271, 9, true);
#nullable restore
#line 64 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 3280, item.PostID, 3280, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <input type=\"text\" class=\"col-7 d-inline form-control\"");
            BeginWriteAttribute("id", " id=\"", 3370, "\"", 3402, 2);
            WriteAttributeValue("", 3375, "commentContent_", 3375, 15, true);
#nullable restore
#line 65 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 3390, item.PostID, 3390, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <button class=\"btn animated-button col-4 col-4 mb-1 ml-4 \"");
            BeginWriteAttribute("id", " id=\"", 3486, "\"", 3514, 2);
            WriteAttributeValue("", 3491, "addcomment_", 3491, 11, true);
#nullable restore
#line 66 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
WriteAttributeValue("", 3502, item.PostID, 3502, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"addComment(this.id)\">Comment</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 71 "E:\Mohamed\ITI\26.MVC\Project\GitProject\FaceBoom\MiniFacebook\MiniFacebook\Views\HomePage\Posted.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
