using Microsoft.AspNetCore.Mvc;

namespace CatEncyclopedia.Controllers
{
    public class HealthController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HealthController(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        [Route("ok")]
        public async Task<Stream> GetHealthyResponse()
        {
            var httpClient = _httpClientFactory.CreateClient();
            Uri okUri = new Uri("https://http.cat/200");

            var request = new HttpRequestMessage()
            {
                RequestUri = okUri,
                Method = HttpMethod.Get,
            };

            var result = await httpClient.SendAsync(request);
            return await result.Content.ReadAsStreamAsync();
        }

        [Route("badhealth")]
        public IActionResult GetUnhealthyResponse()
        {
            return new BadRequestObjectResult("Unhealthy :-(");
        }
    }
}
