using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using transportApp.Models;

namespace transportApp.Models
{
    public static class UserModel
    {
        public static List<User> users;

        static UserModel()
        {
            User user = new User("jan", "test");
            User user2 = new User("djenny", "test", "hueresohn");
            users = new List<User>();
            users.Add(user);
            users.Add(user2);
        }

        public static void insert(User user)
        {
            users.Add(user);
        }

        public static void remove(User user)
        {
            users.Remove(user);
        }
        public static void modify(User user, User newUser)
        {
            users[users.IndexOf(user)] = newUser;
        }


    }
}