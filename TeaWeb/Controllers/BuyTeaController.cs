using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeaWeb.Models;

namespace TeaWeb.Controllers
{
  public class BuyTeaController : Controller
  {
    // GET: BuyEat
    public ActionResult BuyList()
    {
      List<Item> itemList = new List<Item>();
      Item item1 = new Item { Id = 0, Name = "Item1", Image = "/Image/logo.jpg" };
      itemList.Add(item1);
      return View(itemList);
    }
  }
}