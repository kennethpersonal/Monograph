using API.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonographController : Controller
    {
        public async Task<IActionResult> List()
        {
            // 1. Create the parent instance
            var biogesicMonograph = new MonographModel
            {
                MonographId = Guid.Parse("16371ED2-BD4E-4E62-A7E5-9FA901886903"),
                MonographName = "Biogesic",
                MonographType = "Brief Monograph",
                MonographContents = new List<MonographContent>() 
            };

            biogesicMonograph.MonographContents.Add(new MonographContent
            {
                Header = "Content",
                Text = "Paracetamol 500 mg"
            });

            biogesicMonograph.MonographContents.Add(new MonographContent
            {
                Header = "Indications",
                Text = "Analgesic; antipyretic. Treatment of mild to moderate pain."
            });

            return Ok(biogesicMonograph);
        }

        // GET: MonographController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonographController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonographController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonographController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonographController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonographController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonographController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
