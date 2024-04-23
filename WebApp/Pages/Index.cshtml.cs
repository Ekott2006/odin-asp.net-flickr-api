using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTOs;

namespace WebApp.Pages;

public class IndexModel(ILogger<IndexModel> logger, IHttpClientFactory factory, IConfiguration configuration) : PageModel
{
    [BindProperty(SupportsGet = true)] public int PageNumber { get; set; } = 1;
    [BindProperty(SupportsGet = true)] public string Id { get; set; } = string.Empty;
    public new IndexResponse? Response { get; set; }
    public string ErrorMessage { get; set; } = string.Empty;

    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public void OnGet()
    {
        ModelState.Clear();
    }

    public async Task<PageResult> OnGetSearch()
    {
        string apiKey = configuration.GetSection("FlickrAPI").GetSection("Key").Value ?? throw new InvalidOperationException("Flickr API Key Not Found");
        string url =
            $"https://www.flickr.com/services/rest/?method=flickr.people.getPublicPhotos&api_key={apiKey}&user_id={Id}&per_page=20&page={PageNumber}&format=json&nojsoncallback=1";
        logger.LogInformation("URL: {}", url);
        try
        {
            HttpResponseMessage responseMessage = await factory.CreateClient().GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception();

            await using Stream message = await responseMessage.Content.ReadAsStreamAsync();
            IndexResponse response = await JsonSerializer.DeserializeAsync<IndexResponse>(message, _options) ?? throw new Exception();
            if (response.Stat == "ok") Response = response;
            else ErrorMessage = "Id doesn't exists, Check Your Flickr ID";
        }
        catch (Exception error)
        {
            logger.LogError("Search Handler Error: {}", error.Message);
            ErrorMessage = "Unable To Retrieve the Images";
        }

        return Page();
    }
}