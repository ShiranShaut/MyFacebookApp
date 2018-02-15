using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FriendsController
{
    internal class FriendsManager
    {
        public List<User> GetUserFrinedsByOrderChoice(eFrinedsListChoice i_CurrentChoice, User i_LoggedInUser)
        {
            List<User> userFriends = null;

            if (i_LoggedInUser.Friends.Count > 0)
            {
                switch (i_CurrentChoice)
                {
                    case eFrinedsListChoice.RegularOrder:
                        {
                            userFriends = fetchFriendsByRegularOrder(i_LoggedInUser);
                            break;
                        }

                    case eFrinedsListChoice.FirstNameOrder:
                        {
                            userFriends = fetchFriendsByFirstNameOrder(i_LoggedInUser);
                            break;
                        }

                    case eFrinedsListChoice.LastNameOrder:
                        {
                            userFriends = fetchFriendsByLastNameOrder(i_LoggedInUser);
                            break;
                        }
                }
            }

            return userFriends;
        }

        private List<User> fetchFriendsByRegularOrder(User i_LoggedInUser)
        {
            return SortAndCopyService.CopyFriendsToList(i_LoggedInUser.Friends);
        }

        private List<User> fetchFriendsByFirstNameOrder(User i_LoggedInUser)
        {
            return SortAndCopyService.SortFriendsByFirstName(i_LoggedInUser.Friends);
        }

        private List<User> fetchFriendsByLastNameOrder(User i_LoggedInUser)
        {
            return SortAndCopyService.SortFriendsByLastName(i_LoggedInUser.Friends);
        }
    }
}