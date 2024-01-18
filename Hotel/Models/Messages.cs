namespace Hotel.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public DateTime? Datetime { get; set; }
        public Users? user { get; set; }
      //  public int? userId { get; set; }

    }
}
