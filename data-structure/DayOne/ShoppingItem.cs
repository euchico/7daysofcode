namespace DayOne;

internal class ShoppingItem
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public int ItemAmount { get; set;}

    public ShoppingItem(string ItemName, int ItemAmount)
    {
        this.ItemName = ItemName;
        this.ItemAmount = ItemAmount;
    }


}
