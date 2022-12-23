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
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist stylistDetails = _db.Stylists
                                    .Include(stylist => stylist.Clients)
                                    .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylistDetails);
    }

    public ActionResult Edit(int id)
    {
      Stylist stylistEdit = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylistEdit);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Stylists.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Stylist stylistDelete = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylistDelete);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist deleteStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(deleteStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}