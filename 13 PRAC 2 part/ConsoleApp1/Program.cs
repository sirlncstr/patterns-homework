using System;

class Program
{
    static void Main()
    {
        var system = new EventBookingSystem();

        var admin = new UserAccount { Id = 1, Name = "Admin", Role = UserRole.Admin };
        var user = new UserAccount { Id = 2, Name = "User", Role = UserRole.RegisteredUser };
        var guest = new UserAccount { Id = 3, Name = "Guest", Role = UserRole.Guest };

        system.Users.Add(admin);
        system.Users.Add(user);
        system.Users.Add(guest);

        system.AddEvent(admin, new EventItem
        {
            Title = "Концерт",
            Date = DateTime.Now.AddDays(1),
            Place = "Зал 1"
        });

        system.AddEvent(admin, new EventItem
        {
            Title = "Лекция",
            Date = DateTime.Now.AddDays(2),
            Place = "Аудитория 2"
        });

        system.ShowEvents();

        var booking = system.CreateBooking(user, 1);
        if (booking != null)
        {
            Console.WriteLine($"Бронирование создано: {booking.Id}");
        }

        system.ShowAllBookings(admin);

        if (booking != null)
        {
            system.CancelBooking(user, booking.Id);
        }

        system.ShowAllBookings(admin);
    }
}
