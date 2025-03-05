
using System;

class ItemNode
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryLinkedList
{
    private ItemNode head;

    public void AddItem(string itemName, int itemID, int quantity, double price, int? position = null)
    {
        ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
        if (head == null || position == 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            ItemNode temp = head;
            int count = 0;
            while (temp.Next != null && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
    }

    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("No items available!");
            return;
        }
        if (head.ItemID == itemID)
        {
            head = head.Next;
            Console.WriteLine("Item removed successfully.");
            return;
        }
        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemID != itemID)
            temp = temp.Next;
        if (temp.Next == null)
        {
            Console.WriteLine("Item not found!");
            return;
        }
        temp.Next = temp.Next.Next;
        Console.WriteLine("Item removed successfully.");
    }

    public void UpdateQuantity(int itemID, int newQuantity)
    {
        ItemNode temp = head;
        while (temp != null && temp.ItemID != itemID)
            temp = temp.Next;
        if (temp != null)
        {
            temp.Quantity = newQuantity;
            Console.WriteLine("Quantity updated successfully.");
        }
        else
        {
            Console.WriteLine("Item not found!");
        }
    }

    public void SearchItem(int? itemID = null, string itemName = null)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if ((itemID != null && temp.ItemID == itemID) || (itemName != null && temp.ItemName == itemName))
                Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.Next;
        }
    }

    public void DisplayInventory()
    {
        ItemNode temp = head;
        double totalValue = 0;
        while (temp != null)
        {
            Console.WriteLine($"Item ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }

    public void SortInventory(bool byPrice = false, bool ascending = true)
    {
        if (head == null)
            return;
        bool swapped;
        do
        {
            swapped = false;
            ItemNode temp = head;
            while (temp.Next != null)
            {
                bool condition = byPrice ? (ascending ? temp.Price > temp.Next.Price : temp.Price < temp.Next.Price) :
                                           (ascending ? string.Compare(temp.ItemName, temp.Next.ItemName) > 0 : string.Compare(temp.ItemName, temp.Next.ItemName) < 0);
                if (condition)
                {
                    (temp.ItemName, temp.Next.ItemName) = (temp.Next.ItemName, temp.ItemName);
                    (temp.ItemID, temp.Next.ItemID) = (temp.Next.ItemID, temp.ItemID);
                    (temp.Quantity, temp.Next.Quantity) = (temp.Next.Quantity, temp.Quantity);
                    (temp.Price, temp.Next.Price) = (temp.Next.Price, temp.Price);
                    swapped = true;
                }
                temp = temp.Next;
            }
        } while (swapped);
    }
}

class Program
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();
        inventory.AddItem("Laptop", 101, 10, 800);
        inventory.AddItem("Mouse", 102, 50, 20);
        inventory.AddItem("Keyboard", 103, 30, 50, position: 1);
        inventory.DisplayInventory();
        inventory.UpdateQuantity(102, 45);
        inventory.DisplayInventory();
        inventory.SortInventory(byPrice: true, ascending: false);
        inventory.DisplayInventory();
        inventory.RemoveItem(101);
        inventory.DisplayInventory();
    }
}

