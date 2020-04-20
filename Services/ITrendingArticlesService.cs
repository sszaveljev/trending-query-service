using System;

namespace trending_query_service.Services
{
    public interface ITrendingArticlesService
    {
        Guid[] GetShort();
        Guid[] GetLong();
    }
}