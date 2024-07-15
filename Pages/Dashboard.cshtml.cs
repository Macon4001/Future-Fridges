using FutureFridgesCW.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity;

namespace FutureFridgesCW.Pages
{
    [Authorize(Roles = "Manager")]
    public class DashboardModel : PageModel
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public List<IdentityRole> roles { get; set; }

        public List<AppUser> Users { get; set; }
        public DashboardModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public string RoleNameToAdd { get; set; }


        [BindProperty]
        public string UpdatePassword { get; set; }
        [BindProperty]
        public string UpdateRole { get; set; }

        public void OnGet()
        {
            
            Users = _userManager.Users.ToList();
            roles =  _roleManager.Roles.ToList();
            
        }
        public async Task<IActionResult> OnPostAsync()
        {

            await _roleManager.CreateAsync(new IdentityRole(RoleNameToAdd.Trim()));
            return RedirectToPage("/Dashboard");

        }
                    
        public async Task<IActionResult> OnGetDeleteAsync(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            IdentityResult result = await _roleManager.DeleteAsync(role);
            return RedirectToPage("/Dashboard");
        }
        public async Task<IActionResult> OnPostUpdateAsync(string Id)

        {
            var users = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(users);
            await _userManager.AddPasswordAsync(users, UpdatePassword);
            return RedirectToPage("/Dashboard");

        }
        public async Task<IActionResult> OnPostRoleAsync(string Id)
        {
            var role = await _userManager.FindByIdAsync(Id);
            await _userManager.AddToRoleAsync(role, UpdateRole);
            return RedirectToPage("/AdminDashboard");
        }
    }
}
