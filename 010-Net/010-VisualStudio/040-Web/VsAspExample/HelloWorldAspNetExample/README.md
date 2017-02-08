# Hello World ASP.net MVC Example

## Example

This example show ASP.net MVC feature.

The HomeController with method index return a view (Index.cshtml). The default url would be http://localhost:55172/ or http://localhost:55172/Home or http://localhost:55172/Hello/Index

There is another method in the class which is Hello(). It also return a View(). The view would be mapped to Hello.cshtml. And the url would be http://localhost:55172/Home/Hello

HomeController.cs
```
namespace HelloWorldAspNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		// GET: Hello
        public ActionResult Hello()
        {
            return View();
        }
    }
}
```

Index.cshtml
```
@{
    ViewBag.Title = "Index";
}

<h2>Index</h2>

```

Hello.cshtml
```
@{
    ViewBag.Title = "Hello";
}

<h2>Hello</h2>
```