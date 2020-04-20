using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using trending_query_service.Dtos;

namespace trending_query_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrendingArticlesController : ControllerBase
    {
        private readonly ILogger<TrendingArticlesController> _logger;

        public TrendingArticlesController(ILogger<TrendingArticlesController> logger)
        {
            _logger = logger;
        }

        public MixedTrendingArticles Get()
        {
            return new MixedTrendingArticles
            {
                Short = new Guid[] {
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                },
                Long = new Guid[] {
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                }
            };
        }
    }
}
