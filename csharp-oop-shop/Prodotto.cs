using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codice;
        public string nome;
        public string descrizione;
        public decimal prezzo;
        public int iva;

        public Prodotto(int codice, string nome, string descrizione, decimal prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int getCodice()
        {
            return codice;
        }

    }
}
