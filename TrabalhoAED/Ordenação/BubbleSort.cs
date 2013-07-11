using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

/*
 *  Classe que implementa o algoritmo bubblesort
 *  
 *  Estratégia: 
 *  O Bubble sort  é um algoritmo de ordenação simples e ineficiênte. Ele trabalha
 *  comparando cada elemento da lista com o próximo e efetua a troca caso esteja fora 
 *  de ordem, quando não há mais nenhuma troca realizada o algoritmo para e a lista está ordenada. 
 * 
*/

namespace TrabalhoAED.Ordenação
{
    class BubbleSort
    {
//ATRIBUTOS ==================================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS ====================================================================================

//BUBBLE SORT =============================================================================================
        public void bubbleSort(int n, int pos)
        {            
            int i, j;
            char temp;

            for (j = n - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    N_Comp++;
                    if ((int)Analizador.Lista_Vet[pos][i] > (int)Analizador.Lista_Vet[pos][i + 1])
                    {
                        N_Mov++;

                        temp = Analizador.Lista_Vet[pos][i]; // se for realiza a troca
                        Analizador.Lista_Vet[pos][i] = Analizador.Lista_Vet[pos][i + 1];
                        Analizador.Lista_Vet[pos][i + 1] = temp;
                    }
                }
            }
        }
//=========================================================================================================

    }
}
