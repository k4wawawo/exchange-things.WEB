using Microsoft.AspNetCore.Mvc;
using Wsei.ExchangeThings.Web.Filters;
using Wsei.ExchangeThings.Web.Models;
using Wsei.ExchangeThings.Web.Database;
using Wsei.ExchangeThings.Web.Entities;

namespace Wsei.ExchangeThings.Web.Controllers
{
    public class ExchangesController : Controller
    {

        private readonly ExchangesDbContext _dbContext;
        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [ServiceFilter(typeof(ItemEntity))]
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {

            var entity = new ItemEntities
            {
                Id = 1,
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };
            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            //return View("AddConfirmation", viewModel);
            return RedirectToAction("AddConfirmation", new { itemId = 1 });
        }

        [HttpGet]
        public IActionResult AddConfirmation(int itemId)
        {
            return View(itemId);
        }
    }
}