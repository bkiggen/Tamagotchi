using System.Collections.Generic;
using System; 

namespace Tamagotchi.Models
{
    public class Friend
    {
        private string _name;
        private int _hunger = 50;
        private int _attention = 50;
        private int _rest = 50;
        private int _id;

        private static List<Friend> _friendList = new List<Friend> {};

        public Friend (string name)
        {
            _name = name;
            _id = _friendList.Count;
            _friendList.Add(this);
        }
        public static List<Friend> GetAll()
        {
            return _friendList;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetHunger()
        {
            return _hunger;
        }
        public int GetAttention()
        {
            return _attention;
        }
        public int GetRest()
        {
            return _rest;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }

        public void IncreaseHunger()
        {
            _hunger += 1;
        }
        public void IncreaseAttention()
        {
            _attention += 1;
        }
        public void IncreaseRest()
        {
            _rest += 1;
        }
        public static void ClearAll()
        {
            _friendList.Clear();
        }
        public int GetId()
        {
            return _id;
        }
        public static Friend Find(int searchId)
        {
            return _friendList[searchId-1];
        }
    }
}