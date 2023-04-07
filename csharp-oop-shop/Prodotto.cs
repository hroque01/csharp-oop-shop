using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        private decimal iva;

        //Costruttore del prodotto
        public Prodotto(string nome, string descrizione, decimal prezzo, decimal iva)
        {
            //vado a dichiarare che al codice verra' generato un codice random
            codice = GetNumRam();

            //richiamo i GETSET mettendoli al posto di this.
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;

        }

        //Metodo per generare numeri random
        public int GetNumRam()
        {
            Random rnd = new Random();
            return rnd.Next(50, 999);
        }

        //Metodo per generare Prezzo con Iva
        public decimal PrezzoIva()
        {
            decimal PrezzoIva = Prezzo += Prezzo * Iva / 100;
            return PrezzoIva;
        }

        //Metodo per concatenare Codice+Nome
        public string NomeCompleto()
        {
            return codice.ToString() + nome;
           
        }


        //GET & SET
        public int Codice { get { return codice; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Descrizione { get {  return descrizione; } set {  descrizione = value; } }
        public decimal Prezzo { get { return prezzo;  } set { prezzo = value; } }
        public decimal Iva { get {  return iva; } set {  iva = value; } }

        


    }
}
 