#pragma checksum "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Article.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44bc4c1aab3a081d60575934db1cf6519055d70f"
// <auto-generated/>
#pragma warning disable 1591
namespace MatMag.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\_Imports.razor"
using MatMag.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Article.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Article.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/article")]
    public partial class Article : MatMag.Pages.ArticleComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "Text", "Artikel Nr.");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(12);
                __builder2.AddAttribute(13, "Name", "Textbox0");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(19);
                __builder2.AddAttribute(20, "Text", "Bezeichnung");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n      ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                __builder2.AddAttribute(25, "Name", "Textbox1");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(29);
                __builder2.AddAttribute(30, "Text", "Alias");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                __builder2.AddAttribute(35, "Name", "Textbox6");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                __builder2.AddAttribute(42, "Text", "Preis int. K\n        ");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n      ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(46);
                __builder2.AddAttribute(47, "Name", "Textbox2");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n      ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(51);
                __builder2.AddAttribute(52, "Text", "Preis ext. K");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n      ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(56);
                __builder2.AddAttribute(57, "Name", "Textbox4");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "row");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(63);
                __builder2.AddAttribute(64, "Text", "Preis int. NK");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n      ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(68);
                __builder2.AddAttribute(69, "Name", "Textbox3");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n      ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(73);
                __builder2.AddAttribute(74, "Text", "Preis ext. NK");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n      ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(78);
                __builder2.AddAttribute(79, "Name", "Textbox5");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "row");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(85);
                __builder2.AddAttribute(86, "style", "background-color: #4541ff");
                __builder2.AddAttribute(87, "Text", "Hinzufügen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n      ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(91);
                __builder2.AddAttribute(92, "style", "background-color: #4541ff");
                __builder2.AddAttribute(93, "Text", "Abbrechen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\n    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "row");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<dynamic>>(99);
                __builder2.AddComponentReferenceCapture(100, (__value) => {
#nullable restore
#line 86 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Article.razor"
                              datagrid0 = (Radzen.Blazor.RadzenDataGrid<dynamic>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591