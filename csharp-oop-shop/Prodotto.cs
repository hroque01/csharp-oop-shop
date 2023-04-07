using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        //Costruttore del prodotto
        public Prodotto(int codice, string nome, string descrizione, decimal prezzo, int iva)
        {
            //vado a dichiarare che al codice verra' generato un codice random
            this.codice = GeneraCodice();
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        //funzione che generera' un codice random
        private int GeneraCodice()
        {
            Random rnd = new Random();
            return rnd.Next(50,999);
        }

        //GET & SET
        public string Nome { get { return nome; } set { nome = value; } }
        public string Descrizione { get {  return descrizione; } set {  descrizione = value; } }
        public decimal Prezzo { get { return prezzo;  } set { prezzo = value; } }
        public int Iva { get {  return iva; } set {  iva = value; } }
       
    }
}
 