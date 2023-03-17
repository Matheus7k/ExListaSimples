using ExListaSimples;

internal class Program
{
    private static void Main(string[] args)
    {
        ListaItem lista = new();

        Item item = new(21);

        lista.Insert(item);

        item = new(25);
        lista.Insert(item);

        item = new(22);
        lista.Insert(item);

        item = new(23);
        lista.Insert(item);

        item = new(40);
        lista.Insert(item);

        item = new(10);
        lista.Insert(item);

        lista.Print();

    }
}