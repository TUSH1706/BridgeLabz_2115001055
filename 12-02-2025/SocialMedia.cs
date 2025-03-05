
using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public UserNode Next;

    public UserNode(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public void AddUser(int userID, string name, int age)
    {
        UserNode newNode = new UserNode(userID, name, age);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
    }

    public void AddFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 != null && user2 != null && user1.UserID != user2.UserID)
        {
            if (!user1.FriendIDs.Contains(userID2))
                user1.FriendIDs.Add(userID2);
            if (!user2.FriendIDs.Contains(userID1))
                user2.FriendIDs.Add(userID1);
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
        }
    }

    public List<int> FindMutualFriends(int userID1, int userID2)
    {
        UserNode user1 = FindUser(userID1);
        UserNode user2 = FindUser(userID2);
        if (user1 == null || user2 == null) return new List<int>();
        return user1.FriendIDs.FindAll(friendID => user2.FriendIDs.Contains(friendID));
    }

    public void DisplayFriends(int userID)
    {
        UserNode user = FindUser(userID);
        if (user != null)
        {
            Console.WriteLine("Friends of " + user.Name + ":");
            foreach (int friendID in user.FriendIDs)
            {
                UserNode friend = FindUser(friendID);
                Console.WriteLine(friend != null ? "- " + friend.Name + " (ID: " + friend.UserID + ")" : "Unknown Friend");
            }
        }
    }

    public void SearchUser(string name = null, int? userID = null)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if ((name != null && temp.Name == name) || (userID != null && temp.UserID == userID))
            {
                Console.WriteLine("User ID: " + temp.UserID + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Friends: " + temp.FriendIDs.Count);
            }
            temp = temp.Next;
        }
    }

    public int CountFriends(int userID)
    {
        UserNode user = FindUser(userID);
        return user != null ? user.FriendIDs.Count : 0;
    }

    private UserNode FindUser(int userID)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        SocialMedia network = new SocialMedia();
        network.AddUser(1, "Alice", 25);
        network.AddUser(2, "Bob", 30);
        network.AddUser(3, "Charlie", 28);
        network.AddFriend(1, 2);
        network.AddFriend(2, 3);
        network.DisplayFriends(1);
        network.DisplayFriends(2);
        List<int> mutualFriends = network.FindMutualFriends(1, 3);
        Console.WriteLine("Mutual Friends between Alice and Charlie: " + string.Join(", ", mutualFriends));
        network.SearchUser(name: "Alice");
        Console.WriteLine("Total friends of Bob: " + network.CountFriends(2));
    }
}

