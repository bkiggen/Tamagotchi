using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Friend
    {
        private string _name;
        private int _hunger;
        private int _attention;
        private int _rest;

        private static List<Friend> _friendList = new List<Friend> {};

        public Friend (string name)
        {
            _name = name;
            _friendList.Add(this);
        }
        public string GetName()
        {
            return _name;
        }
        public string GetHunger()
        {
            return _Hunger;
        }
        public string GetAttention()
        {
            return _Attention;
        }
        public string GetRest()
        {
            return _Rest;
        }
        public string SetName(string newName)
        {
            _name = newName;
        }

        public void SetHunger()
        {
            _hunger += 1;
        }
        public void SetAttention()
        {
            _Attention += 1;
        }
        public void SetRest()
        {
            _Rest += 1;
        }
        public static void ClearAll()
        {
            _friendList.Clear();
        }
    }
}