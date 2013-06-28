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
        void reorganizaMiddle(int esq, int dir, int count, int pos)
        {

            int i = esq, j = dir, k, p = (esq + dir) / 2;
            char[] aux = new char[count];

            for (k = esq; k <= p - 1; k++)
            {

                N_Comp++;
                if ((int)Analizador.Lista_Vet[pos][p] > (int)Analizador.Lista_Vet[pos][k])
                {
                    N_Mov++;

                    aux[i] = Analizador.Lista_Vet[pos][k];
                    i++;
                }
                else
                {
                    N_Mov++;

                    aux[j] = Analizador.Lista_Vet[pos][k];
                    j--;
                }
            }

            for (k = p + 1; k <= dir; k++)
            {

                N_Comp++;

                if ((int)Analizador.Lista_Vet[pos][p] > (int)Analizador.Lista_Vet[pos][k])
                {
                    N_Mov++;

                    aux[i] = Analizador.Lista_Vet[pos][k];
                    i++;
                }
                else
                {
                    N_Mov++;

                    aux[j] = Analizador.Lista_Vet[pos][k];
                    j--;
                }
            }

            N_Mov++;
            aux[i] = Analizador.Lista_Vet[pos][p];
            meio = i;

            for (k = esq; k <= dir; k++)
            {
                N_Mov++;
                Analizador.Lista_Vet[pos][k] = aux[k];
            }
        }
//-------------------------------------------------------------------------------------------------------
        void MiddleSort(int esq, int dir, int count, int pos)
        {
            N_Comp++;
            if (esq < dir)
            {
                reorganizaMiddle(esq, dir, count, pos);
                MiddleSort(esq, meio - 1, count, pos);
                MiddleSort(meio + 1, dir, count, pos);
            }
        }
//-------------------------------------------------------------------------------------------------------
        public void newSortMiddlePivot(int n, int pos)
        {
            MiddleSort(0, n - 1, n, pos);
        }
//=========================================================================================================

    }
}
