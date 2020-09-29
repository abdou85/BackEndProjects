﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using APICollection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Linq;
using Newtonsoft.Json;

namespace APICollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        //[Route("api/controller/{nombre}")]
        public ActionResult<List<Release>> Collection(int nombre)
        {
            Collection model = null;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var task = client.GetAsync("https://api.discogs.com/users/ausamerika/collection/folders/0/releases")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<Collection>(jsonString.Result);

              });
            task.Wait();
            //var perPage = model.Pagination.PerPage;
            //var page = perPage * nombre;
            return model.Releases.ToList();


        }

        private static Release Release(Release release) =>
        new Release
        {
            Id = release.Id,
            InstanceId = release.InstanceId,
            DateAdded = release.DateAdded
        };

    }
}
