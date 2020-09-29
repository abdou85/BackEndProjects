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

        [JsonPropertyName("instance_id")]
        public long InstanceId { get; set; }

        [JsonPropertyName("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        public BasicInformation BasicInformation { get; set; }

    }
}
