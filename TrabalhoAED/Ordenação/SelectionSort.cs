using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

/*
 *  Esta classe implementa o algoritmo selection sort
 *  Estrategia:
 *      Selecionar o menor elemento
 *      Trocalo com a primeira possicao do vetor
 *      processo repetido N-1 vezes até que o vetor esteja ordenado
 */

namespace TrabalhoAED.Ordenação
{
    class SelectionSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================

//SELECTION SORT ==========================================================================================
        int MenorElem(int cont, int ini, int pos)
        {
            int j = ini;
            char temp = Analizador.Lista_Vet[pos][ini];

            for (int i = ini; i < cont; i++)
            {
                N_Comp++;
                if ((int)temp > (int)Analizador.Lista_Vet[pos][i])
                {                    
                    temp = Analizador.Lista_Vet[pos][i];
                    j = i;
                }
            }
            return j;
        }
//------------------------------------------------------------------------------------------------------
        public void selectionSort(int n, int pos)
        {
            int j;
            char temp;

            for (int i = 0; i < n; i++)
            {
                N_Mov++;

                j = MenorElem(n, i, pos);
                temp = Analizador.Lista_Vet[pos][j];
                Analizador.Lista_Vet[pos][j] = Analizador.Lista_Vet[pos][i];
                Analizador.Lista_Vet[pos][i] = temp;
            }
        }
//==========================================================================================================

    }
}
