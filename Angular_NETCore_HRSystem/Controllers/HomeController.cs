using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Angular_ASPNETCore_CustomersService.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    [AllowAnonymous]
    public IActionResult Index()
    {
      return View();
    }
  }
}
