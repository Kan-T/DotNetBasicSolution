using BasicAspApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicAspApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult index()
        {
            return Content("Hello World. This is from HomeController.index()...");
        }

        public ObjectResult employee()
        {
            var employee = new Employee { Id = 1, Name = "Michael" };
            return new ObjectResult(employee);                          //在转换 ObjectResult 对象时，它可能被序列化为 XML 或 JSON 或其它格式， 至于什么格式，由应用程序启动时向 MVC 提供的配置信息决定。如果我们没有显式的配置任何东西，那么将会使用 JSON 作为默认格式
        }

        public ViewResult vemployee()
        {
            var employee = new Employee { Id = 1, Name = "Michael" };
            return View(employee);
        }
    }
}
