// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

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


public class Prodotto
{
    public string Codice { get; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }


    public Prodotto(string nome, string descrizione, double prezzo, int iva)
    {
        Codice = CreaCodice();
        Nome = nome;
        Descrizione = descrizione;
        Prezzo = prezzo;
        Iva = iva;
    }
}