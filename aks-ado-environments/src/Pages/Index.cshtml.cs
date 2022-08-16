using CatEncyclopedia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace CatEncyclopedia.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    [ViewData]
    public string CatFact { get; set; }
    [ViewData]
    public string CatImage { get; set; }

    public IndexModel(ILogger<IndexModel> logger,IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public async Task OnGet()
    {
        var httpClient = _httpClientFactory.CreateClient();
        await GetCatQuote(httpClient);
        await GetCatImage(httpClient);
    }
    private async Task GetCatQuote(HttpClient httpClient)
    {
        Uri catQuoteUri = new Uri("https://catfact.ninja/fact");

        var request = new HttpRequestMessage()
        {
            RequestUri = catQuoteUri,
            Method = HttpMethod.Get,
        };

        var result = await httpClient.SendAsync(request);
        var resp = await result.Content.ReadAsStringAsync();
        CatFact = JsonConvert.DeserializeObject<CatQuote>(resp).fact;
    }

    private async Task GetCatImage(HttpClient httpClient)
    {
        Uri catImageUri = new Uri("https://api.thecatapi.com/v1/images/search");

        var request = new HttpRequestMessage()
        {
            RequestUri = catImageUri,
            Method = HttpMethod.Get,
        };

        var result = await httpClient.SendAsync(request);
        var resp = await result.Content.ReadAsStringAsync();
        var catImageObj = JsonConvert.DeserializeObject<List<CatImage>>(resp)?.FirstOrDefault();

        if(catImageObj != null)
        {
            CatImage = catImageObj.url;
        }        
    }
}
