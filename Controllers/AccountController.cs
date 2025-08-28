using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using dotnet_store.Models;

namespace dotnet_store.Controllers;

public class AccountController : Controller
{
    private UserManager<AppUser> _userManager;
    
    public AccountController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    
    public ActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<ActionResult> Create(AccountCreateModel model)
    {
        if(ModelState.IsValid)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
                AdSoyad = model.AdSoyad
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
        }
        return View(model);
    }
}