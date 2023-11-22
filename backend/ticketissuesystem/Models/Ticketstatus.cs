using System.Text.Json.Serialization;

namespace ticketissuesystem.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Ticketstatus
    {


        Approve = 1,
        Closed = 2,
        Pending = 3,
    }
}
