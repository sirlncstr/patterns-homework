using System;

public class OrderProcess
{
    public void SelectProducts()
    {
        Console.WriteLine("Выбор товаров и добавление в корзину.");
    }

    public void FillOrder()
    {
        Console.WriteLine("Оформление заказа: ввод данных покупателя.");
    }

    public bool PayOrder()
    {
        Console.WriteLine("Оплата заказа.");
        bool paymentOk = true;
        return paymentOk;
    }

    public void ProcessOrder()
    {
        Console.WriteLine("Обработка заказа на складе.");
    }

    public void ShipOrder()
    {
        Console.WriteLine("Отправка заказа покупателю.");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Заказ отменён.");
    }
}
