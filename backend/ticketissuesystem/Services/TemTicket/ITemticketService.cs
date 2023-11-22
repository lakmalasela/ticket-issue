using ticketissuesystem.Dtos.TemTickets;

namespace ticketissuesystem.Services.TemTicket
{
    public interface ITemticketService
    {

        Task<ServiceResponse<List<GetTicketDto>>> GetAllTickets();
        Task<ServiceResponse<GetTicketDto>> GetTicketById(int id);

        Task<ServiceResponse<GetTicketDto>> UpdateTicket(int id, UpdateTicketDto updateTicket);

        Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto newTicket);

        Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id);

        Task<ServiceResponse<List<String>>> GetIssuetype();

        Task<ServiceResponse<List<String>>> GetPrioritytype();

        Task<ServiceResponse<List<String>>> GetTicketstatus();
    }
}
