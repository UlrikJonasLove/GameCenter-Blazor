// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using gamecenter.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using gamecenter.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class GameForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\11, LIA - Lärande i Arbete 2\Projekt\GameCenter-Blazor\gamecenter\Client\Pages\Games\GameForm.razor"
       
    [Parameter] public Game Game { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenre { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedPerson { get; set; } = new List<Person>();

    private List<GenreSelectorModel> Selected = new List<GenreSelectorModel>();
    private List<GenreSelectorModel> NotSelected = new List<GenreSelectorModel>();
    private string imageURL;

    protected override void OnInitialized()
    {
        Selected = SelectedGenre.Select(x => new GenreSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedGenres.Select(x => new GenreSelectorModel(x.Id.ToString(), x.Name)).ToList();
        if(!string.IsNullOrEmpty(Game.Poster))
        {
            imageURL = Game.Poster;
            Game.Poster = null;
        }
    }
    private void OnSelectedPoster(string imageBase64)
    {
        Game.Poster = imageBase64;
        imageURL = null;
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return new List<Person>() {
            new Person() { Id = 1, Name = "Ulrik Rosberg", Picture="https://scontent-cph2-1.xx.fbcdn.net/v/t1.6435-9/122105566_10157907096954482_2219965355707851212_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=09cbfe&_nc_ohc=izJw3E3wwrAAX-OSxZo&_nc_ht=scontent-cph2-1.xx&oh=a170461ed28b43cc4089e13b0f937136&oe=60BCBF5E"},
            new Person() { Id = 2, Name = "Jonas Rosberg", Picture="https://scontent-cph2-1.xx.fbcdn.net/v/t1.6435-9/95764355_10157452994844482_8340900306434916352_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=174925&_nc_ohc=fBrNREPrORsAX8GKlh5&_nc_ht=scontent-cph2-1.xx&oh=ca3a77cee1f44004e0bf63d4df9f138f&oe=60B962AE"},
            new Person() { Id = 2, Name = "Erik Eriksson", Picture="https://scontent-cph2-1.xx.fbcdn.net/v/t1.6435-9/95764355_10157452994844482_8340900306434916352_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=174925&_nc_ohc=fBrNREPrORsAX8GKlh5&_nc_ht=scontent-cph2-1.xx&oh=ca3a77cee1f44004e0bf63d4df9f138f&oe=60B962AE"}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591