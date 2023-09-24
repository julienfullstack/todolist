using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

  [HttpGet("/categories/{categoryId}/items/{itemId}")]
  public ActionResult Show(int categoryId, int itemId)
  {
    Item item = Item.Find(itemId);
    Category category = Category.Find(categoryId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("item", item);
    model.Add("category", category);
    return View(model);
  }

  }
}