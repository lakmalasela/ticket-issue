using Microsoft.AspNetCore.Mvc;
using ticketissuesystem.Dtos.TemTickets;
using ticketissuesystem.Services.Itemsservice;
using ticketissuesystem.Services.TemTicket;

namespace ticketissuesystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {

        public readonly ITemticketService _temticketService;
        public TicketController(ITemticketService temticketservice)
        {

            _temticketService = temticketservice;
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> AddtTicket(AddTicketDto addTicket)
        {
            return Ok(await _temticketService.AddTicket(addTicket));
        }



        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> GetAll()
        {
            return Ok(await _temticketService.GetAllTickets());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> DeleteTicket(int id)
        {
            var response = await _temticketService.DeleteTicket(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> UpdatedTicket(int id, UpdateTicketDto updateTicket)
        {
            var response = await _temticketService.UpdateTicket(id, updateTicket);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);


        }


    }
}
