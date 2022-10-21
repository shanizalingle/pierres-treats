using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Controllers
{
  [Authorize]
  public class FlavorsController : Controller
  {
    private readonly BakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> userManager, BakeryContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    
    // public async Task<ActionResult> Index()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   var userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).ToList();
    //   return View(userFlavors);
    // }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Flavor flavor)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var currentUser = await _userManager.FindByIdAsync(userId);
			flavor.User = currentUser;

      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }

    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
          .Include(flavor => flavor.JoinEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorId == id);
          return View(thisFlavor);
    }

    // [HttpPost]
    // public ActionResult Delete(int id)
    // {
    //   Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
    //   _db.Flavors.Remove(thisFlavor);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index", "Home");
    // }

  }
}