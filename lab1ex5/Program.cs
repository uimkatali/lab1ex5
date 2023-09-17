namespace lab1ex1
{
    /*
     Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double[] strings = { a, b };
            Array.Sort(strings);    
            foreach (double item in strings) Console.WriteLine(item);
        }
    }
}