using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Net.Mime;
using System.Runtime.Intrinsics.Arm;

namespace Notebook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult HowToWebWork()
        {
            return View();
        }

        #region Action Return Types


        public IActionResult actionResult()
        {
            return View();
        }



        public ViewResult ViewResult()
        {
            return View();
        }


        public PartialViewResult PartialViewResult()
        {
            return PartialView();
        }


        public ContentResult ContentResult()
        {
            return Content("<h1>Aminmoharrami</h1>", "text/html"); ;
        }


        public EmptyResult emptyResult()
        {
            return new EmptyResult();
        }

        public FileResult fileResult()
        {
            return File("~/text.txt", "txt/html");
        }


        public FileResult fileResult2()
        {
            var fileContent = System.IO.File.ReadAllBytes("c:/users/aminmoharrami/source/repos/notebook/notebook/wwwroot/text.txt");
            const string NFile = "TestFile.txt";
            return File(fileContent,MediaTypeNames.Text.Plain, NFile);
        }



        #endregion
    }
}
