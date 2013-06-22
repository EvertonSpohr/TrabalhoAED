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
        void refazHeap(int esq, int dir)
        {
            int i = esq, j = (2 * i);
            int pai = 0;
            int x = (int)Analizador.Vet_Texto[i];

            while ((j <= dir) && (pai == 0))
            {

                N_Comp++; N_Comp++;

                N_Comp++;
                if (j < dir)
                {
                    N_Comp++;
                    if ((int)Analizador.Vet_Texto[j] < (int)Analizador.Vet_Texto[j + 1])
                    {
                        j++;
                    }
                }

                N_Comp++;
                if (x < (int)Analizador.Vet_Texto[j])
                {
                    N_Mov++;
                    Analizador.Vet_Texto[i] = Analizador.Vet_Texto[j];
                    i = j;
                    j = (2 * i);
                }
                else
                {
                    pai = 1;
                }
                Analizador.Vet_Texto[i] = (char)x;
            }
        }
        //----------------------------------------------------------------------------------------------        
        void constroiHeap(int n)
        {

            int esq;

            for (esq = n - 1; esq >= 0; esq--)
            {
                refazHeap(esq, n - 2);
            }

        }
        //-------------------------------------------------------------------------------------------------
        public void heapSort(int n)
        {

            Console.Out.WriteLine("Dentro do HeapSort");

            int esq = 0;
            int dir;

            constroiHeap(n);

            for (dir = n - 2; dir >= 0; dir--)
            {

                N_Mov++;

                char x = Analizador.Vet_Texto[0];
                Analizador.Vet_Texto[0] = Analizador.Vet_Texto[dir + 1];
                Analizador.Vet_Texto[dir + 1] = x;

                refazHeap(esq, dir);
            }

        }
//=========================================================================================================


    }
}
