using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class FriendTest : IDisposable
    {
        public void Dispose()
        {
            Friend.ClearAll();
        }
        [TestMethod]
        public void FriendConstructor_CreatesInstanceOfFriend_Friend()
        {
            Friend newFriend = new Friend("Harry");
            Assert.AreEqual(typeof(Friend), newFriend.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            Friend newFriend = new Friend("Harry");
            string result = newFriend.GetName();
            Assert.AreEqual("Harry", result);
        }

    }
}