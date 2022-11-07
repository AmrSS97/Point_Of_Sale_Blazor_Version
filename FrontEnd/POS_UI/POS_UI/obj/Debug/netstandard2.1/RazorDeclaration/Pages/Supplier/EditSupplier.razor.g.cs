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
#line 4 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\EditSupplier.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers/editsupplier/{SupplierID}")]
    public partial class EditSupplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\EditSupplier.razor"
       
    [Parameter]
    public string SupplierID { get; set; }
    private Supplier Supplier = new Supplier();

    protected override async Task OnInitializedAsync()
    {
        Supplier = await Http.GetFromJsonAsync<Supplier>("http://localhost:5000/api/Supplier/" + Guid.Parse(SupplierID));
    }
    private async void HandleValidSubmit()
    {
        // Process the valid form
        await Http.PutAsJsonAsync<Supplier>("http://localhost:5000/api/Supplier/" + Guid.Parse(SupplierID), Supplier);
        NavManager.NavigateTo("/suppliers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
