using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HistoryService.Controllers
{
    [ApiController]
    [Route("ui/histories/events")]
    public class HistoryController : ControllerBase
    {
        private readonly ILogger<HistoryDto> _logger;

        public HistoryController(ILogger<HistoryDto> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<HistoryDto> Get()
        {
            var result = Enumerable.Range(1, 5).Select(index => new HistoryDto
            {
                id = index,
                eventDateTime = DateTime.Now
            }).ToArray();

            return result;
        }
    }
}
