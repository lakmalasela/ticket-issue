using System.Text.Json.Serialization;

namespace ticketissuesystem.Models
{


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Issuetype
    {


        Hardware = 1,
        Software = 2
    }
}
