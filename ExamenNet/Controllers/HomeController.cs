using DAL.Repositories;
using ExamenNet.ViewModels;
using System.Web.Mvc;

namespace ExamenNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var listaClientes = ClientesRepository.TraerClientes();
            var viewModel = new HomeViewModel()
            {
                Clientes = listaClientes
            };
            return View(viewModel);
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