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
        [TestMethod]
        public void GetHunger_ReturnsHunger_Int()
        {
            Friend newFriend = new Friend("Harry");
            int result = newFriend.GetHunger();
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void GetAttention_ReturnsAttention_Int()
        {
            Friend newFriend = new Friend("Harry");
            int result = newFriend.GetAttention();
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void GetRest_ReturnsRest_Int()
        {
            Friend newFriend = new Friend("Harry");
            int result = newFriend.GetRest();
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void IncreaseHunger_ReturnsHungerPlusOne_Int()
        {
            Friend newFriend = new Friend("Harry");
            newFriend.IncreaseHunger();
            int result = newFriend.GetHunger();
            Assert.AreEqual(51, result);
        }
        [TestMethod]
        public void IncreaseRest_ReturnsRestPlusOne_Int()
        {
            Friend newFriend = new Friend("Harry");
            newFriend.IncreaseRest();
            int result = newFriend.GetRest();
            Assert.AreEqual(51, result);
        }
        [TestMethod]
        public void IncreaseAttention_ReturnsAttentionPlusOne_Int()
        {
            Friend newFriend = new Friend("Harry");
            newFriend.IncreaseAttention();
            int result = newFriend.GetAttention();
            Assert.AreEqual(51, result);
        }

    }
}