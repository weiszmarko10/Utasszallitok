namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<jarmuadat> jarmuadatok= new();
            foreach (var sor in File.ReadAllLines("utasszallitok.txt").Skip(1))
            {
                jarmuadatok.Add(new jarmuadat(sor));
            }
        }
    }
}
