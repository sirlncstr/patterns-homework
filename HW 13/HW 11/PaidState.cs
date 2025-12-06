using System;

public class PaidState : ITicketState
{
    private readonly TicketVendingMachine machine;

    public PaidState(TicketVendingMachine machine)
    {
        this.machine = machine;
    }

    public void ChooseTicket()
    {
        Console.WriteLine("Билет уже оплачен.");
    }

    public void PutMoney(decimal amount)
    {
        Console.WriteLine("Средств уже достаточно.");
    }

    public void CancelOperation()
    {
        Console.WriteLine("Операция отменена. Средства возвращены.");
        machine.CurrentAmount = 0;
        machine.CurrentMode = machine.OperationCanceledMode;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Выдача билета...");
        machine.CurrentAmount -= machine.CurrentTicketPrice;
        machine.CurrentMode = machine.TicketIssuedMode;
    }
}
