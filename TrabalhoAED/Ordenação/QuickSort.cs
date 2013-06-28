using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class QuickSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================
//QUICK SORT =====================================================================================
        void QS(int esq, int dir, int pos)
        {

            int i = esq, j = dir, meio = (int)Analizador.Lista_Vet[pos][(esq + dir) / 2];

            do
            {
                while ((i < dir) && ((int)Analizador.Lista_Vet[pos][i] < meio))
                {
                    N_Comp++; N_Comp++;

                    i++;
                }

                while ((j > esq) && ((int)Analizador.Lista_Vet[pos][j] > meio))
                {
                    N_Comp++; N_Comp++;

                    j--;
                }

                N_Comp++;
                if (i <= j)
                {
                    N_Mov++;
                    char temp = Analizador.Lista_Vet[pos][i];
                    Analizador.Lista_Vet[pos][i] = Analizador.Lista_Vet[pos][j];
                    Analizador.Lista_Vet[pos][j] = temp;
                    i++; j--;
                }

                N_Comp++;
            } while (i <= j);

            N_Comp++;
            if (esq < j)
            {
                QS(esq, j, pos);
            }

            N_Comp++;
            if (i < dir)
            {
                QS(i, dir, pos);
            }

        }
 //-----------------------------------------------------------------------------------------------------
        public void quickSort(int n, int pos)
        {
            QS(0, n - 1, pos);
        }
//=========================================================================================================

    }
}
