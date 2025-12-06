using System;

class Program
{
    static void Main()
    {
        var machine = new TicketVendingMachine();

        machine.ChooseTicket();
        machine.PutMoney(20);
        machine.PutMoney(40);
        machine.PrintTicket();
    }
}
