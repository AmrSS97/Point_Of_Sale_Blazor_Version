#pragma checksum "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fd0e99311aef43c71b33c332544532bfa50f71"
// <auto-generated/>
#pragma warning disable 1591
namespace POS_UI.Pages.Bill
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
#line 5 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createbill")]
    public partial class CreateBill : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table text-center border");
            __builder.AddMarkupContent(8, "<thead class=\"table-head\"><tr><th>Product</th>\r\n                        <th>Quantity</th>\r\n                        <th>Total</th>\r\n                        <th>Actions</th></tr></thead>\r\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 19 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                     foreach (var Item in Bill.ItemDtoList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 23 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Item.ItemQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                  Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Price*Item.ItemQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " E£");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-success");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                                          () => IncrementItemQuantity(Item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<span class=\"oi oi-plus\"></span>");
            __builder.CloseElement();
            __builder.AddContent(26, " ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                                                                                                                                                                     () => DecrementItemQuantity(Item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<span class=\"oi oi-minus\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<td class=\"text-left\">Total Amount</td>\r\n                        <td></td>\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 31 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                             TotalAmount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, " E£");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        <td></td>");
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                     foreach (var Discount in Discounts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "text-left");
            __builder.AddContent(40, 
#nullable restore
#line 37 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                   Discount.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " discount");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            <td></td>\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, "(");
            __builder.AddContent(45, 
#nullable restore
#line 39 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                  Discount.DiscountAmount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, ") E£");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            <td></td>");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "<td class=\"text-left\">Amount Due</td>\r\n                        <td></td>\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 46 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                             GetAmountDue()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, " E£");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        <td></td>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            <br>\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col text-center");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                              () => PostBill()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<span class=\"oi oi-print\"></span>&nbsp;Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col");
            __builder.OpenElement(66, "table");
            __builder.AddAttribute(67, "class", "table text-center border");
            __builder.AddMarkupContent(68, "<thead class=\"table-head\"><tr><th>Product</th>\r\n                        <th>Discount</th>\r\n                        <th>Price</th>\r\n                        <th>Stock</th>\r\n                        <th>Actions</th></tr></thead>\r\n                ");
            __builder.OpenElement(69, "tbody");
#nullable restore
#line 70 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                     foreach (var Product in Products)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "tr");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 73 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 74 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Product.DiscountPercentage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 75 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, " E£");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 76 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                 Product.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-outline-success");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                                                  () => AddToItemList(Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "ADD TO CART");
            __builder.CloseElement();
            __builder.AddContent(90, " ");
            __builder.AddMarkupContent(91, "<button class=\"btn btn-info\">i</button>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.AddMarkupContent(93, "<h3>Customer Details:&nbsp;<a href=\"/customers/createcustomer\" class=\"btn btn-success\"><span class=\"oi oi-plus\"></span>&nbsp;New Customer</a></h3>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(94);
            __builder.AddAttribute(95, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 83 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                              Bill

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "sm-padding");
                __builder2.AddMarkupContent(99, "<label for=\"name\">Customer Name:</label>\r\n                ");
                __Blazor.POS_UI.Pages.Bill.CreateBill.TypeInference.CreateInputSelect_0(__builder2, 100, 101, "form-control", 102, 
#nullable restore
#line 86 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                               Bill.CustomerName

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Bill.CustomerName = __value, Bill.CustomerName)), 104, () => Bill.CustomerName, 105, (__builder3) => {
                    __builder3.AddMarkupContent(106, "<option value>Select customer ...</option>");
#nullable restore
#line 88 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                     foreach (var Customer in Customers)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(107, "option");
                    __builder3.AddAttribute(108, "value", 
#nullable restore
#line 90 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                        Customer.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(109, 
#nullable restore
#line 90 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                            Customer.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 91 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n        ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "sm-padding");
                __builder2.AddMarkupContent(113, "<label for=\"name\">Payment:</label>\r\n            ");
                __Blazor.POS_UI.Pages.Bill.CreateBill.TypeInference.CreateInputSelect_1(__builder2, 114, 115, "form-control", 116, 
#nullable restore
#line 96 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
                                                           Bill.PaymentType

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Bill.PaymentType = __value, Bill.PaymentType)), 118, () => Bill.PaymentType, 119, (__builder3) => {
                    __builder3.AddMarkupContent(120, "<option value>Select payment type...</option>\r\n                ");
                    __builder3.AddMarkupContent(121, "<option value=\"Cash\">Cash</option>\r\n                ");
                    __builder3.AddMarkupContent(122, "<option value=\"Debit/Credit\">Debit/Credit</option>");
                }
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\AmrSherief\Desktop\PointOfSale\Project\FrontEnd\POS_UI\POS_UI\Pages\Bill\CreateBill.razor"
       
    private List<Product> Products = new List<Product>();
    private List<Discount> Discounts = new List<Discount>();
    private List<Customer> Customers = new List<Customer>();
    private Bill Bill = new Bill();
    private double TotalAmount = 0;
    private double TotalDiscount = 0;
    private bool IsValid;
    protected override async Task OnInitializedAsync()
    {
        Bill.ItemDtoList = new List<Item>();
        Products = await Http.GetFromJsonAsync<List<Product>>("http://localhost:5000/api/Product");
        Customers = await Http.GetFromJsonAsync<List<Customer>>("http://localhost:5000/api/Customer");
    }
    private async Task AddToItemList(Product Product)
    {
        Item CheckItem = Bill.ItemDtoList.Where(i => i.ProductName == Product.ProductName).FirstOrDefault();
        if (CheckItem == null)
        {
            Item Item = new Item();
            Item.ProductName = Product.ProductName;
            Item.ItemQuantity = 1;
            await DecrementProductStock(Item);
            if (IsValid)
            {
                Discount Discount = new Discount();
                Bill.ItemDtoList.Add(Item);
                Discount.ProductName = Item.ProductName;
                Discount.DiscountAmount = Product.Price * Product.DiscountPercentage * 0.01;
                Discounts.Add(Discount);
                TotalAmount += Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Price;

            }
        }
        else
        {
            await DecrementProductStock(CheckItem);
            if (IsValid)
            {
                Bill.ItemDtoList.Where(i => i.ProductName == Product.ProductName).FirstOrDefault().ItemQuantity++;
                TotalAmount += Products.Where(p => p.ProductName == CheckItem.ProductName).FirstOrDefault().Price;
                Discounts.Where(d => d.ProductName == Product.ProductName).FirstOrDefault().DiscountAmount *= 2;
            }
        }
    }
    private async Task IncrementItemQuantity(Item Item)
    {
        await DecrementProductStock(Item);
        if (IsValid)
        {
            Bill.ItemDtoList.Where(i => i.ProductName == Item.ProductName).FirstOrDefault().ItemQuantity++;
            TotalAmount += Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Price;
            Discounts.Where(d => d.ProductName == Item.ProductName).FirstOrDefault().DiscountAmount *= 2;
        }
    }
    private void DecrementItemQuantity(Item Item)
    {
        int value = --Bill.ItemDtoList.Where(i => i.ProductName == Item.ProductName).FirstOrDefault().ItemQuantity;
        TotalAmount -= Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Price;
        IncrementProductStock(Item);
        if (value < 1)
        {
            Bill.ItemDtoList.Remove(Item);
            Discount Discount = Discounts.Where(d => d.ProductName == Item.ProductName).FirstOrDefault();
            Discounts.Remove(Discount);
        }
        else
        {
            Discounts.Where(d => d.ProductName == Item.ProductName).FirstOrDefault().DiscountAmount /= 2;
        }
    }
    private void IncrementProductStock(Item Item)
    {
        Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Stock++;
    }
    private async Task DecrementProductStock(Item Item)
    {
        int StockValue = Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Stock;
        if (StockValue > 0)
        {
            Products.Where(p => p.ProductName == Item.ProductName).FirstOrDefault().Stock--;
            IsValid = true;
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("alert", "Product Out Of Stock !");
            IsValid = false;
        }
    }
    private double GetAmountDue()
    {
        TotalDiscount = 0;
        foreach (var Discount in Discounts)
        {
            TotalDiscount += Discount.DiscountAmount;
        }
        return TotalAmount - TotalDiscount;
    }

    private async Task PostBill()
    {
        Bill.TotalValue = GetAmountDue();
        Bill.UserName = "admin";
        Bill.CustomerPhone = Customers.Where(c => c.FullName == Bill.CustomerName).FirstOrDefault().CustomerPhone;
        Bill.BillDate = DateTime.Now;
        await Http.PostAsJsonAsync<Bill>("http://localhost:5000/api/Bill", Bill);
        NavManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.POS_UI.Pages.Bill.CreateBill
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
