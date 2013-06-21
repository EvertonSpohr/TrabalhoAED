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
