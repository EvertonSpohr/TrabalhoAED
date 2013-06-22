using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class NewSortMiddlePivot
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

        int meio = 0; ///VARIAVEL GLOBAL PARA O MEIO 

//METODOS =================================================================================
                
//NEW SORT MIDDLE PIVOT ===================================================================================
        void reorganizaMiddle(int esq, int dir, int count)
        {

            int i = esq, j = dir, k, p = (esq + dir) / 2;
            char[] aux = new char[count];

            for (k = esq; k <= p - 1; k++)
            {

                N_Comp++;
                if ((int)Analizador.Vet_Texto[p] > (int)Analizador.Vet_Texto[k])
                {
                    N_Mov++;

                    aux[i] = Analizador.Vet_Texto[k];
                    i++;
                }
                else
                {
                    N_Mov++;

                    aux[j] = Analizador.Vet_Texto[k];
                    j--;
                }
            }

            for (k = p + 1; k <= dir; k++)
            {

                N_Comp++;

                if ((int)Analizador.Vet_Texto[p] > (int)Analizador.Vet_Texto[k])
                {
                    N_Mov++;

                    aux[i] = Analizador.Vet_Texto[k];
                    i++;
                }
                else
                {
                    N_Mov++;

                    aux[j] = Analizador.Vet_Texto[k];
                    j--;
                }
            }

            N_Mov++;
            aux[i] = Analizador.Vet_Texto[p];
            meio = i;

            for (k = esq; k <= dir; k++)
            {
                N_Mov++;
                Analizador.Vet_Texto[k] = aux[k];
            }
        }
//-------------------------------------------------------------------------------------------------------
        void MiddleSort(int esq, int dir, int count)
        {
            N_Comp++;
            if (esq < dir)
            {
                reorganizaMiddle(esq, dir, count);
                MiddleSort(esq, meio - 1, count);
                MiddleSort(meio + 1, dir, count);
            }
        }
//-------------------------------------------------------------------------------------------------------
        public void newSortMiddlePivot(int n)
        {
            MiddleSort(0, n - 1, n);
        }
//=========================================================================================================

    }
}
