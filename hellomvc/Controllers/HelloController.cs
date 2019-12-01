using hellomvc.Models;
using hellomvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace hellomvc.Controllers
{
    public class HelloController : Controller
    {
        private readonly IHelloService<HelloViewModel> _helloService;
        public HelloController(IHelloService<HelloViewModel> helloService)
        {
            _helloService = helloService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View(new HelloViewModel());
        }
        [HttpPost]
        public IActionResult PostHello(HelloViewModel model){
            var result = _helloService.HelloMvc(model);
            return View("HelloFromMvc", result);
        }
        
    }
}