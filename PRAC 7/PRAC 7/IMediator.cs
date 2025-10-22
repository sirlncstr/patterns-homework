using System.Collections.Generic;

namespace HW_Patterns_Advanced
{
    public interface IMediator
    {
        void SendMessage(string channel, string message, IUser sender);
        void RegisterUser(string channel, IUser user);
    }
}