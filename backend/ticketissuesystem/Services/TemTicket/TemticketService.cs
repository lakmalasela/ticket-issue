using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticketissuesystem.Data;
using ticketissuesystem.Dtos.TemTickets;

namespace ticketissuesystem.Services.TemTicket
{
    public class TemticketService : ITemticketService
    {

        public readonly IMapper _mapper;

        public readonly DataContext _context;

        public TemticketService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;

        }
        public async Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto newTicket)
        {
            var serviceResponse = new ServiceResponse<List<GetTicketDto>>();

            var ticket = _mapper.Map<Models.TemTicket>(newTicket);

            //employee.Id = employees.Max(c => c.Id)+1;
            _context.TemTicket.Add(ticket);

            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.TemTicket.Select(c => _mapper.Map<GetTicketDto>(c)).ToListAsync();

            //employees.Add(employee);
            // serviceResponse.Data = employees.Select(c => _mapper.Map<GetEmployeeDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetTicketDto>>();
            try
            {
                var temticket = await _context.TemTicket.FirstOrDefaultAsync(c => c.Id == id);
                if (temticket is null)
                    throw new Exception($"Character with Id '{id}'Not found");

                _context.TemTicket.Remove(temticket);

                await _context.SaveChangesAsync();


                //employees.Remove(employee);
                serviceResponse.Data = await _context.TemTicket.Select(c => _mapper.Map<GetTicketDto>(c)).ToListAsync();


            }
            catch (Exception ex)
            {
                serviceResponse.Sucess = false;
                serviceResponse.Message = ex.Message;

            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetTicketDto>>> GetAllTickets()
        {
            var serviceResponse = new ServiceResponse<List<GetTicketDto>>();
            var dbTicket = await _context.TemTicket.ToListAsync();
            serviceResponse.Data = dbTicket.Select(c => _mapper.Map<GetTicketDto>(c)).ToList();

            return serviceResponse;
        }

        public Task<ServiceResponse<List<string>>> GetIssuetype()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<string>>> GetPrioritytype()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetTicketDto>> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<string>>> GetTicketstatus()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTicketDto>> UpdateTicket(int id, UpdateTicketDto updateTicket)
        {
            var serviceResponse = new ServiceResponse<GetTicketDto>();

            try
            {
                var ticket =

                  await _context.TemTicket.FirstOrDefaultAsync(c => c.Id == id);
                if (ticket is null)
                {
                    throw new Exception($"Ticket with Id '{updateTicket.Id}'Not found");
                }


                ticket.Ticketnumber = updateTicket.Ticketnumber;
                ticket.Ticketstatus = updateTicket.Ticketstatus;
                ticket.AssignerId = updateTicket.AssignerId;
                ticket.Description = updateTicket.Description;
                ticket.JobStatus = updateTicket.JobStatus;
                ticket.Issuedate = updateTicket.Issuedate;
                ticket.InventoryId = updateTicket.InventoryId;
                ticket.IssuerId = updateTicket.IssuerId;
                ticket.Prioritytype = updateTicket.Prioritytype;
                ticket.Issuetype = updateTicket.Issuetype;


                //              employee.Civilstatus = _mapper.Map<Civ>(updateEmplyee.Civilstatus);



                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetTicketDto>(ticket);

            }
            catch (Exception ex)
            {
                serviceResponse.Sucess = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
