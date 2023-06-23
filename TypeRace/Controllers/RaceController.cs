using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TypeRace.Hubs;
using TypeRace.Models;

namespace TypeRace.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index(string game, string trackid)
        {
            //RaceHub ct = new RaceHub();
            //ct.MoveCar("car2", 3);
            //ViewBag.trackId = trackId;
            //return View();

            if (game == null)
            {
                Guid g = Guid.NewGuid();
                ViewBag.gamename = g;
                Random rd = new Random();
                int r = rd.Next(1, 8);
                ViewBag.gamename = g;
                ViewBag.trackid = r;

            }
            else
            {
                ViewBag.gamename = game;
                ViewBag.trackid = trackid;
            }
            ViewBag.platform = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return View();
        }
        public IActionResult Recruit(string game,string trackid)
        {
            if (game == null)
            {
                Guid g = Guid.NewGuid();
                Random rd = new Random();
                int r=rd.Next(1, 8);
                ViewBag.gamename = g;
                ViewBag.trackid = r;
            }
            else
            {
                if (GameVar.OnAirGame != null && GameVar.OnAirGame.Any(x => x == game))
                {
                    var io = GameVar.OnAirGame;
                    TempData["userexceed"] = "<span style='color:red;'>The game has been already started. Please create new race.</span>";
                    return Redirect("/Race");
                }

                var thishub = new RaceHub();
                var kk = thishub.GetTotalUserNo(game);
                if (kk>7)
                {
                    TempData["userexceed"] = "<span style='color:red;'>User no exceeded. Please create another race.</span>";
                    return Redirect("/Race");
                }
                ViewBag.gamename = game;
                ViewBag.trackid = trackid;
            }
            return View();
        }
        public IActionResult Play(IFormCollection collection)
        {
            if (collection.Count==0)
            {
                return Redirect("/Race/Recruit");
            }
            //var racehub = new RaceHub();
            //await racehub.OnConnectedAsync();
            ViewBag.gamename = collection["gamename"];
            ViewBag.playername = collection["playername"];
            ViewBag.trackid = collection["trackid"];
            //ViewBag.trackid = 9;
            return View();
        }
    }
}
