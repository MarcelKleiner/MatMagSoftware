#pragma checksum "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5e2f834a31b3fb529cebce5c6e51035c9b76d3"
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
#line 5 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Settings.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marce\Documents\GitRepos\MatMag\02_Software\MatMag_Web\VS\server\Pages\Settings.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : MatMag.Pages.SettingsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Settings");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
