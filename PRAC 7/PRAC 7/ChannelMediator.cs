using System;
using System.Collections.Generic;

namespace HW_Patterns_Advanced
{
    public class ChannelMediator : IMediator
    {
        private Dictionary<string, List<IUser>> _channels;

        public ChannelMediator()
        {
            _channels = new Dictionary<string, List<IUser>>();
        }

        public void RegisterUser(string channel, IUser user)
        {
            if (!_channels.ContainsKey(channel))
            {
                _channels[channel] = new List<IUser>();
            }

            if (!_channels[channel].Contains(user))
            {
                _channels[channel].Add(user);
                this.SendMessage(channel, $"[{user.Name} присоединился к каналу]", user);
            }
        }

        public void SendMessage(string channel, string message, IUser sender)
        {
            if (_channels.ContainsKey(channel))
            {
                if (!_channels[channel].Contains(sender))
                {
                    Console.WriteLine($"[ОШИБКА: {sender.Name} не состоит в канале '{channel}']");
                    return;
                }

                foreach (var user in _channels[channel])
                {
                    if (user != sender)
                    {
                        user.ReceiveMessage(message, sender.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine($"[ОШИБКА: Канал '{channel}' не существует]");
            }
        }
    }
}