using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class jarmuadatok
    {
        public string Típus { get; set; }
        public int Év { get; set; }
        public string Utas { get; set; }
        public string Személyzet { get; set; }
        public string Utazósebbesség { get; set; }
        public int Felszállótömeg { get; set; }
        public string Fesztáv { get; set; }

        public jarmuadatok(string sor)
        {
            string[] s = sor.Split(';');
            Típus = s[0];
            Év = int.Parse(s[6]);
            Utas = s[0];
            Személyzet = s[0];
            Utazósebbesség = s[0];
            Felszállótömeg = int.Parse(s[6]);
            Fesztáv = s[0];




        }
    }
}
