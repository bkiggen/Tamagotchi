using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Controllers
{
    public class FriendsController : Controller
    {
        [HttpGet("/friends")]
        public ActionResult Index()
        {
            List<Friend> allFriends = Friend.GetAll();
            return View(allFriends);
        }
        [HttpPost("/friends")]
        public ActionResult Create(string name)
        {
            Friend myFriend = new Friend(name);
            return RedirectToAction("Index");
        }
        [HttpPost("/friends/{id}/hunger")]
        public ActionResult UpdateHunger(int id)
        {
            Console.WriteLine(id);
            List<Friend> allFriends = Friend.GetAll();
            Friend newFriend = allFriends[id];
            newFriend.IncreaseHunger();

            return RedirectToAction("Index");
        }
        [HttpPost("/friends/{id}/attention")]
        public ActionResult UpdateAttention(int id)
        {
            Console.WriteLine(id);
            List<Friend> allFriends = Friend.GetAll();
            Friend newFriend = allFriends[id];
            newFriend.IncreaseAttention();

            return RedirectToAction("Index");
        }
        [HttpPost("/friends/{id}/rest")]
        public ActionResult UpdateRest(int id)
        {
            Console.WriteLine(id);
            List<Friend> allFriends = Friend.GetAll();
            Friend newFriend = allFriends[id];
            newFriend.IncreaseRest();

            return RedirectToAction("Index");
        }
        
    }
}