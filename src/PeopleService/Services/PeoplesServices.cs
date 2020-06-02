using PeopleService.ServiceCommunications;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Grpc.Core;

namespace PeopleService
{
	public class PeoplesServices : Person.PersonBase
	{
		private readonly ILogger<PeoplesServices> _logger;
		public PeoplesServices(ILogger<PeoplesServices> logger)
		{
			_logger = logger;
		}
	}
}
