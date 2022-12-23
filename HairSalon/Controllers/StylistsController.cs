using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{

  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist) //takes in a stylist and adds stylist to DbSet
    {
      _db.Stylists.Add(stylist);  //adds stylist object to database of table Stylists
      _db.SaveChanges();  //saves database changes
      return RedirectToAction("Index"); //redirects to index after action is performed
    }

    public ActionResult Details(int id) //takes in id of the entry we want to view
    {
      Stylist stylistDetails = _db.Stylists //start by looking at _db.Stylists
                                    .Include(stylist => stylist.Clients)
                                    .FirstOrDefault(stylist => stylist.StylistId == id);//find any clients where the ClientId of a client is equal to id
      return View(stylistDetails);  //return details of stylist with that id
    }

    public ActionResult Edit(int id)  //takes in id of the entry we want to view
    {
      Stylist stylistEdit = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);//find any clients where the ClientId of a client is equal to id
      return View(stylistEdit); //Returns stylistEdit to edit view
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist) //this method is basically the same as Create method
    {
      _db.Stylists.Update(stylist);  //updates stylist object to database of table Stylists
      _db.SaveChanges();  //saves database changes
      return RedirectToAction("Index"); //redirects to index after action is performed
    }

    public ActionResult Delete(int id)// takes in id of the entry we want to view
    {
      Stylists stylistDelete = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);//find any clients where the ClientId of a client is equal to id
      return (stylistDelete);//return stylistDelete to Delete View
    }

  }
}