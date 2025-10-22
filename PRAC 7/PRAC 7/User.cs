using System;

namespace HW_Patterns_Advanced
{
    public class User : IUser
    {
        public string Name { get; private set; }
        private IMediator _mediator;

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void JoinChannel(string channel)
        {
            _mediator.RegisterUser(channel, this);
        }

        public void Send(string channel, string message)
        {
            Console.WriteLine($"... {Name} отправляет в '{channel}': {message} ...");
            _mediator.SendMessage(channel, message, this);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"(Чат {Name}) > [{senderName}]: {message}");
        }
    }
}