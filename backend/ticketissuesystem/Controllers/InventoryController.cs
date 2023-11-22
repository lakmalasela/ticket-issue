using Microsoft.AspNetCore.Mvc;
using ticketissuesystem.Services.Employeeservice;
using ticketissuesystem.Services.Inventory;

namespace ticketissuesystem.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {

        public readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetInventoryDto>>>> GetAll()

        {
          try
            {
                var res = await _inventoryService.GetAllInventory();
                return Ok(res);

            }
            catch(Exception ex)
            {
                throw ex;
            }
           

        }
    }
}
