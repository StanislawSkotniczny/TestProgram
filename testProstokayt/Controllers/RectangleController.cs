using Microsoft.AspNetCore.Mvc;
using testProstokayt.Models;

namespace testProstokayt.Controllers
{
    public class RectangleController : Controller
    {
        private readonly IRectangleService _rectangleService;

        public RectangleController(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Rectangle());
        }

        [HttpPost]
        public IActionResult Add(Rectangle model) 
        {
            if(ModelState.IsValid)
            {
                _rectangleService.AddRectangle(model);
                return RedirectToAction("list");
            }
            return View(model);
        }


        public IActionResult List()
        {
            var rectangles = _rectangleService.GetRectangles();
            return View(rectangles);    
        }

        public IActionResult Details(Guid id) 
        {
            var rectangle = _rectangleService.GetRectangleById(id);
            if(rectangle == null)
            {
                return NotFound();
            }
            return View(rectangle);
        }


        public IActionResult Delete(Guid id)
        {
            _rectangleService.DeleteRectangle(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(Guid id) 
        {
            var rectangle = _rectangleService.GetRectangleById(id);
            if(rectangle == null)
            {
                return NotFound();
            }
            return View(rectangle);
        }


        [HttpPost]
        public IActionResult Edit (Guid id, Rectangle rectangle)
        {
            if(ModelState.IsValid)
            {
                _rectangleService.UpdateRectangle(id, rectangle);
                return RedirectToAction("List");
            }
            return View(rectangle);
        }
      
    }
}
