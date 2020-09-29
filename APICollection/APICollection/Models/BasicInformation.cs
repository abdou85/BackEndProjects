using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APICollection.Models
{
    public class BasicInformation
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("master_id")]
        public long MasterId { get; set; }

        [JsonPropertyName("master_url")]
        public string MasterUrl { get; set; }

        [JsonPropertyName("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonPropertyName("thumb")]
        public string Thumb { get; set; }

        [JsonPropertyName("cover_image")]
        public string CoverImage { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }
    }
}
