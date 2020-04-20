using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        public IEnumerable<Guid> Get()
        {
            return new Guid[] {
                Guid.NewGuid(),
                Guid.NewGuid()
            };
        }
    }
}
