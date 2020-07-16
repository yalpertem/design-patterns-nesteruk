using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Chat
{
    public class Person
    {
        public string Name { get; set; }
        public ChatRoom Room { get; set; }

        private readonly List<string> chatLog = new List<string>();

        public Person(string name)
        {
            Name = name;
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}:{message}";
            chatLog.Add(s);
            Console.WriteLine($"[{Name}'s chat session] {s}");
        }

        public int ChatLogCount { get => chatLog.Count; }

    }
}
