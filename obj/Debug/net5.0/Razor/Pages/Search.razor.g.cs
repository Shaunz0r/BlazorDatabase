#pragma checksum "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df894f87b594880d7f99d8b7006f64a4b29e0f6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Database Search</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<label for=\"idSearch\">Staff ID </label>");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "id", "idSearch");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "min", "1");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\Pages\Search.razor"
                                                                                         searchStaffId

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchStaffId = __value, searchStaffId, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "<br><br>\r\n\r\n");
            __builder.AddMarkupContent(9, "<label for=\"nameSearch\">Name </label>");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "id", "nameSearch");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\Pages\Search.razor"
                                                                               searchName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchName = __value, searchName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<br><br>\r\n");
            __builder.AddMarkupContent(16, "<label for=\"departmentSearch\">Department </label>\r\n");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "id", "departmentSearch");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\Pages\Search.razor"
                                     searchDepartment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchDepartment = __value, searchDepartment));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "*");
            __builder.AddContent(23, "*");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\sph91\Desktop\Webdev\ap16test\BlazorApp\Pages\Search.razor"
       
    private int searchStaffId;
    private string searchName;
    private string searchDepartment;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
