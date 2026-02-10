using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using SHARED.Models;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MonographController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            string filePath = "data.json";
            string jsonData = await System.IO.File.ReadAllTextAsync(filePath);


            return Ok(jsonData);
        }

        // GET: MonographController/Details/5
        [HttpGet("{guid}")]
        public async Task<IActionResult> Details(Guid guid)
        {
            string filePath = "data.json";
            string jsonData = await System.IO.File.ReadAllTextAsync(filePath);

            List<MonographModel> list = JsonSerializer.Deserialize<List<MonographModel>>(jsonData);

            MonographModel details = list.Where(x => x.MonographId == guid).FirstOrDefault();

            return Ok(details);
        }

        //// GET: MonographController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: MonographController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MonographController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MonographController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MonographController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MonographController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
