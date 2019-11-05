using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DownloadMusic(int musicId)
        {
            switch (musicId)
            {
                case 0:
                    return File(@"~\Content\files\bensound-betterdays.mp3", "audio/mpeg");
                case 1:
                    return File(@"~\Content\files\bensound-dubstep.mp3", "audio/mpeg");
                case 2:
                    return File(@"~\Content\files\bensound-sunny.mp3", "audio/mpeg");
                default:
                    return new HttpStatusCodeResult(500);
            }
        }
        public ActionResult DownloadAlbum()
        {
            return File(@"~\Content\files\album.zip", "application/zip");
        }
    }
}