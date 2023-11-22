using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ticketissuesystem.Models
{
    public class Inventory
    {


        public int Id { get; set; }




          
        [JsonIgnore]
        public   Items Items { get; set; }




        [Required]
        public Inventorystatus Inventorystatus { get; set; } = Inventorystatus.Avilable;



    }
}
