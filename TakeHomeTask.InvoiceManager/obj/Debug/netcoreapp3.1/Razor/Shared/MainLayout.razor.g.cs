#pragma checksum "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa51d09da1da376a886d8d71ffd56785634cbae"
// <auto-generated/>
#pragma warning disable 1591
namespace TakeHomeTask.InvoiceManager.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 4 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
                          ToastPosition.TopRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
                         6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 6 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
                          IconType.Material

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ErrorIcon", "error_outline");
            __builder.AddAttribute(5, "InfoIcon", "school");
            __builder.AddAttribute(6, "SuccessIcon", "done_outline");
            __builder.AddAttribute(7, "WarningIcon", "warning");
            __builder.AddAttribute(8, "ShowProgressBar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "sidebar");
            __builder.OpenComponent<TakeHomeTask.InvoiceManager.Shared.NavMenu>(12);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "main");
            __builder.AddMarkupContent(16, "<div class=\"top-row px-4\"></div>\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddContent(19, 
#nullable restore
#line 26 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591