namespace DayOne;

internal class ShoppingItem
{
    public string ItemName { get; set; }
    public int ItemAmount { get; set;}

    public ShoppingItem(string itemName, int itemAmount)
    {
        this.ItemName = itemName;
        this.ItemAmount = itemAmount;
    }
}
