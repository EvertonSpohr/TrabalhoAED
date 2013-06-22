using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class InsertionSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS =================================================================================

//INSERTION SORT ==========================================================================================
        public void insertionSort(int n)
        {

            Console.Out.WriteLine("Dentro do Insertion Sort");

            int i, j;
            char temp;

            for (i = 1; i < n - 1; ++i)
            {   
                temp = Analizador.Vet_Texto[i];

                for (j = i - 1; j >= 0 && (int)temp < (int)Analizador.Vet_Texto[j]; j--)
                {
                    N_Comp++; N_Comp++; N_Mov++;

                    Analizador.Vet_Texto[j + 1] = Analizador.Vet_Texto[j];
                }
                Analizador.Vet_Texto[j + 1] = temp;
                N_Mov++;
            }

        }
//=========================================================================================================

    }
}
