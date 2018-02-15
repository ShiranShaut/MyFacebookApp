using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FriendsController
{
    internal enum eFrinedsListChoice
    {
        RegularOrder,
        FirstNameOrder,
        LastNameOrder
    }

    public class FriendsFacade
    {
        private readonly FriendsManager r_FriendsManager = new FriendsManager();

        public List<User> GetUserFrinedsByOrderChoice(int i_CurrentChoice, User i_LoggedInUser)
        {
            return r_FriendsManager.GetUserFrinedsByOrderChoice((eFrinedsListChoice)i_CurrentChoice, i_LoggedInUser);
        }
    }
}