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
        private ITrendingArticlesService _trendingArticlesService { get; }

        public TrendingArticlesController(ILogger<TrendingArticlesController> logger, ITrendingArticlesService trendingArticlesService)
        {
            _logger = logger;
            _trendingArticlesService = trendingArticlesService;
        }

        public MixedTrendingArticles Get()
        {
            return new MixedTrendingArticles
            {
                Short = _trendingArticlesService.GetShort(),
                Long = _trendingArticlesService.GetLong()
            };
        }
    }
}
