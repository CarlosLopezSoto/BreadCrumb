#pragma checksum "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a0ec08c18dcd60139b367dec46a0c3ebe5165c"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadCrumbBlazorBootstrap4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using BreadCrumbBlazorBootstrap4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\_Imports.razor"
using BreadCrumbBlazorBootstrap4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\Pages\Index.razor"
using BreadCrumbBlazorBootstrap4.BreadCrumb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\Pages\Index.razor"
using BreadCrumbBlazorBootstrap4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BreadCrumbBlazorBootstrap4.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<BreadCrumbBlazorBootstrap4.BreadCrumb.BreadCrumb>(4);
            __builder.AddAttribute(5, "breadCrumbData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BreadCrumbBlazorBootstrap4.Data.BreadCrumbData>>(
#nullable restore
#line 10 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\Pages\Index.razor"
                            breadCrumbDatas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Administrador\source\repos\BreadCrumbBlazorBootstrap4\BreadCrumbBlazorBootstrap4\Pages\Index.razor"
  
    public List<BreadCrumbData> breadCrumbDatas = new List<BreadCrumbData>();
    protected override void OnInitialized()
    {

        BreadCrumbData breadCrumbData = new BreadCrumbData
        {
            Text = "Counter",
            Url = "counter"
        };

        breadCrumbDatas.Add(breadCrumbData);


        breadCrumbData = new BreadCrumbData
        {
            Text = "Home",
            Url = "/"
        };

        breadCrumbDatas.Add(breadCrumbData);



    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
