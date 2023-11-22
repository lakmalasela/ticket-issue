using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using ticketissuesystem.Data;

namespace ticketissuesystem.Services.Inventory
{
    public class InventoryService : IInventoryService
    {


        public readonly IMapper _mapper;

        public readonly DataContext _context;
        public InventoryService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<GetInventoryDto>>> GetAllInventory()
        {
            var serviceResponse = new ServiceResponse<List<GetInventoryDto>>();
            try
            {
                var dbInventory = await _context.Inventory
                    .Include(i => i.Items)  // Include the Item property
                    .ToListAsync();

                // Use AutoMapper to map entities to DTOs directly
                serviceResponse.Data = _mapper.Map<List<GetInventoryDto>>(dbInventory);
                serviceResponse.Sucess = true;



                // Deserialize back to DTOs

                // serviceResponse.Data = JsonSerializer.Deserialize<List<GetInventoryDto>>(jsonString, options);




                //     serviceResponse.Data = dbInventory.Select(c => _mapper.Map<GetInventoryDto>(c, options)).ToList();
                serviceResponse.Sucess = true;
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
