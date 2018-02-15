using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FriendsController
{
    internal static class SortAndCopyService
    {
        public static List<User> SortFriendsByFirstName(FacebookObjectCollection<User> i_Friends)
        {
            List<User> friends = CopyFriendsToList(i_Friends);

            friends.Sort(delegate(User frined1, User frined2) { return frined1.Name.CompareTo(frined2.Name); });

            return friends;
        }

        public static List<User> SortFriendsByLastName(FacebookObjectCollection<User> i_Friends)
        {
            List<User> friends = CopyFriendsToList(i_Friends);

            friends.Sort(delegate(User frined1, User frined2) { return frined1.LastName.CompareTo(frined2.LastName); });

            return friends;
        }
        
        public static List<User> CopyFriendsToList(FacebookObjectCollection<User> i_CopyFromFriends)
        {
            List<User> copyFriendsList = new List<User>();

            foreach (User friend in i_CopyFromFriends)
            {
                copyFriendsList.Add(friend);
            }

            return copyFriendsList;
        }
    }
}