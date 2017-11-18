using System;
using NugetExample.Model;
using Newtonsoft.Json;

namespace NugetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			string json = @"{
			  'Email': 'ben@techoffice.com',
			  'Active': true,
			  'CreatedDate': '2013-01-20T00:00:00Z',
			  'Roles': [
				'User',
				'Admin'
			  ]
			}";
			Account account = JsonConvert.DeserializeObject<Account>(json);
			Console.WriteLine(account.Email);
        }
    }
}
