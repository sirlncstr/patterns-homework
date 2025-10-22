using System;
using System.Collections.Generic;
using System.Linq;

namespace HW7_BehavioralPatterns
{
    public class ChatRoom : IMediator
    {
        private List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            if (!_users.Contains(user))
            {
                _users.Add(user);
                this.SendMessage($"[{user.Name} has joined the chat]", user, true);
            }
        }

        public void UnregisterUser(User user)
        {
            if (_users.Contains(user))
            {
                _users.Remove(user);
                this.SendMessage($"[{user.Name} has left the chat]", user, true);
            }
        }

        public void SendMessage(string message, User sender)
        {
            SendMessage(message, sender, false);
        }

        private void SendMessage(string message, User sender, bool isSystemMessage)
        {
            if (!isSystemMessage && !_users.Contains(sender))
            {
                Console.WriteLine($"[Error] User {sender.Name} is not registered.");
                return;
            }

            foreach (var user in _users)
            {
                if (user != sender)
                {
                    string finalMessage = isSystemMessage ? message : $"[{sender.Name}]: {message}";
                    user.Receive(finalMessage);
                }
            }
        }

        public void SendPrivateMessage(string message, User sender, string recipientName)
        {
            if (!_users.Contains(sender))
            {
                Console.WriteLine($"[Error] User {sender.Name} is not registered.");
                return;
            }

            User recipient = _users.FirstOrDefault(u => u.Name == recipientName);
            if (recipient != null)
            {
                recipient.Receive($"[Private from {sender.Name}]: {message}");
            }
            else
            {
                sender.Receive($"[System] User {recipientName} not found.");
            }
        }
    }
}