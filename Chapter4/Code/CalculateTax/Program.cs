﻿using System;
using static System.Console;

namespace CalculateTax
{
    class Program
    {
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland 
                    rate = 0.08M;
                    break;
                case "DK": // Denmark 
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "PL": // Poland
                    rate = 0.23M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states 
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }
        
        static decimal CalculateTax2(decimal amount, string twoLetterRegionCode){
            decimal rate = 0.0M;
            string twoLetterRegionCodeUpper = twoLetterRegionCode.ToUpper();
            rate = twoLetterRegionCodeUpper switch
            {
                "CH" => 0.08M,
                "DK" or "NO" => 0.25M,
                "GB" or "FR" => 0.2M,
                "HU" => 0.27M,
                "PL" => 0.23M,
                "OR" or "AK" or "MT" => 0.0M,
                "ND" or "WI" or "ME" or "VA"  => 0.05M,
                "CA" => 0.0825M,
                 _ => 0.06M,
            };
            return amount * rate;

        }
        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax2(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }
        static void Main(string[] args)
        {
            RunCalculateTax();
        }
    }
}
