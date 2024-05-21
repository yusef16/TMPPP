using System;
using System.Net;

namespace Tmpp
{
 
    //Singleton
    public class CurrentUser
    {
        private static CurrentUser instance = null;
        private string currentUser;


        private CurrentUser()
        {

        }

        public static CurrentUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CurrentUser();
                }
                return instance;
            }
        }

        public void SetCurrentUser(string user)
        {
            currentUser = user;
        }

        public string GetCurrentUser()
        {
            return currentUser;
        }
    }
}