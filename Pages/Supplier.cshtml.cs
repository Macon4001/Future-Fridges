using FutureFridgesCW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FutureFridgesCW.Pages
{
    public class SupplierModel : PageModel
    {
        public int Id { get; set; }
        public List<Supplier> Suppliers { get; set; }

        private readonly AppDataContext _db;

        public SupplierModel(AppDataContext db)
        {
            _db = db;
        }

       public void OnGet()
        {
            Suppliers=_db.Supplier.ToList();

        }


        public IActionResult OnGetDelete(int Id)
        {
            _db.Remove(_db.Supplier.Find(Id));
            _db.SaveChanges();
            return RedirectToAction("/Supplier");
        }

        public IActionResult OnGetAddSupplier()
        {
            return RedirectToPage("/AddSupplier");
                
                
        }
   


    }
}
