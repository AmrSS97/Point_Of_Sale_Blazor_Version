// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace POS_UI.Pages.Supplier
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using POS_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\_Imports.razor"
using POS_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\SupplierList.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers")]
    public partial class SupplierList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\SupplierList.razor"
       

    private List<Supplier> Suppliers;
    private int Counter = 1;
    protected override async Task OnInitializedAsync()
    {
        Suppliers = await Http.GetFromJsonAsync<List<Supplier>>("http://localhost:5000/api/Supplier");
    }

    protected async Task DeleteSupplier(Supplier Supplier)
    {
        bool confirmed = await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete supplier ?"); // Confirm
        if (confirmed)
        {
            Suppliers.Remove(Supplier);
            await Http.DeleteAsync("http://localhost:5000/api/Supplier/" + Supplier.SupplierID);
        }
        return;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
