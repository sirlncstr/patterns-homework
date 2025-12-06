using System;
using System.Collections.Generic;
using System.Linq;

public class EventBookingSystem
{
    public List<EventItem> Events { get; } = new List<EventItem>();
    public List<UserAccount> Users { get; } = new List<UserAccount>();
    public List<BookingRecord> Bookings { get; } = new List<BookingRecord>();

    public void ShowEvents()
    {
        foreach (var ev in Events)
        {
            Console.WriteLine($"{ev.Id}: {ev.Title} {ev.Date} {ev.Place}");
        }
    }

    public BookingRecord CreateBooking(UserAccount user, int eventId)
    {
        var ev = Events.FirstOrDefault(e => e.Id == eventId);
        if (ev == null) return null;
        if (user.Role == UserRole.Guest) return null;

        var booking = new BookingRecord
        {
            Id = Bookings.Count + 1,
            User = user,
            Event = ev,
            Status = BookingStatus.Active
        };

        Bookings.Add(booking);
        return booking;
    }

    public void CancelBooking(UserAccount user, int bookingId)
    {
        var booking = Bookings.FirstOrDefault(b => b.Id == bookingId && b.User.Id == user.Id);
        if (booking != null)
        {
            booking.Status = BookingStatus.Cancelled;
        }
    }

    public void AddEvent(UserAccount admin, EventItem ev)
    {
        if (admin.Role != UserRole.Admin) return;
        ev.Id = Events.Count + 1;
        Events.Add(ev);
    }

    public void EditEvent(UserAccount admin, int eventId, string title, DateTime date, string place)
    {
        if (admin.Role != UserRole.Admin) return;
        var ev = Events.FirstOrDefault(e => e.Id == eventId);
        if (ev == null) return;
        ev.Title = title;
        ev.Date = date;
        ev.Place = place;
    }

    public void RemoveEvent(UserAccount admin, int eventId)
    {
        if (admin.Role != UserRole.Admin) return;
        var ev = Events.FirstOrDefault(e => e.Id == eventId);
        if (ev != null)
        {
            Events.Remove(ev);
        }
    }

    public void ShowAllBookings(UserAccount admin)
    {
        if (admin.Role != UserRole.Admin) return;
        foreach (var b in Bookings)
        {
            Console.WriteLine($"{b.Id}: {b.User.Name} -> {b.Event.Title} [{b.Status}]");
        }
    }
}
