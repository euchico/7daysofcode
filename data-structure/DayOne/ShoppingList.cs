namespace DayOne;

internal class ShoppingList
{
    public List<ShoppingItem> ListItems { get; set; }

    public ShoppingList() 
    {
        ListItems = new List<ShoppingItem>();
    }

    public void AddItem (string itemName, int itemAmount)
    {
        ShoppingItem item = new ShoppingItem(itemName, itemAmount);

        ListItems.Add(item);
    }

    public void RemoveItem (string itemName)
    {
        ShoppingItem item = ListItems.Single(x => x.ItemName == itemName);

        ListItems.Remove(item);
    }

    public void ShowItens ()
    {
        foreach (var item in ListItems)
        {
            if (item != null)
            {
                Console.WriteLine(item.ItemAmount + " " + item.ItemName);
            }
        }
    }
}
