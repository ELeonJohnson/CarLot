#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4348f6a80da567ca5865b7cae79cbd633d910eb5"
// <auto-generated/>
#pragma warning disable 1591
namespace CarLot.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
using CarLot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./styles/NavMenuStyling.css\" rel=\"stylesheet\">\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<a class=\"navbar-brand\" href>CarLot</a>\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "navbar-toggler");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 16 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(27);
                __builder2.AddAttribute(28, "Icon", "home");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, " Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item px-3");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "buses");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(40);
                __builder2.AddAttribute(41, "Icon", "directions_bus");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, " Buses\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "cars");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(53);
                __builder2.AddAttribute(54, "Icon", "directions_car");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, " Cars\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "nav-item px-3");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "motorcycles");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(66);
                __builder2.AddAttribute(67, "Icon", "directions_bike");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, " Motorcycles\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "nav-item px-3");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
            __builder.AddAttribute(75, "class", "nav-link");
            __builder.AddAttribute(76, "href", "suvs");
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(79);
                __builder2.AddAttribute(80, "Icon", "airport_shuttle");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, " SUVs\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenElement(84, "li");
            __builder.AddAttribute(85, "class", "nav-item px-3");
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
            __builder.AddAttribute(88, "class", "nav-link");
            __builder.AddAttribute(89, "href", "trucks");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(92);
                __builder2.AddAttribute(93, "Icon", "local_shipping");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, " Trucks\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        <hr>\r\n\r\n");
#nullable restore
#line 50 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
         if (SignInManager.IsSignedIn(httpContextAccessor.HttpContext.User))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(98);
            __builder.AddAttribute(99, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(100, "\r\n                    ");
                __builder2.OpenElement(101, "li");
                __builder2.AddAttribute(102, "class", "nav-item px-3");
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(104);
                __builder2.AddAttribute(105, "class", "nav-link");
                __builder2.AddAttribute(106, "href", "Identity/Account/Manage/Index");
                __builder2.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n                            ");
                    __builder3.OpenComponent<MatBlazor.MatIcon>(109);
                    __builder3.AddAttribute(110, "Icon", "perm_identity");
                    __builder3.CloseComponent();
                    __builder3.AddContent(111, " ");
                    __builder3.AddContent(112, 
#nullable restore
#line 56 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
                                                                      httpContextAccessor.HttpContext.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(113, "!\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.OpenElement(116, "li");
                __builder2.AddAttribute(117, "class", "nav-item px-3");
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.OpenElement(119, "form");
                __builder2.AddAttribute(120, "class", "form-inline");
                __builder2.AddAttribute(121, "method", "post");
                __builder2.AddAttribute(122, "action", "Identity/Account/LogOut");
                __builder2.AddMarkupContent(123, "\r\n                            ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(124);
                __builder2.AddAttribute(125, "Icon", "exit_to_app");
                __builder2.CloseComponent();
                __builder2.AddContent(126, " ");
                __builder2.AddMarkupContent(127, "<button type=\"submit\" class=\"nav-link btn btn-link\">Logout</button>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(130, "\r\n");
#nullable restore
#line 66 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "            ");
            __builder.OpenElement(132, "li");
            __builder.AddAttribute(133, "class", "nav-item px-3");
            __builder.AddMarkupContent(134, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(135);
            __builder.AddAttribute(136, "class", "nav-link");
            __builder.AddAttribute(137, "href", "Identity/Account/Register");
            __builder.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(139, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(140);
                __builder2.AddAttribute(141, "Icon", "description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, " Register\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n            ");
            __builder.OpenElement(145, "li");
            __builder.AddAttribute(146, "class", "nav-item px-3");
            __builder.AddMarkupContent(147, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(148);
            __builder.AddAttribute(149, "class", "nav-link");
            __builder.AddAttribute(150, "href", "Identity/Account/Login");
            __builder.AddAttribute(151, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(152, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIcon>(153);
                __builder2.AddAttribute(154, "Icon", "account_box");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(155, " Login\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n");
#nullable restore
#line 79 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
