using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class MergeSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================

//MERGE SORT ==============================================================================================
        void intercala(int esq, int dir, int meio, int pos)
        {
            int i, j;
            char x;

            for (i = meio + 1; i <= dir; i++)
            {
                j = i - 1;
                x = Analizador.Lista_Vet[pos][i];

                while ((j >= esq) && ((int)x < (int)Analizador.Lista_Vet[pos][j]))
                {
                    N_Comp++; N_Comp++; N_Mov++;

                    Analizador.Lista_Vet[pos][j + 1] = Analizador.Lista_Vet[pos][j];
                    j--;
                }
                Analizador.Lista_Vet[pos][j + 1] = x;
                N_Mov++;
            }
        }
//-------------------------------------------------------------------------------------------------------
        void marge(int esq, int dir, int pos)
        {
            int meio;

            N_Comp++;
            if (esq < dir)
            {
                meio = (esq + dir) / 2;
                marge(esq, meio, pos);
                marge(meio + 1, dir, pos);
                intercala(esq, dir, meio, pos);
            }
        }
//-------------------------------------------------------------------------------------------------------
        public void margeSort(int n, int pos)
        {
            marge(0, n - 1, pos);
        }
//==========================================================================================================

    }
}
