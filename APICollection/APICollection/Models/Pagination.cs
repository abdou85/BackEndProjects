﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
