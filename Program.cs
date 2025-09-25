using System;
using System.Globalization;

class ComparadorDeConsumoComArray
{
    static void Main()
    {

        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("--- Comparativo de Consumo de Combustível (km/L) ---");
        Console.WriteLine();

        string[] modelos = { "Chevrolet Onix", "Renault Kwid", "Fiat Mobi" };
        double[] consumoGasolina = { 13.9, 14.9, 13.5 };
        double[] consumoEtanol = { 9.9, 10.3, 9.6 };

        for (int i = 0; i < modelos.Length; i++)
        {
            Console.WriteLine($"--- Modelo: {modelos[i]} ---");
            Console.WriteLine($"Gasolina: {consumoGasolina[i]:F1} km/L");
            Console.WriteLine($"Etanol: {consumoEtanol[i]:F1} km/L");
            Console.WriteLine();
        }
    }
}