#pragma checksum "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Address.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680806af58cdca09d98d1d347ed6d4c9f8582111"
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
#line 5 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Address.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Address.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/address")]
    public partial class Address : MatMag.Pages.AddressComponent
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
                __builder2.AddAttribute(6, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "Text", "Anrede*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<dynamic>>(12);
                __builder2.AddAttribute(13, "Name", "Dropdown0");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(19);
                __builder2.AddAttribute(20, "Text", "Name*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n      ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                __builder2.AddAttribute(25, "Name", "Textbox0");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n      ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(29);
                __builder2.AddAttribute(30, "Text", "Organisation");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n      ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                __builder2.AddAttribute(35, "Name", "Textbox3");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                __builder2.AddAttribute(42, "Text", "Vorname*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n      ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(46);
                __builder2.AddAttribute(47, "Name", "Textbox1");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n      ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(51);
                __builder2.AddAttribute(52, "Text", "PLZ");
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
                __builder2.AddAttribute(62, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(63);
                __builder2.AddAttribute(64, "Text", "E-Mail");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n      ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(68);
                __builder2.AddAttribute(69, "Name", "Textbox2");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n      ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(73);
                __builder2.AddAttribute(74, "Text", "Ort");
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
                __builder2.AddAttribute(84, "class", "col-md-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(85);
                __builder2.AddAttribute(86, "Text", "Telefon Nr.");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n      ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(90);
                __builder2.AddAttribute(91, "Name", "Textbox6");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(97);
                __builder2.AddAttribute(98, "style", "background-color: #4541ff");
                __builder2.AddAttribute(99, "Text", "Hinzufügen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n      ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(103);
                __builder2.AddAttribute(104, "style", "background-color: #4541ff");
                __builder2.AddAttribute(105, "Text", "Abbrechen");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\n    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "row");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<dynamic>>(111);
                __builder2.AddComponentReferenceCapture(112, (__value) => {
#nullable restore
#line 95 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Address.razor"
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