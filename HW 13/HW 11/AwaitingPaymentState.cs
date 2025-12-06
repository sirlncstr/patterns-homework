using System;

public class AwaitingPaymentState : ITicketState
{
    private readonly TicketVendingMachine machine;

    public AwaitingPaymentState(TicketVendingMachine machine)
    {
        this.machine = machine;
    }

    public void ChooseTicket()
    {
        Console.WriteLine("Билет уже выбран.");
    }

    public void PutMoney(decimal amount)
    {
        machine.CurrentAmount += amount;
        Console.WriteLine($"Текущая сумма: {machine.CurrentAmount}");

        if (machine.CurrentAmount >= machine.CurrentTicketPrice)
        {
            Console.WriteLine("Средств достаточно.");
            machine.CurrentMode = machine.PaidMode;
        }
    }

    public void CancelOperation()
    {
        Console.WriteLine("Операция отменена. Средства возвращены.");
        machine.CurrentAmount = 0;
        machine.CurrentMode = machine.OperationCanceledMode;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Недостаточно средств для выдачи билета.");
    }
}
