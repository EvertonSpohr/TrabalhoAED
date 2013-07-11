using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

/*
 *  Esta classe implementa o algoritmo shellSort
 *  
 *  Estrategia:
 *  Refinamento do método de inserção direta. O algoritmo difere do método de inserção direta pelo fato 
 *  de no lugar de considerar o vetor a ser ordenado como um único segmento, ele considera vários segmentos 
 *  sendo aplicado o método de inserção direta em cada um deles.Basicamente o algoritmo passa várias vezes
 *  pela lista dividindo o grupo maior em menores. Nos grupos menores é aplicado o método da ordenação por inserção.
    O algoritmo de Shell Sort em si mesmo não ordena nada, mas aumenta a eficiência de outros algoritmos de ordenação 
 * (como o da inserção e seleção), o que definitivamente faz sentido quando se entende como ele funciona
 * 
 */


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
