using System;

namespace HW7_BehavioralPatterns
{
    public class User
    {
        public string Name { get; private set; }
        protected IMediator _mediator;

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.RegisterUser(this);
        }

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public void SendPrivate(string recipientName, string message)
        {
            _mediator.SendPrivateMessage(message, this, recipientName);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"({Name}'s chat) {message}");
        }
    }
}