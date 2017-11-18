```
dotnet new console
dotnet add package Newtonsoft.Json;
```

Model/Account.cs
```
using System;
using System.Collections.Generic;

namespace NugetExample.Model 
{
	class Account
	{
		public string Email { get; set; }
		public bool Active { get; set; }
		public DateTime CreatedDate { get; set; }
		public IList<string> Roles { get; set; }
	}
	
}
```

Program.cs
```
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
			  'Email': 'james@example.com',
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
```



```
dotnet run
```