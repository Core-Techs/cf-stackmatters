using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace cf_stackmatters.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _settings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            _settings = appSettings.Value;
        }

        public IActionResult Index()
        {
            var reversedText = string.Concat(_settings.PreReversedText.Reverse());

            return View(new HomeModel
            {
                ReversedText = reversedText

            });
        }

        
        public IActionResult Error()
        {
            return View();
        }
    }
}
