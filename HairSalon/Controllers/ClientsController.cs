using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {

    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                                .Include(client => client.Stylist)
                                .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client) //take in client
    {
      if(client.Stylist == 0) //make sure client list is not 0
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);  //add client to Clients DBSet (database)
      _db.SaveChanges();  //save changes
      return RedirectToAction("Index"); 
    }
    
  }
}