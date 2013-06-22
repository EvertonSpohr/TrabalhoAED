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
        void QS(int esq, int dir)
        {

            int i = esq, j = dir, meio = (int)Analizador.Vet_Texto[(esq + dir) / 2];

            do
            {
                while ((i < dir) && ((int)Analizador.Vet_Texto[i] < meio))
                {
                    N_Comp++; N_Comp++;

                    i++;
                }

                while ((j > esq) && ((int)Analizador.Vet_Texto[j] > meio))
                {
                    N_Comp++; N_Comp++;

                    j--;
                }

                N_Comp++;
                if (i <= j)
                {
                    N_Mov++;
                    char temp = Analizador.Vet_Texto[i];
                    Analizador.Vet_Texto[i] = Analizador.Vet_Texto[j];
                    Analizador.Vet_Texto[j] = temp;
                    i++; j--;
                }

                N_Comp++;
            } while (i <= j);

            N_Comp++;
            if (esq < j)
            {
                QS(esq, j);
            }

            N_Comp++;
            if (i < dir)
            {
                QS(i, dir);
            }

        }
 //-----------------------------------------------------------------------------------------------------
        public void quickSort(int n)
        {
            QS(0, n - 1);
        }
//=========================================================================================================

    }
}
