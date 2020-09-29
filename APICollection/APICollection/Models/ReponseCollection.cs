using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICollection.Models
{
    public class ReponseCollection
    {
        public Pagination Pagination { get; set; }
        public List<Release> Releases { get; set; }

        public int NombreArticles { get; set; }
    }
}
