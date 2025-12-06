public interface ITicketState
{
    void ChooseTicket();
    void PutMoney(decimal amount);
    void CancelOperation();
    void PrintTicket();
}
