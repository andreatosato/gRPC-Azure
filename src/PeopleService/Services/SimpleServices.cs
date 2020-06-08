using Grpc.Core;
using PeopleService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleService.Services
{
	public class SimpleServices : Simple.SimpleBase
	{
		public SimpleServices()
		{

		}

		public override Task<OutReply> GetSimpleData(InRequest request, ServerCallContext context)
		{
			var outReply = new OutReply() { SampleString = "Sample" };
			outReply.Samples.AddRange(new[] { "A", "B", "C" });

			return Task.FromResult(outReply);
		}
	}
}
