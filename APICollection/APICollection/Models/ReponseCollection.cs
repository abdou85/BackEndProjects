using System.Collections.Generic;

namespace APICollection.Models
{
    public class ReponseCollection
    {
        public IEnumerable<Release> Releases { get; set; }

        public int NombreArticles { get; set; }
    }
}
