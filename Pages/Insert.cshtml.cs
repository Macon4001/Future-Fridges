using FutureFridgesCW.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FutureFridgesCW.Pages
{
    //[Authorize(Roles = "Headchef,Chef,Driver")]
    public class InsertModel : PageModel
    {
        private readonly AppDataContext _db;
        public bool queryStringChecker { get; set; }
        public string button { get; set; }

        [BindProperty]
        public Products productGoingIntoFridge { get; set; }
        public bool Save { get; set; }
        public bool Update { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public InsertModel(AppDataContext db)
        {
            _db = db;
        }


        public void OnGet()
        {

            productGoingIntoFridge = _db.Products.Find(Id);
        }

        public IActionResult OnPost()
        {
            _db.Products.Add(productGoingIntoFridge);
            _db.SaveChanges();
            return RedirectToPage("/Remove");
        }
        public IActionResult OnPostUpdate()
        {

            _db.Products.Update(productGoingIntoFridge);
            _db.SaveChanges();
            return RedirectToPage("/Remove");
        }

    }
    
    
}
