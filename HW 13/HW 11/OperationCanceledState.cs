using System;

public class OperationCanceledState : ITicketState
{
    private readonly TicketVendingMachine machine;

    public OperationCanceledState(TicketVendingMachine machine)
    {
        this.machine = machine;
    }

    public void ChooseTicket()
    {
        Console.WriteLine("Начинаем новую операцию.");
        machine.CurrentMode = machine.IdleMode;
    }

    public void PutMoney(decimal amount)
    {
        Console.WriteLine("Операция отменена. Сначала выберите билет.");
    }

    public void CancelOperation()
    {
        Console.WriteLine("Операция уже отменена.");
    }

    public void PrintTicket()
    {
        Console.WriteLine("Транзакция отменена, билет не будет выдан.");
    }
}
