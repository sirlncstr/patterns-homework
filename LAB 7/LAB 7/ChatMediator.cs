using System.Collections.Generic;

namespace HW_Patterns_Behavioral
{
    public class ChatMediator : IMediator
    {
        private List<Colleague> _colleagues;

        public ChatMediator()
        {
            _colleagues = new List<Colleague>();
        }

        public void RegisterColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void SendMessage(string message, Colleague sender)
        {
            foreach (var colleague in _colleagues)
            {
                if (colleague != sender)
                {
                    colleague.ReceiveMessage(message);
                }
            }
        }
    }
}