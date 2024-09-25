using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifichePauseW
{
    public class Sveglia
    {
        public int Ora { get; set; }
        public int Minuti { get; set; }
        public string Titolo { get; set; }
        public string Testo { get; set; }
        public bool Eseguita { get; set; } = false;
    }

    public class Sveglie
    {
        public List<Sveglia> lista { get; set; } = new List<Sveglia>();
    }
}
