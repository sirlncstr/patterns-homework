namespace HW_Patterns_Behavioral
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void ReceiveMessage(string message);
    }
}