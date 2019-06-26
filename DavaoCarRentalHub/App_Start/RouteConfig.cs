using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DavaoCarRentalHub
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*******************************
             * Custom from ajdavaocarrental
             ********************************/
            routes.MapRoute(
              name: "ads-honda-city-automatic",
              url: "ads/honda-city-automatic/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "honda-city" }
            );

            routes.MapRoute(
              name: "rent-a-car-suv-for-rent-davao-city",
              url: "ads/rent-a-car-suv-for-rent-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ford-everest" }
            );

            routes.MapRoute(
              name: "ads/toyota-hiace-gl-grandia/",
              url: "ads/toyota-hiace-gl-grandia/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "toyota-glgrandia" }
            );

            routes.MapRoute(
              name: "ads/toyota-innova-d-4d/",
              url: "ads/toyota-innova-d-4d/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "toyota-innova" }
            );

            routes.MapRoute(
              name: "ads/car-for-rent-davao-city/",
              url: "ads/car-for-rent-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "honda-city-2012" }
            );

            routes.MapRoute(
              name: "ads/rent-a-car-davao-city-self-drive-2/",
              url: "ads/rent-a-car-davao-city-self-drive-2/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "self-drive" }
            );

            routes.MapRoute(
              name: "ads/minivan-and-sedan-rentals/",
              url: "ads/minivan-and-sedan-rentals/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "minivan-sedan" }
            );

            routes.MapRoute(
              name: "ads/sedan-davao-city-car-rental/",
              url: "ads/sedan-davao-city-car-rental/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "rent-a-car" }
            );

            routes.MapRoute(
              name: "ads/toyota-avanza-1-3e-at/",
              url: "ads/toyota-avanza-1-3e-at/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "toyota-avanza" }
            );
            routes.MapRoute(
              name: "ads/van-rental-davao-city/",
              url: "ads/van-rental-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "van-rental" }
            );


            /*******************************
             * Custom from ajdavaocarrental / Page 2
             ********************************/

            routes.MapRoute(
              name: "ads/ford-fiesta-1-6l-sedan-2012/",
              url: "ads/ford-fiesta-1-6l-sedan-2012/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ford-fiesta" }
            );

            routes.MapRoute(
              name: "ads/innovacar-for-rent-davao-city/",
              url: "ads/innovacar-for-rent-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "p2-innova-rental" }
            );


            routes.MapRoute(
              name: "ads/rent-a-car-davao-city-self-drive/",
              url: "ads/rent-a-car-davao-city-self-drive/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "innova-self-drive" }
            );

            routes.MapRoute(
              name: "ads/car-rental-honda-city-for-rent-self-drive/",
              url: "ads/car-rental-honda-city-for-rent-self-drive/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "honda-self-drive" }
            );

            routes.MapRoute(
              name: "ads/4x4-rental-suv-for-rent-davao/",
              url: "ads/4x4-rental-suv-for-rent-davao/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "toyota-fortuner" }
            );

            routes.MapRoute(
              name: "ads/4x4-rental-pickup-for-rent-davao/",
              url: "ads/4x4-rental-pickup-for-rent-davao/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "pickup" }
            );


            /*******************************
             * Custom from ajdavaocarrental / listing
             ********************************/
            routes.MapRoute(
              name: "/ad-category/sedans/",
              url: "ad-category/sedans/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "sedan-listing" }
            );

            routes.MapRoute(
              name: "ads/",
              url: "ads/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing" }
            );

            routes.MapRoute(
              name: "ads/page/1/",
              url: "ads/page/1/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing" }
            );

            routes.MapRoute(
              name: "ads/page/2/",
              url: "ads/page/2/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing-page-2" }
            );

            routes.MapRoute(
              name: "ad-category/others/",
              url: "ad-category/others/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing-others" }
            );

            routes.MapRoute(
              name: "ad-category/vans/",
              url: "ad-category/vans/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing-vans" }
            );
            routes.MapRoute(
              name: "ad-category/mpv/",
              url: "ad-category/mpv/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing-mpv" }
            );
            routes.MapRoute(
              name: "ad-category/pickup/",
              url: "ad-category/pickup/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "ads-listing-pickup" }
            );
            /*******************************
             * Custom from ajdavaocarrental / ad-tags
             ********************************/
            routes.MapRoute(
              name: "ad-tag/car-rental-davao/",
              url: "ad-tag/car-rental-davao/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "tag-car-rental-davao" }
            );

            routes.MapRoute(
              name: "ad-tag/davao-rent-a-car/",
              url: "ad-tag/davao-rent-a-car/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "tag-davao-rent-a-car" }
            );
            routes.MapRoute(
              name: "ad-tag/rent-a-car-davao-city/",
              url: "ad-tag/rent-a-car-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "rent-a-car-davao-city" }
            );

            routes.MapRoute(
              name: "ad-tag/van-for-rent-davao-city/",
              url: "ad-tag/van-for-rent-davao-city/",
              defaults: new { controller = "Home", action = "CarView", carDesc = "van-for-rent-davao-city" }
            );

            routes.MapRoute(
              name: "sitemap",
              url: "sitemap",
              defaults: new { controller = "Home", action = "SitemapXml"}
            );

            routes.MapRoute(
              name: "sitemap.xml",
              url: "sitemap.xml/",
              defaults: new { controller = "Home", action = "SitemapXml" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
