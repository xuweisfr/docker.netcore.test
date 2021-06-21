using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MyController : ControllerBase
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<MyController> _logger;

		public MyController(ILogger<MyController> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		[HttpGet]
		public string Get()
		{
			return _configuration["My:TestKey"];
		}
	}
}
