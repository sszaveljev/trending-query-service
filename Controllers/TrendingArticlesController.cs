using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using trending_query_service.Dtos;
using trending_query_service.Services;

namespace trending_query_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrendingArticlesController : ControllerBase
    {
        private readonly ILogger<TrendingArticlesController> _logger;
        private ITrendingArticlesService trendingArticlesService { get; }

        public TrendingArticlesController(ILogger<TrendingArticlesController> logger)
        {
            _logger = logger;
            trendingArticlesService = new TrendingArticlesService();
        }

        public MixedTrendingArticles Get()
        {
            return new MixedTrendingArticles
            {
                Short = trendingArticlesService.GetShort(),
                Long = trendingArticlesService.GetLong()
            };
        }
    }
}
