﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private decimal prezzo;
        private int iva;

        public Prodotto(int codice, string nome, string descrizione, decimal prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int GetCodice { get { return codice; } }

        public string GetSetNome { get; set; }

        public string GetSetDescrizione { get; set; }

        public decimal GetSetPrezzo { get; set; }

        public int GetSetIva { get; set; }

    }
}