using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mis221_cgi
{
    public class User
    {
        private string username;
        private string password;
        private int userID;
        private static int currUser;


        public void SetUserName(string username){
            this.username = username;
        }
        public string GetUserName(){
            return username;
        }
        public void SetPassword(string password){
            this.password = password;
        }
        public string GetPassword(){
            return password;
        }

        public void SetUserID(int userID){
            this.userID = userID;
        }
        public int GetUserID(){
            return userID;
        }
        public void SetCurrUser(int currUser){
            User.currUser = currUser;
        }
        public int GetCurrUser(){
            return User.currUser;
        }
    }
}