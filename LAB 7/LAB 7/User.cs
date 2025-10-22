using System;

namespace HW_Patterns_Behavioral
{
    public class User : Colleague
    {
        private string _name;

        public User(IMediator mediator, string name) : base(mediator)
        {
            _name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{_name} отправляет сообщение: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} получил сообщение: {message}");
        }
    }
}