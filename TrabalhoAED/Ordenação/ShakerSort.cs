using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class ShakerSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================

//SHAKER SORT =============================================================================================
        public void shakerSort(int n)
        {
            int i;
            Boolean troca = false;
            char temp;

            do
            {

                troca = false;

                for (i = n - 1; i > 0; i--)
                {
                    N_Comp++;
                    if ((int)Analizador.Vet_Texto[i - 1] > (int)Analizador.Vet_Texto[i])
                    {
                        N_Mov++;
                        
                        troca = true;
                        temp = Analizador.Vet_Texto[i - 1];
                        Analizador.Vet_Texto[i - 1] = Analizador.Vet_Texto[i];
                        Analizador.Vet_Texto[i] = temp;
                    }
                }

                for (i = 1; i < n; i++)
                {
                    N_Comp++;
                    if ((int)Analizador.Vet_Texto[i - 1] > (int)Analizador.Vet_Texto[i])
                    {
                        N_Mov++;

                        troca = true;
                        temp = Analizador.Vet_Texto[i - 1];
                        Analizador.Vet_Texto[i - 1] = Analizador.Vet_Texto[i];
                        Analizador.Vet_Texto[i] = temp;
                    }
                }


            } while (troca);
        }
//=========================================================================================================

    }
}
