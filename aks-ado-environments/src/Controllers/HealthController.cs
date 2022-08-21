using Microsoft.AspNetCore.Mvc;

namespace CatEncyclopedia.Controllers
{
    public class HealthController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private ILogger<HealthController> _logger;

        public HealthController(IHttpClientFactory httpClientFactory, ILogger<HealthController> logger)
        { 
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

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
            _logger.LogError("Something terrible happened...Can't load cats...Check your health probes!");
            return new BadRequestObjectResult("Unhealthy :-(");
        }
    }
}
