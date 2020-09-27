using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using APICollection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http.Headers;

namespace APICollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Pagination>> Collection(int nombre)
        {

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var stream = client.GetStreamAsync("https://api.discogs.com/users/ausamerika/collection/folders/0/releases");
            var repositories = await JsonSerializer.DeserializeAsync<Pagination>(await stream);
            return repositories;
         }

        }

    }
}
