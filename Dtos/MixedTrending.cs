using System;

namespace trending_query_service.Dtos
{
    public class MixedTrendingArticles
    {
        public Guid[] Short { get; set; }
        public Guid[] Long { get; set; }
    }
}