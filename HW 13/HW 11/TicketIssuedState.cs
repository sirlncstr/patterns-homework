using System;

public class TicketIssuedState : ITicketState
{
    private readonly TicketVendingMachine machine;

    public TicketIssuedState(TicketVendingMachine machine)
    {
        this.machine = machine;
    }

    public void ChooseTicket()
    {
        Console.WriteLine("Операция завершена. Начните новую покупку.");
        machine.CurrentMode = machine.IdleMode;
    }

    public void PutMoney(decimal amount)
    {
        Console.WriteLine("Операция завершена. Начните новую покупку.");
    }

    public void CancelOperation()
    {
        Console.WriteLine("Операция уже завершена.");
    }

    public void PrintTicket()
    {
        Console.WriteLine("Билет уже выдан.");
    }
}
