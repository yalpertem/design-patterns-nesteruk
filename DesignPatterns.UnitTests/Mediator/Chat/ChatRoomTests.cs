using DesignPatterns.Mediator.Chat;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Mediator.Chat
{
    [TestFixture]
    public class ChatRoomTests
    {
        [Test]
        public void ChatLogCount_PrivateMessage_SetsCorrectMessageCount()
        {
            var room = new ChatRoom();
            var john = new Person("John");
            var jane = new Person("Jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hi");
            jane.Say("oh, hey john");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "welcome");

            Assert.That(simon.ChatLogCount, Is.EqualTo(1));
        }

        [Test]
        public void ChatLogCount_PublicAndPrivateMessage_SetsCorrectMessageCount()
        {
            var room = new ChatRoom();
            var john = new Person("John");
            var jane = new Person("Jane");
            var simon = new Person("Simon");

            room.Join(john);
            room.Join(jane);
            room.Join(simon);

            john.Say("hi");
            jane.Say("oh, hey john");
            simon.Say("hi everyone!");
            jane.PrivateMessage("Simon", "welcome");

            Assert.That(simon.ChatLogCount, Is.EqualTo(3));
        }
    }
}
