using System;

namespace trending_query_service.Services
{
    public class TrendingArticlesService : ITrendingArticlesService
    {
        public Guid[] GetShort()
        {
            return new Guid[] {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
            };
        }
        public Guid[] GetLong()
        {
            return new Guid[] {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
            };
        }
    }
}