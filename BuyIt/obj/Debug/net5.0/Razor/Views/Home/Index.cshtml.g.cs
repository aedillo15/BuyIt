#pragma checksum "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87aa5d0cd38bf47118a509df3cedf59aef1b10de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\_ViewImports.cshtml"
using BuyIt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
using BuyIt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87aa5d0cd38bf47118a509df3cedf59aef1b10de", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f56a4c3848f07a5f966a26b923b57b08d24f901", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountViewModel.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section id=\"loginForm\">\r\n");
#nullable restore
#line 11 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
             using (Html.BeginForm("Dashboard", "Home", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Use a registered account to log in.</h4>\r\n                <hr />\r\n");
#nullable restore
#line 16 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Log In"" class=""btn btn-primary"" />
                    </div>
                </div>
                <p>
                    ");
#nullable restore
#line 37 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Register as a new user", "Registration"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 39 "C:\Users\Arzen Edillo\Desktop\BuyIt-Phase1\BuyIt\BuyIt\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountViewModel.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
