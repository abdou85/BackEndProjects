using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APICollection.Models
{
    public class Collection
    {
        public Pagination Pagination { get; set; }
        public List<Release> Releases { get; set; }

        public int NombreArticles { get; set; }
    }
    public class Pagination
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("items")]
        public int Items { get; set; }

    }
}
