#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "950b4e658bdfa2770803098056a3de5b1f103195"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/games/search")]
    public partial class GameFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search for Games</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                 gameFilterDto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-inline");
                __builder2.AddMarkupContent(6, "<label for=\"title\" class=\"sr-only\">Title</label>\r\n    ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "type", "text");
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "id", "title");
                __builder2.AddAttribute(11, "placeholder", "Game Title");
                __builder2.AddAttribute(12, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                                     (KeyboardEventArgs e) => TitleKeyPress(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                     gameFilterDto.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameFilterDto.Title = __value, gameFilterDto.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(18, "select");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                        gameFilterDto.GenreId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameFilterDto.GenreId = __value, gameFilterDto.GenreId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(22, "option");
                __builder2.AddAttribute(23, "value", "0");
                __builder2.AddContent(24, "Select a Genre");
                __builder2.CloseElement();
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
     foreach(var genre in Genres) 
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", 
#nullable restore
#line 17 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                        genre.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, 
#nullable restore
#line 17 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                   genre.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 18 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "checkbox");
                __builder2.AddAttribute(33, "class", "form-check-input");
                __builder2.AddAttribute(34, "id", "newlyReleases");
                __builder2.AddAttribute(35, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                                  gameFilterDto.NewlyReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameFilterDto.NewlyReleases = __value, gameFilterDto.NewlyReleases));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.AddMarkupContent(38, "<label class=\"form-check-label\" for=\"newlyReleases\">\r\n            Newly Releases\r\n        </label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "checkbox");
                __builder2.AddAttribute(44, "class", "form-check-input");
                __builder2.AddAttribute(45, "id", "upcomingReleases");
                __builder2.AddAttribute(46, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                                     gameFilterDto.UpcomingReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameFilterDto.UpcomingReleases = __value, gameFilterDto.UpcomingReleases));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<label class=\"form-check-label\" for=\"upcomingReleases\">\r\n            Upcoming Releases\r\n        </label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "class", "btn btn-primary mb-2 mx-sm-3");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                         SearchForGames

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Filter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "button");
                __builder2.AddAttribute(58, "type", "button");
                __builder2.AddAttribute(59, "class", "btn btn-danger mb-2");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(61, "Clear");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenComponent<gamecenter.Client.Shared.Components.GamesList>(63);
            __builder.AddAttribute(64, "Games", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<gamecenter.Shared.Models.Game>>(
#nullable restore
#line 37 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                  Games

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.OpenComponent<gamecenter.Client.Shared.Components.Page>(66);
            __builder.AddAttribute(67, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                   gameFilterDto.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "AmountOfPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                      amountOfPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 38 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
                                                                                   SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameFilter.razor"
      
    private List<Game> Games;
    private GameFilterDTO gameFilterDto = new GameFilterDTO();
    private int amountOfPages;
    private List<Genre> Genres = new List<Genre>();
    
    protected async override Task OnInitializedAsync()
    {
        var queryStrings = navigationManager.GetQueryStrings(navigationManager.Uri);
        Genres = await genreRepository.GetGenres();
        if(queryStrings != null)
        {
            FillFilterWithQueryStrings(queryStrings);
        }
            await LoadGames();
    }

    private void FillFilterWithQueryStrings(Dictionary<string, string> queryStrings)
    {
        if (queryStrings.ContainsKey("genreId"))
        {
            gameFilterDto.GenreId = int.Parse(queryStrings["genreId"]);
        }

        if (queryStrings.ContainsKey("title"))
        {
            gameFilterDto.Title = queryStrings["title"];
        }

        if (queryStrings.ContainsKey("newlyReleases"))
        {
            gameFilterDto.UpcomingReleases = bool.Parse(queryStrings["newlyReleases"]);
        }

        if (queryStrings.ContainsKey("upcomingReleases"))
        {
            gameFilterDto.UpcomingReleases = bool.Parse(queryStrings["upcomingReleases"]);
        }

        if (queryStrings.ContainsKey("page"))
        {
            gameFilterDto.Page = int.Parse(queryStrings["page"]);
        }
    }

    private async Task SelectedPage(int page)
    {
        gameFilterDto.Page = page;
        await LoadGames();
    }

    private async Task LoadGames() 
    {
        var queryString = GenerateQueryString();
        if(!string.IsNullOrWhiteSpace(queryString))
        {
            queryString = $"?{queryString}";
            navigationManager.NavigateTo("games/search" + queryString);
        }

        var pageResponse = await gameRepository.GetGamesByFilter(gameFilterDto);
        Games = pageResponse.Response;
        amountOfPages = pageResponse.AmountOfPages;
    }

    private string GenerateQueryString()
    {
        var queryStringDict = new Dictionary<string, string>();
        queryStringDict["genreId"] = gameFilterDto.GenreId.ToString();
        queryStringDict["title"] = gameFilterDto.Title ?? "";
        queryStringDict["newlyReleases"] = gameFilterDto.NewlyReleases.ToString();
        queryStringDict["upcomingReleases"] = gameFilterDto.UpcomingReleases.ToString();
        queryStringDict["page"] = gameFilterDto.Page.ToString();

        var defaultValue = new List<string>() { "false", "", "0" };

        return string.Join("&", queryStringDict
            .Where(x => !defaultValue.Contains(x.Value.ToLower()))
            .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());
    }
    
    private async Task SearchForGames() 
    {
        await LoadGames();    
    }

    private async Task Clear() 
    {
        
        gameFilterDto.Title = "";
        gameFilterDto.GenreId = 0; 
        gameFilterDto.NewlyReleases = false;
        gameFilterDto.UpcomingReleases = false;
        await LoadGames();
    }

    private async Task TitleKeyPress(KeyboardEventArgs e) 
    {
        if(e.Key == "Enter")
        {
            //Implement here
            await SearchForGames();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameRepository gameRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
