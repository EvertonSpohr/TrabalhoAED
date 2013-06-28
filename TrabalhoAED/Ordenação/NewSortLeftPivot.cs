using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class NewSortLeftPivot
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

        int meio = 0; ///VARIAVEL GLOBAL PARA O MEIO 

//METODOS =================================================================================

//NEW SORT LEFT PIVOT =====================================================================================
        
        void reorganizaLeft(int esq, int dir, int count, int pos)
        {

            int i = esq, j = dir, p = esq;
            char[] aux = new char[count];

            for (int k = p + 1; k <= dir; k++)
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

            for (int k = esq; k <= dir; k++)
            {
                N_Mov++;
                Analizador.Lista_Vet[pos][k] = aux[k];
            }
        }
//-------------------------------------------------------------------------------------------------------
        void LeftSort(int esq, int dir, int count, int pos)
        {
            N_Comp++;
            if (esq < dir)
            {
                reorganizaLeft(esq, dir, count, pos);
                LeftSort(esq, meio - 1, count, pos);
                LeftSort(meio + 1, dir, count, pos);
            }
        }
//-------------------------------------------------------------------------------------------------------
        public void newSortLeftPivot(int n,int pos)
        {
            LeftSort(0, n - 1, n, pos);
        }
//=========================================================================================================

    }
}
