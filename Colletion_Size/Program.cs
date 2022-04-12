using System.Collections;

class Program
{
    //Definindo o numero total de uma lista dinâmica
    private const int MAXITEMS = 35;
    private static ArrayList arrayList = new();
    private static Queue<int> queue = new();
    private static Stack<int> stack = new();
    private static List<int> list = new();
    private static Dictionary<int, int> dictionary = new();

    private static void InitCollectionSize()
    {
        //Definindo a capacidade da lista para a mesma não redimensionar em memória
        list.Capacity = MAXITEMS;   

    }
    private static void FillList()
    {
        //Preenchendo com membros até o seu limite
        for (int i = 0; i < MAXITEMS; i++)
        {
            list.Add(i);
        }
    }
    static void Main(string[] args)
    {
        InitCollectionSize();
        FillList();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---- Capacity----");
        Console.WriteLine(list.Capacity);
        Console.WriteLine(list.Count);
    }
}