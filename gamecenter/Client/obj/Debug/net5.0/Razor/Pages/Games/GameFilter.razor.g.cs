#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f503cb5ec7fba7b251d246c974f7a80d5be48fa0"
// <auto-generated/>
#pragma warning disable 1591
namespace gamecenter.Client.Pages.Games
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Helpers.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/games/search")]
    public partial class GameFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search for Games</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-inline");
            __builder.AddMarkupContent(3, "<label for=\"title\" class=\"sr-only\">Title</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "id", "title");
            __builder.AddAttribute(8, "placeholder", "Game Title");
            __builder.AddAttribute(9, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                       (KeyboardEventArgs e) => TitleKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                     title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => title = __value, title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group mx-sm-3 mb-2");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                        selectedGenre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedGenre = __value, selectedGenre));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "0");
            __builder.AddContent(21, "Select a Genre");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
     foreach(var genre in Genres) 
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                        genre.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                   genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                         SearchForGames

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Filter");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.OpenComponent<gamecenter.Client.Shared.Components.GamesList>(38);
            __builder.AddAttribute(39, "Games", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<gamecenter.Shared.Models.Game>>(
#nullable restore
#line 24 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                  Games

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
      
    private List<Game> Games;
    string title = "";
    string selectedGenre = "0";
   
    private List<Genre> Genres = new List<Genre>() { new Genre() {Id = 1, Name = "Action"}, new Genre(){ Id = 2, Name = "Platform"}};
    
    protected override void OnInitialized()
    {
        Games = repository.GetGames();
    }
    
    private void SearchForGames() 
    {
        Games = repository.GetGames().Where(x => x.Title.Contains(title)).ToList();
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"selectedGenre: {selectedGenre}");      
    }

    private void Clear() 
    {
        Games = repository.GetGames();
        title = "";
        selectedGenre = "0"; 
    }

    private void TitleKeyPress(KeyboardEventArgs e) 
    {
        if(e.Key == "Enter")
        {
            //Implement here
            SearchForGames();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
