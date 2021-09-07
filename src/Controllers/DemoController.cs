using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoOidc.Controllers
{
    public class DemoController : Controller
    {
        // 
        // GET: /Demo/

        public string Index()
        {
            return "Demo of OIDC";
        }

        // 
        // GET: /Demo/Autorize/ 

        public string Autorize()
        {
            return "This is the Autorize action method...";
        }
    }
}