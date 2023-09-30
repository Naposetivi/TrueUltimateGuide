using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using TrueUltimateGuide.Models;

namespace TrueUltimateGuide.Controllers
{
    public class HomeController : Controller
    {
        //[Route("home")]
        //[Route("/")]
        //public ContentResult Index()
        //{
        //    //return new ContentResult() { Content = "Hello from Index", ContentType = "text/plain" };

        //    //return Content("Hello from Index", "text/plain");

        //    return Content("<h1>Welcome</h1> <h2>Hello from Index</h2>", "text/html");
        //}

        //[Route("person")]
        //public JsonResult Person()
        //{
        //    Person person = new Person() { Id = Guid.NewGuid(), FirstName = "James", LastName = "Smith", Age = 25 };
        //    //return new JsonResult(person);
        //    return Json(person);
        //    //return "{ \"key\": \"value\" }";
        //}

        //[Route("file-download")]
        //public VirtualFileResult FileDownload()
        //{
        //    //return new VirtualFileResult("/sample.pdf", "application/pdf");
        //    return File("/sample.pdf", "application/pdf");
        //}


        //[Route("bookstore")]
        ////Url: /bookstore?bookid=10&isloggedin=true
        //public IActionResult Index()
        //{
        //    //Book id should be applied
        //    if (!Request.Query.ContainsKey("bookid"))
        //    {
        //        //return new BadRequestResult();
        //        return BadRequest("Book id is not supplied");
        //    }

        //    //Book id can't be empty
        //    if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
        //    {
        //        return BadRequest("Book id can't be null or empty");
        //    }

        //    //Book id should be between 1 to 1000
        //    int bookId = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);
        //    if (bookId <= 0)
        //    {
        //        return BadRequest("Book id can't be less than or equal to zero");
        //    }
        //    if (bookId > 1000)
        //    {
        //        return NotFound("Book id can't be greater than 1000");
        //    }

        //    //isloggedin should be true
        //    if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
        //    {
        //        //return Unauthorized("User must be authenticated");
        //        return StatusCode(401);
        //    }

        //return File("/sample.pdf", "application/pdf");
        //302 - Found - RedirectToActionResult
        //return new RedirectToActionResult("Books", "Store", new { id = bookId }); //302 - Found
        //return RedirectToAction("Books", "Store", new { id = bookId });

        //301 - Moved Permanently - RedirectToActionResult
        //return new RedirectToActionResult("Books", "Store", new { }, permanent: true); //301 - Moved Permanently
        //return RedirectToActionPermanent("Books", "Store", new { id = bookId });

        //302 - Found - LocalRedirectResult
        //return new LocalRedirectResult($"store/books/{bookId}"); //302 - Found
        //return LocalRedirect($"store/books/{bookId}"); //302 - Found

        //301 - Moved Permanently - LocalRedirectResult
        /*return new LocalRedirectResult($"store/books/{bookId}", true);*/ //301 - Moved Permanently
        /*return RedirectPermanent($"store/books/{bookId}");*/ //301 - Moved Permanently

        //return Redirect($"store/books/{bookId}"); //302 - Found
        //return RedirectPermanent($"store/books/{bookId}"); //301 - Moved Permanently
        //}

        //[Route("register")]
        //public IActionResult Index(Person person, [FromHeader(Name = "User-Agent")] string UserAgent)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        //get error messages from model state
        //        string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));

        //        return BadRequest(errors);
        //    }

        //    return Content($"{person}, {UserAgent}");
        //}

        //  [Route("home")]
        //  [Route("/")]
        //  public IActionResult Index()
        //  {
        //      ViewData["appTitle"] = "Asp.Net Core Demo App";

        //      List<Person> people = new List<Person>()
        //      {
        //    new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
        //    new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
        //    new Person() { Name = "Susan", DateOfBirth = null, PersonGender = Gender.Other}
        //};

        //      return View("Index", people); //Views/Home/Index.cshtml
        //  }


        //  [Route("person-details/{name}")]
        //  public IActionResult Details(string? name)
        //  {
        //      if (name == null)
        //          return Content("Person name can't be null");

        //      List<Person> people = new List<Person>()
        //      {
        //    new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
        //    new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
        //    new Person() { Name = "Susan", DateOfBirth = null, PersonGender = Gender.Other}
        //};
        //      Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
        //      return View(matchingPerson);  //Views/Home/Details.cshtml
        //  }

        //  [Route("person-with-product")]
        //  public IActionResult PersonWithProduct()
        //  {
        //      Person person = new Person() { Name = "Sara", PersonGender = Gender.Female, DateOfBirth = Convert.ToDateTime("2004-07-01") };

        //      Product product = new Product() { ProductId = 1, ProductName = "Air Conditioner" };

        //      PersonAndProductWrapperModel personAndProductWrapperModel = new PersonAndProductWrapperModel() { PersonData = person, ProductData = product };
        //      return View(personAndProductWrapperModel);
        //  }

        //  [Route("home/all-products")]
        //  public IActionResult All()
        //  {
        //      return View();
        //      //Views/Home/All.cshtml
        //      //Views/Shared/All.cshtml
        //  }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("contact-support")]
        //public IActionResult Contact()
        //{
        //    return View();
        //}


        //[Route("programming-languages")]
        //public IActionResult ProgrammingLanguages()
        //{
        //    ListModel listModel = new ListModel()
        //    {
        //        ListTitle = "Programming Languages List",
        //        ListItems = new List<string>() {
        //  "Python",
        //  "C#",
        //  "Go"
        //}
        //    };

        //    return PartialView("_ListPartialView", listModel);
        //}

        [Route("friends-list")]
        public IActionResult LoadFriendsList()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Friends",
                Persons = new List<Person>()
    {
        new Person() { PersonName = "Mia", JobTitle = "Developer" },
        new Person() { PersonName = "Emma", JobTitle = "UI Designer" },
        new Person() { PersonName = "Avva", JobTitle = "QA" }
    }
            };

            return ViewComponent("Grid", new { grid = personGridModel });
        }
    }
}
