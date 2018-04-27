using Microsoft.AspNetCore.Mvc;
using NetCore11_01.Interfaces;

namespace NetCore11_01.Controllers
{
    public class IOCTestController : Controller
    {
        private INewAlwaysGuidService _newAlwaysGuidService;
        private INewGuidService _newGuidService;
        private IInstanceGuidService _instanceGuidService;

        public IOCTestController(INewAlwaysGuidService a, INewGuidService b, IInstanceGuidService c)
        {
            _newAlwaysGuidService = a;
            _newGuidService = b;
            _instanceGuidService = c;
        }


        public IActionResult Index()
        {

            return new ContentResult { Content = $"{_newAlwaysGuidService.GetID()}\n{_newGuidService.GetID()}\n{_instanceGuidService.GetID()}\n" };

           // return View();
        }
    }
}