using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using PeopleService.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleService.Services
{
	[Authorize]
	public class UncleServices : Proto.Uncle.UncleBase
	{
		private readonly ILogger<UncleServices> _logger;

		public UncleServices(ILogger<UncleServices> logger)
		{
			_logger = logger;
		}

		public override Task<UncleReply> GetPeople(UncleFilter request, ServerCallContext context)
		{
			return base.GetPeople(request, context);
		}
	}
}
