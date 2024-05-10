using System;
namespace Mediator
{
    class ChatMediatorImpl : IChatMediator
    {
        // a list of users so the Mediator can communicate 
        // (and reference the users) with them for example 
        // when a new user joins the chat or leaves
        private List<User> userList; 
        public ChatMediatorImpl()
        {
            userList = new List<User>();
        }
        public void AddUser(User user)
        {   
            userList.Add(user); //we add a user to the list
        }
        public void SendMessage(string message, User user) //this is the user who sends a message.
        {
            foreach (User u in userList)
            {
                // Ensure the user does not receive their own message
                if (u != user)
                {
                    u.ReceiveMessage(message, user);   
                }
            }
        }
        public void SendMessage(string message, User sender, User receiver)
        {
            receiver.ReceiveMessage(message, sender);
        }
    }
}

