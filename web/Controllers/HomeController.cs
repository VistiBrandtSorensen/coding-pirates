using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mar14;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test([FromQuery]int? x = null, [FromQuery]int? y = null)
        {
            Player player;
            string p = HttpContext.Session.GetString("Player");
            if (string.IsNullOrWhiteSpace(p))
            {
                player = new Player();
                player.PlaceShip(true, 4, 4);
            }
            else
            {
                player = JsonConvert.DeserializeObject<Player>(p);
            }

            // Skyd på (x,y)
            if(x.HasValue && y.HasValue)
            {
                player.Shoot(x.Value, y.Value);
            }

            HttpContext.Session.SetString("Player", JsonConvert.SerializeObject(player));

            return View(player);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
