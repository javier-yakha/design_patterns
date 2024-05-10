using System;
namespace Mediator
{
    public interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(string message, User user);
        void SendMessage(string message, User sender, User receiver);
    }
}

