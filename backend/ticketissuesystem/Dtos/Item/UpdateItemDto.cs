namespace ticketissuesystem.Dtos.Item
{
    public class UpdateItemDto
    {

        public int Id { get; set; }
        public required string Itemname { get; set; }

        public required string Serialno { get; set; }

        public required Branch Branch { get; set; }

        public required Itemtype Itemtype { get; set; }

        public decimal Unitprice { get; set; }


      //  public DateOnly Purchasedate { get; set; }
    }
}
