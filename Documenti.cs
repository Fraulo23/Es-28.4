using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._4
{
    enum Stato
    {
        InPrestito,
        Disponibile
    }
    internal class Documenti
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public string Settore { get; set; }
        public Stato stato { get; set; }
        public string PosizioneScaffale { get; set; }
        public string Autore { get; set; }

    }
}
