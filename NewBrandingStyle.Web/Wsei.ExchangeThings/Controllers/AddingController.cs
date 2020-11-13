using Wsei.ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddingController : ControllerBase
    {
        public AddNewItemResponse Post(ItemModel item)
        {
            var response = new AddNewItemResponse()
            {
                success = true,
                message = "Got ya",
                addedItem = item
            };


            return response;
        }
    }
}