using System.Data.Entity;
using System.Web.Mvc;

public class CategoryController : Controller
{
    private ApplicationDbContext _context;

    public CategoryController()
    {
        _context = new ApplicationDbContext();
    }
    public ActionResult Index()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(category);
    }

   
    public ActionResult Edit(int id)
    {
        var category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
        if (category == null)
        {
            return HttpNotFound();
        }
        return View(category);
    }
   [HttpPost]
    public ActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(category);
    }

    public ActionResult Delete(int id)
    {
        var category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
        if (category == null)
        {
            return HttpNotFound();
        }
        return View(category);
    }

    [HttpPost]
    [ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var category = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult GetCategories()
    {
        var categories = _context.Categories.ToList();
        return Json(categories, JsonRequestBehavior.AllowGet);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
        base.Dispose(disposing);
    }
}