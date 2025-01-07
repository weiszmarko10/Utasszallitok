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
            Console.WriteLine($"4.Feladat: Ennyi darab repűlőgép van : {jarmuadatok.Count}");

            int boenig = 0;
            foreach (var r in jarmuadatok)
            {
                string[] b = r.Típus.Split('-');
                boenig += Math.Abs(int.Parse(b[0]) - int.Parse(b[1]);
            }
            Console.WriteLine($"5.Feladat: {boeing} Ennyi darab repűlőgép van");
        }
    }
}
