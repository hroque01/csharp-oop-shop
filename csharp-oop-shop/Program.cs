using System.Security.Cryptography.X509Certificates;

namespace csharp_oop_shop
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prod1 = new Prodotto("babbuino", "Stupendo bellissimo imparagonabile", 10, 22);
            Console.WriteLine(
                $"Il codice del tuo prodotto: {prod1.Codice} \n " +
                $"Il nome del tuo prodotto: {prod1.Nome} \n " +
                $"La Descrizione del tuo prodotto: {prod1.Descrizione} \n " +
                $"Il prezzo senza iva: ${prod1.Prezzo} \n " +
                $"L'iva del prodotto: {prod1.Iva}% \n " +
                $"Il prezzo con l'iva: ${prod1.PrezzoIva()} \n " +
                $"Il nome completo: {prod1.NomeCompleto()} \n " +
                $"-------BONUS------- \n" +
                $"Il codice con il padding: {prod1.CodicePadding()}"
                );



        }
    }
}