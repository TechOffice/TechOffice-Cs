# .NetCore Hello World Example

Commands to create a new .netCore project
```
dotnet new
dotnet restore
```

dotnet new :		Create a new .net project.
dotnet restore:		Update dependencies of the .net project.

## Main Program
The main program is specified in **Program.cs**. The below is the sample automatically generated by .NetCore. You can modifiy it and create your own program.

```
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

Commands to run .netCore project
```
dotnet run
```

Output
```
Project HelloWorldExample (.NETCoreApp,Version=v1.0) was previously compiled. Skipping compilation.
Hello World!
``` 

Commands to build .netCore project
```
dotnet build
```
The built package would be in **bin\Debug\netcoreapp1.0\win7-x64**