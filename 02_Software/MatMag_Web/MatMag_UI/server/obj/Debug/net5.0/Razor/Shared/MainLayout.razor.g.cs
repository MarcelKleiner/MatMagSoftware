#pragma checksum "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a435c394fb7cd72a03c11b99b6c829facca56c"
// <auto-generated/>
#pragma warning disable 1591
namespace MatMag.Shared
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
#line 3 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : MatMag.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row justify-content-start align-items-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-6 d-flex align-items-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(14);
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 14 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                __builder2.AddAttribute(18, "Text", "MatMag");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      <div class=\"col-6 text-right\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(21);
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(23);
                __builder2.AddAttribute(24, "Name", "main");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, 
#nullable restore
#line 27 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(27, (__value) => {
#nullable restore
#line 24 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(29);
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(31);
                __builder2.AddAttribute(32, "style", "height: 100%");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(34);
                    __builder3.AddAttribute(35, "Path", "home");
                    __builder3.AddAttribute(36, "Text", "Home");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(38);
                    __builder3.AddAttribute(39, "Path", "orders");
                    __builder3.AddAttribute(40, "Text", "Bestellungen");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                    __builder3.AddAttribute(43, "Path", "article");
                    __builder3.AddAttribute(44, "Text", "Artikel");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(46);
                    __builder3.AddAttribute(47, "Path", "box");
                    __builder3.AddAttribute(48, "Text", "Kisten");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(50);
                    __builder3.AddAttribute(51, "Path", "address");
                    __builder3.AddAttribute(52, "Text", "Adressen");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(54);
                    __builder3.AddAttribute(55, "Path", "invoice");
                    __builder3.AddAttribute(56, "Text", "Rechnungen");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(58);
                    __builder3.AddAttribute(59, "Path", "help");
                    __builder3.AddAttribute(60, "Text", "Hilfe");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(62);
                    __builder3.AddAttribute(63, "Path", "users");
                    __builder3.AddAttribute(64, "Text", "Benutzer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(66);
                    __builder3.AddAttribute(67, "Path", "settings");
                    __builder3.AddAttribute(68, "Text", "Einstellungen");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(69, (__value) => {
#nullable restore
#line 31 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(71);
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(73);
                __builder2.AddAttribute(74, "Text", "MatMag, Copyright Ⓒ 2021");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
