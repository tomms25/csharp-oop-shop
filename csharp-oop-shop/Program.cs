// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;
using csharp_oop_shop;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");


int lenght = Convert.ToInt32(Console.ReadLine());

Product[] products = new Product[lenght];

for (int i = 0; i < lenght; i++)
{
    Console.WriteLine($"Inserire il nome del {i + 1}° prodotto:");
    string name = Console.ReadLine();

    Console.WriteLine($"Inserire la descrizione del {i + 1}° prodotto:");
    string description = Console.ReadLine();

    Console.WriteLine($"Inserire il prezzo del {i + 1}° prodotto:");
    double prezzo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Inserire l'iva sul {i + 1}° prodotto:");
    int iva = Convert.ToInt32(Console.ReadLine());

    Product obj = new Product(name, description, prezzo, iva);

    products[i] = obj;

    Console.WriteLine("Prodotto inserito correttamente.");

    Console.WriteLine();
}


Console.WriteLine("Lista dei prodotti:");
Console.WriteLine();


for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ToString());
    Console.WriteLine();
}

