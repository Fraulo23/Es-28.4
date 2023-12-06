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
    enum Settore
    {
        Storia,
        Matematica,
        Economia
    }
    internal class Documenti
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public Settore settore { get; set; }
        public Stato stato { get; set; }
        public string PosizioneScaffale { get; set; }
        public List<Autore> Autori { get; set; }

    }
}
