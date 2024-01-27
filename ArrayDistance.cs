using System;

public class ArrayDistance
{
    public static int distanciaEntrePosicaoDosArrays(int[] primeiroArray, int[] segundoArray)
    {
        int menorDistancia = int.MaxValue;

        for (int i = 0; i < primeiroArray.Length; i++)
        {
            for (int j = 0; j < segundoArray.Length; j++)
            {
                int distancia = Math.Abs(primeiroArray[i] - segundoArray[j]);
                if (distancia < menorDistancia)
                {
                    menorDistancia = distancia;
                }
            }
        }

        return menorDistancia;
    }
}
