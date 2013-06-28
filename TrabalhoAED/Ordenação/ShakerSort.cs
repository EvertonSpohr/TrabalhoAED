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
        public void shakerSort(int n, int pos)
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
                    if ((int)Analizador.Lista_Vet[pos][i - 1] > (int)Analizador.Lista_Vet[pos][i])
                    {
                        N_Mov++;
                        
                        troca = true;
                        temp = Analizador.Lista_Vet[pos][i - 1];
                        Analizador.Lista_Vet[pos][i - 1] = Analizador.Lista_Vet[pos][i];
                        Analizador.Lista_Vet[pos][i] = temp;
                    }
                }

                for (i = 1; i < n; i++)
                {
                    N_Comp++;
                    if ((int)Analizador.Lista_Vet[pos][i - 1] > (int)Analizador.Lista_Vet[pos][i])
                    {
                        N_Mov++;

                        troca = true;
                        temp = Analizador.Lista_Vet[pos][i - 1];
                        Analizador.Lista_Vet[pos][i - 1] = Analizador.Lista_Vet[pos][i];
                        Analizador.Lista_Vet[pos][i] = temp;
                    }
                }


            } while (troca);
        }
//=========================================================================================================

    }
}
