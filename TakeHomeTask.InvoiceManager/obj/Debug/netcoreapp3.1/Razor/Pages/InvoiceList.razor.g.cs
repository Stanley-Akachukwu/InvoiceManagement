#pragma checksum "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef3158b26d165b01823a52c5c06e58db371570a"
// <auto-generated/>
#pragma warning disable 1591
namespace TakeHomeTask.InvoiceManager.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/InvoiceList")]
    public partial class InvoiceList : InvoiceListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
 if (Invoices == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 9 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 13 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
         foreach (var invoice in Invoices)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TakeHomeTask.InvoiceManager.Pages.DisplayInvoice>(3);
            __builder.AddAttribute(4, "Invoice", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TakeHome.WebAPI.Data.Entities.Invoice>(
#nullable restore
#line 15 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
                                     invoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnInvoiceDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Guid>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Guid>(this, 
#nullable restore
#line 16 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
                                               InvoiceDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\InvoiceList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
