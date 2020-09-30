using Newtonsoft.Json;

namespace APICollection.Models
{
    public class BasicInformation
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "master_id")]
        public long MasterId { get; set; }

        
        [JsonProperty(PropertyName = "master_url")]
        public string MasterUrl { get; set; }

        
        [JsonProperty(PropertyName = "resource_url")]
        public string ResourceUrl { get; set; }


        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; }

        
        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }

        
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        
        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }
    }
}
