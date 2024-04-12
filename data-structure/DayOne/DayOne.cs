namespace DayOne;

internal class DayOne
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista de Compra:");

        ShoppingItem[] listaDeCompra = new ShoppingItem[] {null, null, null, null, null };

        ShoppingItem item1 = new ShoppingItem("Pão", 1);
        ShoppingItem item2 = new ShoppingItem("Iogurte", 2);
        ShoppingItem item3 = new ShoppingItem("Biscoito", 5);
        ShoppingItem item4 = new ShoppingItem("Leite", 12);


        listaDeCompra[0] = item1;
        listaDeCompra[1] = item2;
        listaDeCompra[2] = item3;
        listaDeCompra[3] = item4;

        listaDeCompra[1] = null;

        foreach (var item in listaDeCompra)
        {
            if (item != null)
            {
                Console.WriteLine(item.ItemAmount + " " + item.ItemName);
            }
        }
    }
}