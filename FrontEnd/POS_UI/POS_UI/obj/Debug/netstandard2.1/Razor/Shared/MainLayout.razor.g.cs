#pragma checksum "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1242ee7d1c3058095cd7b1e087963369194b0bb0"
// <auto-generated/>
#pragma warning disable 1591
namespace POS_UI.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<POS_UI.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddMarkupContent(6, "<div class=\"top-row px-4\"></div>\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Shared\MainLayout.razor"
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