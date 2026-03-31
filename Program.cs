using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Nome Ninja ---");
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine().ToUpper();

        string nomeNinja = "";

        foreach (char letra in nome)
        {
            switch (letra)
            {
                case 'A': nomeNinja += "KA"; break;
                case 'B': nomeNinja += "ZU"; break;
                case 'C': nomeNinja += "MI"; break;
                case 'D': nomeNinja += "TE"; break;
                case 'E': nomeNinja += "KU"; break;
                case 'F': nomeNinja += "LU"; break;
                case 'G': nomeNinja += "JI"; break;
                case 'H': nomeNinja += "RI"; break;
                case 'I': nomeNinja += "KI"; break;
                case 'J': nomeNinja += "ZUS"; break;
                case 'K': nomeNinja += "ME"; break;
                case 'L': nomeNinja += "TA"; break;
                case 'M': nomeNinja += "RIN"; break;
                case 'N': nomeNinja += "TO"; break;
                case 'O': nomeNinja += "MO"; break;
                case 'P': nomeNinja += "NO"; break;
                case 'Q': nomeNinja += "KE"; break;
                case 'R': nomeNinja += "SHI"; break;
                case 'S': nomeNinja += "ARI"; break;
                case 'T': nomeNinja += "CHI"; break;
                case 'U': nomeNinja += "DO"; break;
                case 'V': nomeNinja += "RU"; break;
                case 'W': nomeNinja += "MEI"; break;
                case 'X': nomeNinja += "NA"; break;
                case 'Y': nomeNinja += "FU"; break;
                case 'Z': nomeNinja += "ZI"; break;
                default: break; // ignora espaços e caracteres
            }
        }

        Console.WriteLine("\nSeu nome ninja é " + nomeNinja + ".");
    }
}