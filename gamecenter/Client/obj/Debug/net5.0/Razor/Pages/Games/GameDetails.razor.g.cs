#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd3b4166a5e12d389f0c20ed538447d6383b02d"
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
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Helpers.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Repository.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{GameId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{GameId:int}/{GameName}")]
    public partial class GameDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Loading");
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                        
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
         model.Game.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                            model.Game.ReleaseDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
    for (int i = 0; i < model.Genres.Count; i++)
    {
        if (i < model.Genres.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 16 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
             linkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ", ");
#nullable restore
#line 16 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                      
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, 
#nullable restore
#line 20 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
             linkGenre(model.Genres[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                       
        }

    }



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                        model.Game.ReleaseDate.Value.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "display: flex");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", "display: inline-block; margin-right: 5px");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 29 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                      model.Game.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "style", "width: 225px; height: 315px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "iframe");
            __builder.AddAttribute(21, "width", "560");
            __builder.AddAttribute(22, "height", "315");
            __builder.AddAttribute(23, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 31 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                        model.Game.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "title", "YouTube video player");
            __builder.AddAttribute(25, "frameborder", "0");
            __builder.AddAttribute(26, "allow", "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(27, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(31, "<h3>Summary</h3>\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.OpenComponent<gamecenter.Client.Shared.Components.MarkdownInput>(33);
            __builder.AddAttribute(34, "MarkdownContent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                         model.Game.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(38, "<h3>People in Game</h3>\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "display: flex; flex-direction: column");
#nullable restore
#line 47 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
         foreach(var person in model.PersonInGame)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "margin-bottom: 6px;");
            __builder.OpenElement(43, "img");
            __builder.AddAttribute(44, "style", "width: 50px;");
            __builder.AddAttribute(45, "src", 
#nullable restore
#line 50 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                person.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "style", "display:inline-block; width: 200px;");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", "/person/" + (
#nullable restore
#line 51 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                    person.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 51 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                               person.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 51 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                                                               person.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.AddMarkupContent(53, "<span style=\"display:inline-block; width: 45px;\">...</span>\r\n                ");
            __builder.OpenElement(54, "span");
            __builder.AddContent(55, 
#nullable restore
#line 53 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                       person.RoleInGame

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
      
    [Parameter] public int GameId { get; set; }
    [Parameter] public string GameName { get; set; }
    private RenderFragment<Genre> linkGenre = (genre) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(56, "a");
            __builder2.AddAttribute(57, "href", "games/search?genreId=" + (
#nullable restore
#line 62 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                        genre.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(58, 
#nullable restore
#line 62 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                                   genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 62 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameDetails.razor"
                                                                                                                 ;
    GameDetailDTO model;
    protected async override Task OnInitializedAsync()
    {
        model = await gameRepository.GetGameDetailDTO(GameId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameRepository gameRepository { get; set; }
    }
}
#pragma warning restore 1591
