#pragma checksum "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76eac69020c85eb4a0157e2e0071cd69d1330b01"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers/createsupplier")]
    public partial class CreateSupplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
                  Supplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "center");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<div class=\"row\"><div class=\"col text-center\"><span class=\"oi oi-person\"></span></div></div>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "mb-3");
                __builder2.AddMarkupContent(12, "<label for=\"name\">Supplier Name:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "Enter supplier name");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
                                                                                                 Supplier.SupplierName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.SupplierName = __value, Supplier.SupplierName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.SupplierName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "mb-3");
                __builder2.AddMarkupContent(23, "<label for=\"name\">Supplier Email:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "name");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Enter supplier email");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
                                                                                                  Supplier.SupplierEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.SupplierEmail = __value, Supplier.SupplierEmail))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.SupplierEmail));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "mb-3");
                __builder2.AddMarkupContent(34, "<label for=\"name\">Supplier Phone:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "name");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "placeholder", "Enter supplier phone");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
                                                                                                  Supplier.SupplierPhone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Supplier.SupplierPhone = __value, Supplier.SupplierPhone))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Supplier.SupplierPhone));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.AddMarkupContent(43, "<div class=\"row\"><div class=\"col text-center\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Supplier\CreateSupplier.razor"
       
    private Supplier Supplier = new Supplier();
    private async void HandleValidSubmit()
    {
        // Process the valid form
        var Responce = await Http.PostAsJsonAsync<Supplier>("http://localhost:5000/api/Supplier", Supplier);
        if (Responce.StatusCode == System.Net.HttpStatusCode.OK)
        {
            NavManager.NavigateTo("/suppliers");
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("alert", "Supplier Already Exists !");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591