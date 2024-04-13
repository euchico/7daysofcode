namespace DayOne;

internal class DayOne
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista de Compra:");

        ShoppingList shoppingList = new ShoppingList();

        shoppingList.AddItem("Pão", 1);
        shoppingList.AddItem("Iogurte", 2);
        shoppingList.AddItem("Biscoito", 5);
        shoppingList.AddItem("Leite", 12);

        shoppingList.RemoveItem("Iogurte");

        shoppingList.ShowItens();
    }
}