using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ticketissuesystem.Models
{
    public class TemTicket
    {


        public int Id { get; set; }

        public  string Issuedate { get; set; }


        public required string Ticketnumber { get; set; }

        public string Description { get; set; }

        public required Issuetype Issuetype { get; set; }


        public required Ticketstatus Ticketstatus { get; set; }


        public required Prioritytype Prioritytype { get; set; }



       
        public int IssuerId { get; set; }

        public int AssignerId { get; set; }


        public int InventoryId { get; set; }







        public required string JobStatus { get; set; } = "Pending"; //inprogress --> completed or rejected

    }
}
