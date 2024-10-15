// See https://aka.ms/new-console-template for more information

/* Creare un programma che prende in input dall'utente due lati di un triangolo rettangolo e che vada a calcolare l'ipotenusa tramite il teorema di pitagora:*/

//Console.WriteLine("Calcolo dell'ipotenusa di un triangolo rettangolo.");

//Console.Write("Inserisci il valore del primo lato: ");
//double cateto1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Inserisci il valore del secondo lato: ");
//double cateto2 = Convert.ToDouble(Console.ReadLine());

//double ipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));

//Console.WriteLine($"L'ipotenusa del triangolo è: {ipotenusa}");

/*
Console.Write("Inserisci il valore del primo cateto: ");
string side1Str = Console.ReadLine();
double side1 = double.Parse(side1Str);

Console.Write("Inserisci il valore del secondo cateto: ");
string side2Str = Console.ReadLine();
double side2 = double.Parse(side2Str);

double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

Console.WriteLine($"L'ipotenusa del triangolo è: {hypotenuse}");*/

/* Creare un programma nel quale vengono prei in input due numeri dall'utente 
    dopodichè dire all'utente (tramite Console.WriteLine o writeLine) quel tra i due è il maggiore o se sono uguali
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci il primo numero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Inserisci il secondo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"Il numero maggiore è: {num1}");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"Il numero maggiore è: {num2}");
        }
        else
        {
            Console.WriteLine("I due numeri sono uguali.");
        }
    }
}
