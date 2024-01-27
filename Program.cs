using System;

class Program
{
    static void Main(string[] args)
    {
        int[] primeiroArray = { 1, 4, 6, 12, 123, 192, 131, 111, 297, 109 };
        int[] segundoArray = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };

        int menorDistancia = ArrayDistance.distanciaEntrePosicaoDosArrays(primeiroArray, segundoArray);
        Console.WriteLine("A menor distância entre os dois arrays é: " + menorDistancia);

        string encryptedMessage = "10011010 11110111 01010100 00011001 00011010 10101111 00000001 00101111 11101110 01010111 00110110 11101111";
        string decryptedMessage = MessageDecryption.DecryptMessage(encryptedMessage);
        Console.WriteLine(decryptedMessage);
    }
}
