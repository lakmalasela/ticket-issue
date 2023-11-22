using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ticketissuesystem.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        [DataType(DataType.Date)]  
        public required DateTime Issuedate { get; set; }


        public required string Ticketnumber { get; set; }

        public string Description { get; set; }
    
        public required Issuetype Issuetype  { get; set; }


        public required Ticketstatus Ticketstatus { get; set; }


        public required Prioritytype Prioritytype { get; set; }



        [JsonIgnore]
        public Employee Employee { get; set; }


        [JsonIgnore]
        public Inventory Inventory { get; set; }



       



        public required string JobStatus { get; set; } = "Pending"; //inprogress --> completed or rejected




    }
}
