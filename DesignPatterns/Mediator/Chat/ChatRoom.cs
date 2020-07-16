using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Mediator.Chat
{
    public class ChatRoom
    {
        private readonly List<Person> _people = new List<Person>();

        public void Join(Person p)
        {
            var joinMsg = $"{p.Name} joins the chat";
            Broadcast("room", joinMsg);

            p.Room = this;
            _people.Add(p); 
        }

        public void Broadcast(string source, string message)
        {
            foreach (var p in _people)
            {
                if (p.Name != source)
                {
                    p.Receive(source, message);
                }
            }
        }

        public void Message(string source, string destination, string message)
        {
            _people.FirstOrDefault(
                x => x.Name == destination)?.Receive(source, message);
        }
    }
}
