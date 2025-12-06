using System;

class Program
{
    static void Main()
    {
        var process = new OrderProcess();

        process.SelectProducts();
        process.FillOrder();

        bool paid = process.PayOrder();

        if (paid)
        {
            process.ProcessOrder();
            process.ShipOrder();
        }
        else
        {
            process.CancelOrder();
        }
    }
}
