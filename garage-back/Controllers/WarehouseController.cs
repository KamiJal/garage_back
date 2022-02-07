using garage_back.Models;
using garage_back.Persistence;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace garage_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly ILogger<WarehouseController> _logger;

        private readonly IRepository _repo;

        public WarehouseController(ILogger<WarehouseController> logger, IRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        /// <summary>
        /// Gets all the available warehouses.
        /// </summary>
        /// <returns></returns>
        [EnableCors("GarageFront")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_repo.GetAllWarehouses());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fatal error");
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
