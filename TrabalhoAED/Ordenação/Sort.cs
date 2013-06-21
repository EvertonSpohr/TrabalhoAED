using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class Sort
    {

//BUBBLE SORT =============================================================================================
        public void bubbleSort(int n)
        {
            Console.Out.WriteLine("Dentro do Bubble Sort");

            int i, j;
            char temp;
                        
            for (j = n - 1; j > 0; j--) {                
                for (i = 0; i < j; i++) {
                    if ((int)Analizador.Vet_Texto[i] > (int)Analizador.Vet_Texto[i + 1])
                    {
                        temp = Analizador.Vet_Texto[i]; // se for realiza a troca
                        Analizador.Vet_Texto[i] = Analizador.Vet_Texto[i + 1];
                        Analizador.Vet_Texto[i + 1] = temp;                        
                    }                
                }
            }
        }
//=========================================================================================================

//HEAP SORT ===============================================================================================
        public void refazHeap(int esq, int dir) 
        {
            int i = esq, j = (2 * i);
            int pai = 0;
            int x = (int)Analizador.Vet_Texto[i];

            while ((j <= dir) && (pai == 0))
            { 
                if (j < dir)
                {

                    if ((int)Analizador.Vet_Texto[j] < (int)Analizador.Vet_Texto[j + 1])
                    {                       
                        j++;
                    }
                }
                if (x < (int)Analizador.Vet_Texto[j])
                {
                    Analizador.Vet_Texto[i] = Analizador.Vet_Texto[j];
                    i = j;
                    j = (2 * i);
                }
                else
                {
                    pai = 1;
                }
                Analizador.Vet_Texto[i] = (char)x;
            }       
        }
//----------------------------------------------------------------------------------------------        
        void constroiHeap(int n){

            int esq;

            for(esq = n-1; esq >= 0; esq--){
                refazHeap(esq, n-2);
            }

        }
//-------------------------------------------------------------------------------------------------
        public void heapSort(int n) 
        {

            Console.Out.WriteLine("Dentro do HeapSort");

            int esq = 0;
            int dir;

            constroiHeap(n);

            for (dir = n - 2; dir >= 0; dir--) {

                char x = Analizador.Vet_Texto[0];
                Analizador.Vet_Texto[0] = Analizador.Vet_Texto[dir + 1];
                Analizador.Vet_Texto[dir + 1] = x;            

            refazHeap(esq, dir);
        }

        }
//=========================================================================================================

//INSERTION SORT ==========================================================================================
        public void insertionSort(int n) 
        {

            Console.Out.WriteLine("Dentro do Insertion Sort");

            int i, j;
            char temp;

            for (i = 1; i < n - 1; ++i) {   ///VERIFICAR INDICE ------

                temp = Analizador.Vet_Texto[i];

                for (j = i - 1; j >= 0 && (int)temp < (int)Analizador.Vet_Texto[j]; j--)
                {

                    Analizador.Vet_Texto[j + 1] = Analizador.Vet_Texto[j];
                }
                Analizador.Vet_Texto[j + 1] = temp;    
        }

        }




//SHELL SORT ===============================================================================================
        public void shellsort(int n){

            Console.Out.WriteLine("Dentro do shell");

            int i, d;
            bool flag = true;
            d = n;
            while(d > 1 | flag){
                flag = false;
                d = (d+1)/2;
                for(i = 0; i < n-d; i++){
                    if((int)Analizador.Vet_Texto[i] > (int)Analizador.Vet_Texto[i+d]){
                        char aux = Analizador.Vet_Texto[d+i];
                        Analizador.Vet_Texto[d+i] = Analizador.Vet_Texto[i];
                        Analizador.Vet_Texto[i] = aux;
                        flag = true;
                    }
                }

            }

        }


    }
}
