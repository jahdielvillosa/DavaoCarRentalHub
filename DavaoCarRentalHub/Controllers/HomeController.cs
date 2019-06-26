using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavaoCarRentalHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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



        public ActionResult CarView(string carDesc)
        {
            switch (carDesc)
            {
                case "honda-city":
                    return View("~/Views/Home/CarViews/HondaCity.cshtml");
                case "honda-city-2012":
                    return View("~/Views/Home/CarViews/HondaCity2012.cshtml");
                case "ford-everest":
                    return View("~/Views/Home/CarViews/FordEverest.cshtml");
                case "toyota-glgrandia":
                    return View("~/Views/Home/CarViews/ToyotaGLGrandia.cshtml");
                case "toyota-innova":
                    return View("~/Views/Home/CarViews/ToyotaInnova.cshtml");
                case "self-drive":
                    return View("~/Views/Home/CarViews/HondaCity2012-SelfDrive.cshtml");
                case "minivan-sedan":
                    return View("~/Views/Home/CarViews/MiniVanSedan.cshtml");
                case "rent-a-car":
                    return View("~/Views/Home/CarViews/DavaoRentaCar.cshtml");
                case "toyota-avanza":
                    return View("~/Views/Home/CarViews/ToyotaAvanza.cshtml");
                case "van-rental":
                    return View("~/Views/Home/CarViews/VanRental.cshtml");

                //Page 2 start
                case "p2-innova-rental":
                    return View("~/Views/Home/CarViews/ToyotaInnovaCarForRent.cshtml");
                case "innova-self-drive":
                    return View("~/Views/Home/CarViews/RentCarSelfDrive.cshtml");
                case "ford-fiesta":
                    return View("~/Views/Home/CarViews/FordFiesta.cshtml");
                case "honda-self-drive":
                    return View("~/Views/Home/CarViews/HondaCityRental.cshtml");
                case "toyota-fortuner":
                    return View("~/Views/Home/CarViews/ToyotaFortuner.cshtml");
                case "pickup":
                    return View("~/Views/Home/CarViews/Pickup4x4.cshtml");

                //ads tag start
                case "tag-car-rental-davao":
                    return View("~/Views/Home/CarViews/Tags/car-rental-davao.cshtml");
                case "tag-davao-rent-a-car":
                    return View("~/Views/Home/CarViews/Tags/davao-rent-A-car.cshtml");
                case "rent-a-car-davao-city":
                    return View("~/Views/Home/CarViews/Tags/rent-a-car-davao-city.cshtml");
                case "van-for-rent-davao-city":
                    return View("~/Views/Home/CarViews/Tags/van-for-rent-davao-city.cshtml");

                //listing start
                case "sedan-listing":
                    return View("~/Views/Home/CarViews/ListingSedan.cshtml");
                case "ads-listing":
                    return View("~/Views/Home/Index.cshtml");
                case "ads-listing-others":
                    return View("~/Views/Home/CarViews/ListingSUV.cshtml");
                case "ads-listing-vans":
                    return View("~/Views/Home/CarViews/ListingVan.cshtml");
                case "ads-listing-mpv":
                    return View("~/Views/Home/CarViews/ListingMPV.cshtml");
                case "ads-listing-pickup":
                    return View("~/Views/Home/CarViews/ListingPickup.cshtml");
                case "ads-listing-page-1":
                    return View("~/Views/Home/Index.cshtml");
                case "ads-listing-page-2":
                    return View("~/Views/Home/CarViews/ListingAds2.cshtml");
                default:
                    return View("~/Views/Home/CarViews/ListingAds.cshtml");
            }
        }



        #region Dynamic SiteMap 
        [Route("sitemap.xml")] 
        //localhost:12345
        public ActionResult SitemapXml()
        {
            string currentUrl = Request.Url.AbsoluteUri;
            int iTmp = currentUrl.IndexOf('/', 15);
            string newurl = currentUrl.Substring(0, iTmp + 1);

            Models.SiteMap sm = new Models.SiteMap();
            var sitemapNodes = sm.GetSitemapNodes(newurl);
            string xml = sm.GetSitemapDocument(sitemapNodes);
            return this.Content(xml, "text/xml", System.Text.Encoding.UTF8);

        }
        #endregion

    }
}