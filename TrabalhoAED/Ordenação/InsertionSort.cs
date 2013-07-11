using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

/*
 *  Esta classe implementa o algoritmo insertion sort
 *  Estrategia:
 *      O algoritmo do insertion sort consiste basicamente em percorrer o vetor da esquerda para a
 *      direita e ordenar de acordo com o que se encontra a esquerda da posição atual até o início do vetor
 */


namespace TrabalhoAED.Ordenação
{
    class InsertionSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================

//INSERTION SORT ==========================================================================================
        public void insertionSort(int n, int pos)
        {
            int i, j;
            char temp;

            for (i = 1; i < n - 1; ++i)
            {
                temp = Analizador.Lista_Vet[pos][i];

                for (j = i - 1; j >= 0 && (int)temp < (int)Analizador.Lista_Vet[pos][j]; j--)
                {
                    N_Comp++; N_Comp++; N_Mov++;

                    Analizador.Lista_Vet[pos][j + 1] = Analizador.Lista_Vet[pos][j];
                }
                Analizador.Lista_Vet[pos][j + 1] = temp;
                N_Mov++;
            }

        }
//=========================================================================================================

    }
}
