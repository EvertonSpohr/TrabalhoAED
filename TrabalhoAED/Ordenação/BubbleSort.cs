using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class BubbleSort
    {
//ATRIBUTOS ==================================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

//METODOS ====================================================================================

//BUBBLE SORT =============================================================================================
        public void bubbleSort(int n)
        {
            Console.Out.WriteLine("Dentro do Bubble Sort");

            int i, j;
            char temp;

            for (j = n - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    N_Comp++; 
                    if ((int)Analizador.Vet_Texto[i] > (int)Analizador.Vet_Texto[i + 1])
                    {
                        N_Mov++; 

                        temp = Analizador.Vet_Texto[i]; // se for realiza a troca
                        Analizador.Vet_Texto[i] = Analizador.Vet_Texto[i + 1];
                        Analizador.Vet_Texto[i + 1] = temp;
                    }
                }
            }
        }
//=========================================================================================================

    }
}
