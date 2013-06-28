using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class ShellSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;


//METODOS =================================================================================================

//SHELL SORT ===============================================================================================
        public void shellSort(int n, int pos)
        {

            Console.Out.WriteLine("Dentro do shell");

            int i, d;
            bool flag = true;
            d = n - 1;
            while(d > 1 | flag){
                flag = false;
                d = (d+1)/2;
                for(i = 0; i < n-d; i++){                    
                    N_Comp++;
                    if ((int)Analizador.Lista_Vet[pos][i] > (int)Analizador.Lista_Vet[pos][i + d])
                    {
                        
                        N_Mov++;

                        char aux = Analizador.Lista_Vet[pos][d + i];
                        Analizador.Lista_Vet[pos][d + i] = Analizador.Lista_Vet[pos][i];
                        Analizador.Lista_Vet[pos][i] = aux;
                        flag = true;
                    }
                }

            }

        }
//========================================================================================================

    }
}
