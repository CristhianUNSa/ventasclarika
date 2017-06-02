using DAL.Repositories;
using ExamenNet.ViewModels;
using System;
using System.Web.Mvc;

namespace ExamenNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var listaClientes = ClientesRepository.TraerClientes();
                var viewModel = new HomeViewModel()
                {
                    Clientes = listaClientes
                };
                return View(viewModel);
            }
            catch (Exception)
            {
                return Content("El sistema se encuentra momentáneamente fuera de servicio. Estamos trabajando para solucionar el inconveniente");
            }

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