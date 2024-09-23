using System.Collections.Generic;
using System.Web.Mvc;
using WebSocketMVC.Models;

namespace WebSocketMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Prepare a list of WebSocket endpoints with custom names
            var webSocketEndpoints = new List<WebSocketEndpoint>
    {
        new WebSocketEndpoint { Name = "Machine1", Url = "wss://WebsocketTest:5001/" },
        new WebSocketEndpoint { Name = "Machine2", Url = "wss://WebsocketTest:5002/" },
        new WebSocketEndpoint { Name = "Machine3", Url = "wss://WebsocketTest:5003/" }
    };

            return View(webSocketEndpoints);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}