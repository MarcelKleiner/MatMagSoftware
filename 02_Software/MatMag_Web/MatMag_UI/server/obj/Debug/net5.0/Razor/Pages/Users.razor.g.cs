#pragma checksum "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2da4238b762246c897e9c72f3caa1a1e2e8d975"
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
#line 5 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Users.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Users.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : MatMag.Pages.UsersComponent
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
                __builder2.AddAttribute(6, "class", "col-xl-3 col-lg-3 col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "Text", "Name*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(12);
                __builder2.AddAttribute(13, "Name", "Textbox0");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n      ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-2 col-lg-2 col-xl-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                __builder2.AddAttribute(18, "Text", "Rechte");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<dynamic>>(22);
                __builder2.AddAttribute(23, "Name", "Dropdown0");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-xl-3 col-lg-3 col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(29);
                __builder2.AddAttribute(30, "Text", "Vorname*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                __builder2.AddAttribute(35, "Name", "Textbox1");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-3 col-xl-3 col-lg-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                __builder2.AddAttribute(42, "Text", "E-Mail*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n      ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(46);
                __builder2.AddAttribute(47, "Name", "Textbox2");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-xl-3 col-lg-3 col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                __builder2.AddAttribute(54, "Text", "Passwort*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n      ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(58);
                __builder2.AddAttribute(59, "Name", "Textbox3");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "row");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-md-3 col-lg-3 col-xl-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(65);
                __builder2.AddAttribute(66, "Text", "Passwort bestätigen*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n      ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(70);
                __builder2.AddAttribute(71, "Name", "Textbox4");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "row");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(77);
                __builder2.AddAttribute(78, "style", "background-color: #4541ff");
                __builder2.AddAttribute(79, "Text", "Hinzufügen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n      ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(83);
                __builder2.AddAttribute(84, "style", "background-color: #4541ff");
                __builder2.AddAttribute(85, "Text", "Abbrechen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "row");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<dynamic>>(91);
                __builder2.AddComponentReferenceCapture(92, (__value) => {
#nullable restore
#line 79 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Users.razor"
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
