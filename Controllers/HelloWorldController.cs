using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCFirstApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string index()
        {
            return "This is my default action...";
        }
        public string Welcome(string name, int num)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Number var is:{num}");
            // controller-name/action=index/id?
        }
    }


}