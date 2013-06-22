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
        void intercala(int esq, int dir, int meio)
        {
            int i, j;
            char x;

            for (i = meio + 1; i <= dir; i++)
            {
                j = i - 1;
                x = Analizador.Vet_Texto[i];

                while ((j >= esq) && ((int)x < (int)Analizador.Vet_Texto[j]))
                {
                    N_Comp++; N_Comp++; N_Mov++;

                    Analizador.Vet_Texto[j + 1] = Analizador.Vet_Texto[j];
                    j--;
                }
                Analizador.Vet_Texto[j + 1] = x;
                N_Mov++;
            }
        }
//-------------------------------------------------------------------------------------------------------
        void marge(int esq, int dir)
        {
            int meio;

            N_Comp++;
            if (esq < dir)
            {
                meio = (esq + dir) / 2;
                marge(esq, meio);
                marge(meio + 1, dir);
                intercala(esq, dir, meio);
            }
        }
//-------------------------------------------------------------------------------------------------------
        public void margeSort(int n)
        {
            marge(0, n - 1);
        }
//==========================================================================================================

    }
}
