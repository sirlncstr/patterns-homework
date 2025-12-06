public class BookingRecord
{
    public int Id { get; set; }
    public UserAccount User { get; set; }
    public EventItem Event { get; set; }
    public BookingStatus Status { get; set; }
}
