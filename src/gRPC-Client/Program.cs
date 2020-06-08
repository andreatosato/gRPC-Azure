using Grpc.Net.Client;
using PeopleService.Proto;
using PeopleService.Protos;
using System;
using System.Threading.Tasks;

namespace gRPC_Client
{
	class Program
	{
		async static Task Main(string[] args)
		{
			using var channel = GrpcChannel.ForAddress("https://localhost:32768/");
			var clientSimple = new Simple.SimpleClient(channel);
			var sampleResult = await clientSimple.GetSimpleDataAsync(new InRequest{ Filter = "Prova" });



			var client = new Person.PersonClient(channel);
			PeopleFilterRequest filterRequest = new PeopleFilterRequest();
			var reply = await client.GetAllPeopleAsync(filterRequest);

			//var client = new Greeter.GreeterClient(channel);
			//var reply = await client.SayHelloAsync(
			//				  new HelloRequest { Name = "GreeterClient" });
			Console.ReadKey();
		}
	}
}
