// See https://aka.ms/new-console-template for more information
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System.Net.Mail;



Console.WriteLine("Press any key to cont.....");
Console.ReadLine();
using var channel=GrpcChannel.ForAddress("http://localhost:5225"); 
var client=new Greeter.GreeterClient(channel);


var reply = await client.SayHelloAsync(new HelloRequest { Name="Ali Kemal SARI"});
Console.WriteLine($"Greetings: {reply.Message}");

Console.ReadLine();
/*
var response = await client.GetCustomerAsync(new GetCustomerRequest { CustomerId = "123" });
Console.WriteLine("Customer name: " + response.Name);
Console.WriteLine("Customer email: " + response.Email);
*/
Console.WriteLine("Press any key to exit");
Console.ReadLine() ;
