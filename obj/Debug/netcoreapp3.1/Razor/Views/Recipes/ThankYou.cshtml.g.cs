#pragma checksum "C:\Agil SystemUtvecling med SCRUM KODEN\MyRecipe\MyRecipe\Views\Recipes\ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0279f160372c68ffce87f40c122653fe939dca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_ThankYou), @"mvc.1.0.view", @"/Views/Recipes/ThankYou.cshtml")]
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
#line 1 "C:\Agil SystemUtvecling med SCRUM KODEN\MyRecipe\MyRecipe\Views\_ViewImports.cshtml"
using MyRecipe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Agil SystemUtvecling med SCRUM KODEN\MyRecipe\MyRecipe\Views\_ViewImports.cshtml"
using MyRecipe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0279f160372c68ffce87f40c122653fe939dca2", @"/Views/Recipes/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3103289ba127d96dbcb3d4cd5866d1473dc5990", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyRecipe.Data.Entities.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Agil SystemUtvecling med SCRUM KODEN\MyRecipe\MyRecipe\Views\Recipes\ThankYou.cshtml"
  
    ViewData["Title"] = "Recipe submitted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thank you!</h1>\r\n\r\n<p>\r\n    Your recipe will be published shortly.\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyRecipe.Data.Entities.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
