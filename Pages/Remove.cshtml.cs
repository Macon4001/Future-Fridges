using FutureFridgesCW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FutureFridgesCW.Pages
{

    public class RemoveModel : PageModel
    {
        public List<Products> Products { get; set; }

        private readonly AppDataContext _db;

        public RemoveModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Products = _db.Products.ToList();
        }

        public IActionResult OnGetDelete(int Id)
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
    

