#pragma checksum "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\Shared\MyComponent\_TotalEarning.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57491d7a620473769cc585093afc29b8e33d785"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdminPanel.Shared.MyComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel.Models;

#line default
#line hidden
#nullable disable
    public partial class _TotalEarning : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card shadow border-left-success py-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row align-items-center no-gutters");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col mr-2");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"text-uppercase text-success font-weight-bold text-xs mb-1\"><span>Всего доход</span></div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "text-dark font-weight-bold h5 mb-0");
            __builder.OpenElement(15, "span");
            __builder.AddMarkupContent(16, "₽");
#nullable restore
#line 9 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\Shared\MyComponent\_TotalEarning.razor"
__builder.AddContent(17, earningsTable.TotalEarning);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<div class=\"col-auto\"><i class=\"fas fa-ruble-sign fa-2x text-gray-300\"></i></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\zxceb\Desktop\BlazorAdminPanel\BlazorAdminPanel\Shared\MyComponent\_TotalEarning.razor"
       

    [Parameter]
    public Models.EarningsTable earningsTable { get; set; }


    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            earningsTable.UpdateEvent += UpdateDB;
        }
    }


    public async void UpdateDB(object sender)
    {
        // Обновление компонента после посчета итогов.
        await InvokeAsync(() => StateHasChanged());
    }

    // Очистка перед удалением компонента
    public void Dispose()
    {
        earningsTable.UpdateEvent -= UpdateDB;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
