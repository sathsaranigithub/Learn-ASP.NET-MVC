using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicleService();
            service.Id = 1;
            service.Title = "Oil change";
            service.Description = "Change the oil in yuor vehicle";
            service.Cost = 39.99;

            return View(service);

        }
    }
}
