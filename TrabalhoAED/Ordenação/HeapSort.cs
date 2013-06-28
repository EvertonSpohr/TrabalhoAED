using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class HeapSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================


//HEAP SORT ===============================================================================================
        void refazHeap(int esq, int dir, int pos)
        {
            int i = esq, j = (2 * i);
            int pai = 0;
            int x = (int)Analizador.Lista_Vet[pos][i];

            while ((j <= dir) && (pai == 0))
            {

                N_Comp++; N_Comp++;

                N_Comp++;
                if (j < dir)
                {
                    N_Comp++;
                    if ((int)Analizador.Lista_Vet[pos][j] < (int)Analizador.Lista_Vet[pos][j + 1])
                    {
                        j++;
                    }
                }

                N_Comp++;
                if (x < (int)Analizador.Lista_Vet[pos][j])
                {
                    N_Mov++;
                    Analizador.Lista_Vet[pos][i] = Analizador.Lista_Vet[pos][j];
                    i = j;
                    j = (2 * i);
                }
                else
                {
                    pai = 1;
                }
                Analizador.Lista_Vet[pos][i] = (char)x;
            }
        }
        //----------------------------------------------------------------------------------------------        
        void constroiHeap(int n, int pos)
        {

            int esq;

            for (esq = n - 1; esq >= 0; esq--)
            {
                refazHeap(esq, n - 2, pos);
            }

        }
        //-------------------------------------------------------------------------------------------------
        public void heapSort(int n, int pos)
        {

            Console.Out.WriteLine("Dentro do HeapSort");

            int esq = 0;
            int dir;

            constroiHeap(n, pos);

            for (dir = n - 2; dir >= 0; dir--)
            {

                N_Mov++;

                char x = Analizador.Lista_Vet[pos][0];
                Analizador.Lista_Vet[pos][0] = Analizador.Lista_Vet[pos][dir + 1];
                Analizador.Lista_Vet[pos][dir + 1] = x;

                refazHeap(esq, dir, pos);
            }

        }
//=========================================================================================================


    }
}
