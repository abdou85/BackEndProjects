using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APICollection.Models
{
    public class Release
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "instance_id")]
        public long InstanceId { get; set; }

        
        [JsonProperty(PropertyName = "date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }

        public BasicInformation BasicInformation { get; set; }

    }
}
