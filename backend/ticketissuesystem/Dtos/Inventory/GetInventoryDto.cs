using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ticketissuesystem.Dtos.Inventory
{
    public class GetInventoryDto
    {


        public int Id { get; set; }


        // public int ItemsId { get; set; }

          [Required]
           public  Items Items { get; set; }


        [Required]
        public  Inventorystatus Inventorystatus { get; set; }
    }
}
