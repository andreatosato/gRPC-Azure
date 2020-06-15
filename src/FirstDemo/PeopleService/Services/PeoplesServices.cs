using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Grpc.Core;
using PeopleService.Proto;

namespace PeopleService
{
	public class PeoplesServices : Proto.Person.PersonBase
	{
		private readonly ILogger<PeoplesServices> _logger;
		public PeoplesServices(ILogger<PeoplesServices> logger)
		{
			_logger = logger;
		}

		public override Task<PeopleReply> GetAllPeople(PeopleFilterRequest request, ServerCallContext context)
		{
			return base.GetAllPeople(request, context);
		}
	}
}
