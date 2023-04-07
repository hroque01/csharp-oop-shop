using System.Security.Cryptography.X509Certificates;

namespace csharp_oop_shop
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio base
            Prodotto latte = new Prodotto("Parmalat Latte", "Stupendo bellissimo Buonissimo", 1.50m, 22);
            Console.WriteLine(
                $"Il codice del tuo prodotto: {latte.Codice} \n " +
                $"Il nome del tuo prodotto: {latte.Nome} \n " +
                $"La Descrizione del tuo prodotto: {latte.Descrizione} \n " +
                $"Il prezzo senza iva: ${latte.Prezzo} \n " +
                $"L'iva del prodotto: {latte.Iva}% \n " +
                $"Il prezzo con l'iva: ${latte.PrezzoIva()} \n " +
                $"Il nome completo: {latte.NomeCompleto()} \n " +
                $"-------BONUS------- \n" +
                $"Il codice con il padding: {latte.CodicePadding()}"
                );

            //Array ESERCIZIO BONUS
            Prodotto[] prodottiBelli = new Prodotto[] { 
                new Prodotto("Parmalat Latte", "Stupendo bellissimo Buonissimo", 1.50m, 22),
                new Prodotto("Sushi", "Shushi bellissimo giapponese", 8.00m , 22),
                new Prodotto("Gocciole", "Giocciole buonissime al gusto di caccao", 3.00m , 22),
                new Prodotto("PS5", "Console schifoso", 600, 22),
                new Prodotto("Nintendo SWITCH", "'Console' che si crede una vera console ma non regge nemmeno Apex Legends", 399, 24),
                new Prodotto("VR", "VR dei cinesi che se metti dentro il telefonino ti sembra di essere in un rollercoster", 20, 24),
            };

            int i = 1;
            foreach (var proddotto in prodottiBelli )
            {
                Console.WriteLine($" --- {i++} Prodotto --- \n" +
                $"Il codice del tuo prodotto: {proddotto.Codice}\n" +
                $"Il nome del tuo prodotto: {proddotto.Nome}\n" +
                $"La Descrizione del tuo prodotto: {proddotto.Descrizione}\n" +
                $"Il prezzo senza iva: ${proddotto.Prezzo}\n" +
                $"L'iva del prodotto: {proddotto.Iva}%\n" +
                $"Il prezzo con l'iva: ${proddotto.PrezzoIva()}\n" +
                $"Il nome completo: {proddotto.NomeCompleto()}\n" +
                $"Il codice con il padding: {proddotto.CodicePadding()}" +
                $"\n"
                );
            }
        }
    }
}