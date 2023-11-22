using AutoMapper;
using ticketissuesystem.Dtos.TemTickets;
using ticketissuesystem.Models;

namespace ticketissuesystem
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, GetEmployeeDto>();
            CreateMap<UpdateEmplyeeDto, Employee>();
            CreateMap<AddEmployeeDto, Employee>();

          //  CreateMap<Inventory, GetInventoryDto>();

            CreateMap<Items, GetItemDto>();
            CreateMap<UpdateItemDto, Items>();
            CreateMap<AddItemDto, Items>();


            CreateMap<Inventory, GetInventoryDto>()
      .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
            //  CreateMap<Inventory, GetInventoryDto>()
            // .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
            // .ForMember(dest => dest.Inventorystatus, opt => opt.MapFrom(src => src.Inventorystatus));

            CreateMap<TemTicket, GetTicketDto>();
            CreateMap<UpdateTicketDto, TemTicket>();
            CreateMap<AddTicketDto, TemTicket>();
        }
    }
}
