using FutureFridgesCW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FutureFridgesCW.Pages
{
    public class AddSupplierModel : PageModel
    {
        private readonly AppDataContext _db;

        [BindProperty]
        public Supplier AddingSupplier { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public AddSupplierModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

            AddingSupplier = _db.Supplier.Find(Id);

        }

        public IActionResult OnPost()
        {
            _db.Supplier.Update(AddingSupplier);
            _db.SaveChanges();
            return RedirectToPage("/Supplier");
        }

    }
}
