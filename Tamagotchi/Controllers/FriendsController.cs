using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

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
        public ActionResult Create(string FriendName)
        {
            Friend myFriend = new Friend(FriendName);
            return RedirectToAction("Index");
        }
        
    }
}