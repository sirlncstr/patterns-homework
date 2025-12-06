using System;

public class IdleModeState : ITicketState
{
    private readonly TicketVendingMachine machine;

    public IdleModeState(TicketVendingMachine machine)
    {
        this.machine = machine;
    }

    public void ChooseTicket()
    {
        Console.WriteLine("Билет выбран. Внесите деньги.");
        machine.CurrentMode = machine.AwaitingPaymentMode;
    }

    public void PutMoney(decimal amount)
    {
        Console.WriteLine("Сначала нужно выбрать билет.");
    }

    public void CancelOperation()
    {
        Console.WriteLine("Нет активной операции.");
    }

    public void PrintTicket()
    {
        Console.WriteLine("Нет активной операции.");
    }
}
