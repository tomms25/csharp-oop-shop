
//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//-codice(numero intero)
//- nome
//- descrizione
//- prezzo
//- iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.




using System;
namespace csharp_oop_shop
{
    public class Product
    {
        public string Code { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Iva { get; set; }

        public Product(string name, string description, double price, int iva)
        {
            Code = CreateCode();
            Name = name;
            Description = description;
            Price = price;
            Iva = iva;
        }

        private string CreateCode()
        {
            var code = new Random().Next(0, 100000000);
            return code.ToString().PadLeft(8, '0');
        }

        public double PricePlusIva()
        {
            var result = Price + (Price * Iva / 100);
            return result;
        }

        public string NamePlusCode()
        {
            var result = $"{Code} {Name}";
            return result;
        }

        public override string ToString()
        {
            var nl = Environment.NewLine;

            var result = $"Prodotto: {NamePlusCode()}" + nl
                + $"Codice: {Code}" + nl
                + $"Nome del prodotto: {Name}" + nl
                + $"Descrizione del prodotto: {Description}" + nl
                + $"Prezzo del prodotto: {Price} $" + nl
                + $"Percentuale Iva: {Iva}" + nl
                + $"Prezzo con Iva: {PricePlusIva()} €";
            return result;
        }
    }
}

