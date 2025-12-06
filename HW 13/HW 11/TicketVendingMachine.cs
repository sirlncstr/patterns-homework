public class TicketVendingMachine
{
    public ITicketState IdleMode { get; }
    public ITicketState AwaitingPaymentMode { get; }
    public ITicketState PaidMode { get; }
    public ITicketState TicketIssuedMode { get; }
    public ITicketState OperationCanceledMode { get; }

    public ITicketState CurrentMode { get; set; }

    public decimal CurrentAmount { get; set; }
    public decimal CurrentTicketPrice { get; set; } = 50m;

    public TicketVendingMachine()
    {
        IdleMode = new IdleModeState(this);
        AwaitingPaymentMode = new AwaitingPaymentState(this);
        PaidMode = new PaidState(this);
        TicketIssuedMode = new TicketIssuedState(this);
        OperationCanceledMode = new OperationCanceledState(this);

        CurrentMode = IdleMode;
    }

    public void ChooseTicket() => CurrentMode.ChooseTicket();
    public void PutMoney(decimal amount) => CurrentMode.PutMoney(amount);
    public void CancelOperation() => CurrentMode.CancelOperation();
    public void PrintTicket() => CurrentMode.PrintTicket();
}
